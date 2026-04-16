using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartRoomApp.Core;

namespace SmartRoomApp
{
    public partial class MainForm : Form
    {
        private readonly RemoteControl _remote = new RemoteControl();
        private List<SmartDevice> _devices;
        private System.Windows.Forms.Timer _scheduleTimer;

        public MainForm()
        {
            InitializeComponent();
            InitializeSystem();
            InitializeTimer();
        }

        private void InitializeSystem()
        {
            try
            {
                _devices = new List<SmartDevice>
        {
            new SmartDevice("Світло"),
            new SmartDevice("Котел"),
            new SmartDevice("Кондиціонер")
        };

                cmbDevices.DataSource = _devices;
                cmbDevices.DisplayMember = "Name";

                dgvSchedule.Columns.Clear();

                dgvSchedule.Columns.Add("DeviceColumn", "Пристрій");
                dgvSchedule.Columns.Add("ActionColumn", "Дія (вкл/викл)");
                dgvSchedule.Columns.Add("TimeColumn", "Час (HH:mm)");

                var checkColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "StatusColumn",
                    HeaderText = "Виконано",
                    ReadOnly = true
                };
                dgvSchedule.Columns.Add(checkColumn);

                dgvSchedule.Rows.Add("Світло", "вкл", "08:00", false);
                dgvSchedule.Rows.Add("Котел", "викл", "08:30", false);
                dgvSchedule.Rows.Add("Кондиціонер", "вкл", "09:00", false);

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeTimer()
        {
            _scheduleTimer = new System.Windows.Forms.Timer();
            _scheduleTimer.Interval = 1000;
            _scheduleTimer.Tick += ScheduleTimer_Tick;
            _scheduleTimer.Start();
        }

        private void ScheduleTimer_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm");

            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.IsNewRow || row.Cells[0].Value == null) continue;

                string deviceName = row.Cells[0].Value.ToString();
                string stateStr = row.Cells[1].Value?.ToString().ToLower();

                string scheduledTime = "";
                if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                {
                    scheduledTime = row.Cells[2].Value.ToString();
                }

                bool isExecuted = false;
                if (row.Cells.Count > 3 && row.Cells[3].Value != null)
                {
                    isExecuted = Convert.ToBoolean(row.Cells[3].Value);
                }

                if (!isExecuted && scheduledTime == currentTime)
                {
                    var device = _devices.FirstOrDefault(d => d.Name.Equals(deviceName, StringComparison.OrdinalIgnoreCase));

                    if (device != null)
                    {
                        bool state = (stateStr == "вкл" || stateStr == "on" || stateStr == "1");

                        _remote.ExecuteCommand(new DeviceCommand(device, state));

                        if (row.Cells.Count > 3)
                        {
                            row.Cells[3].Value = true;
                        }

                        UpdateUI();
                    }
                }
            }
        }

        private void btnExecuteManual_Click(object sender, EventArgs e)
        {
            if (cmbDevices.SelectedItem is SmartDevice selectedDevice)
            {
                try
                {
                    bool targetState = rbOn.Checked;
                    var command = new DeviceCommand(selectedDevice, targetState);

                    _remote.ExecuteCommand(command);
                    UpdateUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка команди", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                int steps = (int)numSteps.Value;
                _remote.Undo(steps);
                UpdateUI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непередбачувана помилка: {ex.Message}");
            }
        }

        private void btnRunSchedule_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.IsNewRow || row.Cells[0].Value == null) continue;

                string deviceName = row.Cells[0].Value.ToString();
                string stateStr = row.Cells[1].Value?.ToString().ToLower();

                var device = _devices.FirstOrDefault(d => d.Name.Equals(deviceName, StringComparison.OrdinalIgnoreCase));

                if (device != null)
                {
                    bool state = (stateStr == "вкл" || stateStr == "on" || stateStr == "1");
                    _remote.ExecuteCommand(new DeviceCommand(device, state));

                    if (row.Cells.Count > 3)
                    {
                        row.Cells[3].Value = true;
                    }
                }
            }
            UpdateUI();
            MessageBox.Show("Всі команди з розкладу виконано миттєво!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateUI()
        {
            UpdateStatusLabel(lblLightStatus, _devices[0]);
            UpdateStatusLabel(lblBoilerStatus, _devices[1]);
            UpdateStatusLabel(lblACStatus, _devices[2]);

            btnUndo.Enabled = _remote.CanUndo;
        }

        private void UpdateStatusLabel(Label lbl, SmartDevice device)
        {
            lbl.Text = $"● {device.Name}: {(device.IsOn ? "УВІМКНЕНО" : "ВИМКНЕНО")}";
            lbl.ForeColor = device.IsOn ? Color.Green : Color.Gray;
        }
    }
}