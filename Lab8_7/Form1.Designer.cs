namespace SoftwareDevelopmentSimulation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cmbSenders;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMsg;

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
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cmbSenders = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBoxLogs
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(12, 140);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(460, 200);

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);

            // cmbRole
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Програміст", "Тестувальник", "Замовник" });
            this.cmbRole.Location = new System.Drawing.Point(150, 30);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(120, 21);

            // btnAddMember
            this.btnAddMember.Location = new System.Drawing.Point(290, 28);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(120, 23);
            this.btnAddMember.Text = "Додати в команду";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);

            // cmbSenders (Хто пише)
            this.cmbSenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSenders.Location = new System.Drawing.Point(12, 85);
            this.cmbSenders.Name = "cmbSenders";
            this.cmbSenders.Size = new System.Drawing.Size(150, 21);

            // txtMessage
            this.txtMessage.Location = new System.Drawing.Point(180, 85);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(200, 20);

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(390, 83);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 23);
            this.btnSend.Text = "Відправити";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // Labels
            this.lblName.Text = "Ім'я:"; this.lblName.Location = new System.Drawing.Point(12, 10);
            this.lblRole.Text = "Роль:"; this.lblRole.Location = new System.Drawing.Point(150, 10);
            this.lblMsg.Text = "Повідомлення від обраного учасника:"; this.lblMsg.Location = new System.Drawing.Point(12, 65);
            this.lblMsg.AutoSize = true;

            // MainForm
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cmbSenders);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblMsg);
            this.Name = "MainForm";
            this.Text = "Симуляція розробки ПЗ (Mediator Pattern)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}