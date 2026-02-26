namespace DateInterpreterSimulation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblInput
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Text = "Введіть дату (напр. 31-12-2023):";

            // txtDate
            this.txtDate.Location = new System.Drawing.Point(20, 40);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);

            // lblFormat
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(220, 20);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Text = "Оберіть формат:";

            // cmbFormat
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] { "DD-MM-YYYY", "MM-DD-YYYY", "YYYY-MM-DD" });
            this.cmbFormat.Location = new System.Drawing.Point(220, 40);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(120, 21);

            // btnParse
            this.btnParse.Location = new System.Drawing.Point(20, 75);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(320, 30);
            this.btnParse.Text = "Інтерпретувати дату";
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(20, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Text = "Результат з'явиться тут...";

            // Form1
            this.ClientSize = new System.Drawing.Size(370, 220);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Парсер дат (Interpreter Pattern)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}