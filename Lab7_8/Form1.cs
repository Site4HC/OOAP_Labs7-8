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

        public MainForm()
        {
            InitializeComponent();
            InitializeSystem();
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

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
            UpdateUI();
            MessageBox.Show("Розклад виконано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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