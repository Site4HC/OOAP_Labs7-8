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
            this.grpManual = new System.Windows.Forms.GroupBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.btnExecuteManual = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.btnRunSchedule = new System.Windows.Forms.Button();
            this.grpUndo = new System.Windows.Forms.GroupBox();
            this.numSteps = new System.Windows.Forms.NumericUpDown();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblLightStatus = new System.Windows.Forms.Label();
            this.lblBoilerStatus = new System.Windows.Forms.Label();
            this.lblACStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            this.grpManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grpUndo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Smart Room Control (Command Pattern)";

            // 
            // grpManual (Панель керування)
            // 
            this.grpManual.Controls.Add(this.cmbDevices);
            this.grpManual.Controls.Add(this.rbOn);
            this.grpManual.Controls.Add(this.rbOff);
            this.grpManual.Controls.Add(this.btnExecuteManual);
            this.grpManual.Location = new System.Drawing.Point(12, 50);
            this.grpManual.Name = "grpManual";
            this.grpManual.Size = new System.Drawing.Size(200, 180);
            this.grpManual.Text = "Ручне керування";

            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.Location = new System.Drawing.Point(15, 30);
            this.cmbDevices.Size = new System.Drawing.Size(170, 23);

            this.rbOn.Checked = true;
            this.rbOn.Location = new System.Drawing.Point(15, 70);
            this.rbOn.Text = "Увімкнути";

            this.rbOff.Location = new System.Drawing.Point(15, 95);
            this.rbOff.Text = "Вимкнути";

            this.btnExecuteManual.Location = new System.Drawing.Point(15, 130);
            this.btnExecuteManual.Size = new System.Drawing.Size(170, 35);
            this.btnExecuteManual.Text = "Виконати команду";
            this.btnExecuteManual.UseVisualStyleBackColor = true;
            this.btnExecuteManual.Click += new System.EventHandler(this.btnExecuteManual_Click);

            // 
            // dgvSchedule (Таблиця розкладу)
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(230, 60);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(400, 250);

            // 
            // btnRunSchedule
            // 
            this.btnRunSchedule.Location = new System.Drawing.Point(230, 316);
            this.btnRunSchedule.Size = new System.Drawing.Size(400, 40);
            this.btnRunSchedule.Text = "Запустити команди з розкладу";
            this.btnRunSchedule.Click += new System.EventHandler(this.btnRunSchedule_Click);

            // 
            // grpUndo (Панель відміни)
            // 
            this.grpUndo.Controls.Add(this.numSteps);
            this.grpUndo.Controls.Add(this.btnUndo);
            this.grpUndo.Location = new System.Drawing.Point(12, 240);
            this.grpUndo.Name = "grpUndo";
            this.grpUndo.Size = new System.Drawing.Size(200, 116);
            this.grpUndo.Text = "Історія операцій";

            this.numSteps.Location = new System.Drawing.Point(15, 30);
            this.numSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.btnUndo.Location = new System.Drawing.Point(15, 65);
            this.btnUndo.Size = new System.Drawing.Size(170, 35);
            this.btnUndo.Text = "Undo (Відмінити)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);

            // 
            // pnlStatus (Нижня панель статусів)
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblLightStatus);
            this.pnlStatus.Controls.Add(this.lblBoilerStatus);
            this.pnlStatus.Controls.Add(this.lblACStatus);
            this.pnlStatus.Location = new System.Drawing.Point(0, 380);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(650, 50);

            this.lblLightStatus.Location = new System.Drawing.Point(10, 15);
            this.lblLightStatus.Size = new System.Drawing.Size(150, 20);
            this.lblLightStatus.Text = "● Світло: ---";

            this.lblBoilerStatus.Location = new System.Drawing.Point(220, 15);
            this.lblBoilerStatus.Size = new System.Drawing.Size(150, 20);
            this.lblBoilerStatus.Text = "● Котел: ---";

            this.lblACStatus.Location = new System.Drawing.Point(430, 15);
            this.lblACStatus.Size = new System.Drawing.Size(200, 20);
            this.lblACStatus.Text = "● Кондиціонер: ---";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(644, 431);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.grpUndo);
            this.Controls.Add(this.btnRunSchedule);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.grpManual);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.Text = "Smart Home System";
            this.grpManual.ResumeLayout(false);
            this.grpManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grpUndo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSteps)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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