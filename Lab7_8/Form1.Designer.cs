namespace SmartRoomApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpManual = new GroupBox();
            cmbDevices = new ComboBox();
            rbOn = new RadioButton();
            rbOff = new RadioButton();
            btnExecuteManual = new Button();
            dgvSchedule = new DataGridView();
            btnRunSchedule = new Button();
            grpUndo = new GroupBox();
            numSteps = new NumericUpDown();
            btnUndo = new Button();
            pnlStatus = new Panel();
            lblLightStatus = new Label();
            lblBoilerStatus = new Label();
            lblACStatus = new Label();
            lblTitle = new Label();
            grpManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            grpUndo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSteps).BeginInit();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // grpManual
            // 
            grpManual.Controls.Add(cmbDevices);
            grpManual.Controls.Add(rbOn);
            grpManual.Controls.Add(rbOff);
            grpManual.Controls.Add(btnExecuteManual);
            grpManual.Location = new Point(12, 50);
            grpManual.Name = "grpManual";
            grpManual.Size = new Size(200, 180);
            grpManual.TabIndex = 5;
            grpManual.TabStop = false;
            grpManual.Text = "Ручне керування";
            // 
            // cmbDevices
            // 
            cmbDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDevices.Location = new Point(15, 30);
            cmbDevices.Name = "cmbDevices";
            cmbDevices.Size = new Size(170, 23);
            cmbDevices.TabIndex = 0;
            // 
            // rbOn
            // 
            rbOn.Checked = true;
            rbOn.Location = new Point(15, 70);
            rbOn.Name = "rbOn";
            rbOn.Size = new Size(104, 24);
            rbOn.TabIndex = 1;
            rbOn.TabStop = true;
            rbOn.Text = "Увімкнути";
            // 
            // rbOff
            // 
            rbOff.Location = new Point(15, 95);
            rbOff.Name = "rbOff";
            rbOff.Size = new Size(104, 24);
            rbOff.TabIndex = 2;
            rbOff.Text = "Вимкнути";
            // 
            // btnExecuteManual
            // 
            btnExecuteManual.Location = new Point(15, 130);
            btnExecuteManual.Name = "btnExecuteManual";
            btnExecuteManual.Size = new Size(170, 35);
            btnExecuteManual.TabIndex = 3;
            btnExecuteManual.Text = "Виконати команду";
            btnExecuteManual.UseVisualStyleBackColor = true;
            btnExecuteManual.Click += btnExecuteManual_Click;
            // 
            // dgvSchedule
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedule.Location = new Point(230, 60);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(420, 250);
            dgvSchedule.TabIndex = 4;
            // 
            // btnRunSchedule
            // 
            btnRunSchedule.Location = new Point(230, 316);
            btnRunSchedule.Name = "btnRunSchedule";
            btnRunSchedule.Size = new Size(420, 40);
            btnRunSchedule.TabIndex = 3;
            btnRunSchedule.Text = "Запустити команди з розкладу";
            btnRunSchedule.Click += btnRunSchedule_Click;
            // 
            // grpUndo
            // 
            grpUndo.Controls.Add(numSteps);
            grpUndo.Controls.Add(btnUndo);
            grpUndo.Location = new Point(12, 240);
            grpUndo.Name = "grpUndo";
            grpUndo.Size = new Size(200, 116);
            grpUndo.TabIndex = 2;
            grpUndo.TabStop = false;
            grpUndo.Text = "Історія операцій";
            // 
            // numSteps
            // 
            numSteps.Location = new Point(15, 30);
            numSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSteps.Name = "numSteps";
            numSteps.Size = new Size(120, 23);
            numSteps.TabIndex = 0;
            numSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(15, 65);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(170, 35);
            btnUndo.TabIndex = 1;
            btnUndo.Text = "Undo (Відмінити)";
            btnUndo.Click += btnUndo_Click;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.WhiteSmoke;
            pnlStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlStatus.Controls.Add(lblLightStatus);
            pnlStatus.Controls.Add(lblBoilerStatus);
            pnlStatus.Controls.Add(lblACStatus);
            pnlStatus.Location = new Point(0, 380);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(650, 50);
            pnlStatus.TabIndex = 1;
            // 
            // lblLightStatus
            // 
            lblLightStatus.Location = new Point(10, 15);
            lblLightStatus.Name = "lblLightStatus";
            lblLightStatus.Size = new Size(150, 20);
            lblLightStatus.TabIndex = 0;
            lblLightStatus.Text = "● Світло: ---";
            // 
            // lblBoilerStatus
            // 
            lblBoilerStatus.Location = new Point(220, 15);
            lblBoilerStatus.Name = "lblBoilerStatus";
            lblBoilerStatus.Size = new Size(150, 20);
            lblBoilerStatus.TabIndex = 1;
            lblBoilerStatus.Text = "● Котел: ---";
            // 
            // lblACStatus
            // 
            lblACStatus.Location = new Point(430, 15);
            lblACStatus.Name = "lblACStatus";
            lblACStatus.Size = new Size(200, 20);
            lblACStatus.TabIndex = 2;
            lblACStatus.Text = "● Кондиціонер: ---";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(435, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart Room Control (Command Pattern)";
            // 
            // MainForm
            // 
            ClientSize = new Size(693, 431);
            Controls.Add(lblTitle);
            Controls.Add(pnlStatus);
            Controls.Add(grpUndo);
            Controls.Add(btnRunSchedule);
            Controls.Add(dgvSchedule);
            Controls.Add(grpManual);
            Font = new Font("Segoe UI", 9F);
            Name = "MainForm";
            Text = "Smart Home System";
            grpManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            grpUndo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSteps).EndInit();
            pnlStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpManual;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.Button btnExecuteManual;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Button btnRunSchedule;
        private System.Windows.Forms.GroupBox grpUndo;
        private System.Windows.Forms.NumericUpDown numSteps;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblLightStatus;
        private System.Windows.Forms.Label lblBoilerStatus;
        private System.Windows.Forms.Label lblACStatus;
        private System.Windows.Forms.Label lblTitle;
    }
}