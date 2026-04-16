namespace Lab9_OOAP
{
    partial class Form1
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
            this.cmbScenarios = new System.Windows.Forms.ComboBox();
            this.clbArtifacts = new System.Windows.Forms.CheckedListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblScenario = new System.Windows.Forms.Label();
            this.lblArtifacts = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.cmbScenarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScenarios.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbScenarios.FormattingEnabled = true;
            this.cmbScenarios.Location = new System.Drawing.Point(20, 45);
            this.cmbScenarios.Name = "cmbScenarios";
            this.cmbScenarios.Size = new System.Drawing.Size(340, 31);
            this.cmbScenarios.TabIndex = 0;

            this.clbArtifacts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbArtifacts.FormattingEnabled = true;
            this.clbArtifacts.Location = new System.Drawing.Point(20, 120);
            this.clbArtifacts.Name = "clbArtifacts";
            this.clbArtifacts.Size = new System.Drawing.Size(340, 104);
            this.clbArtifacts.TabIndex = 1;
            this.clbArtifacts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbArtifacts_ItemCheck);

            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(20, 250);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(340, 50);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Пройти випробування";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

            this.lblScenario.AutoSize = true;
            this.lblScenario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScenario.Location = new System.Drawing.Point(16, 15);
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Size = new System.Drawing.Size(163, 23);
            this.lblScenario.TabIndex = 3;
            this.lblScenario.Text = "Оберіть сценарій:";

            this.lblArtifacts.AutoSize = true;
            this.lblArtifacts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArtifacts.Location = new System.Drawing.Point(16, 90);
            this.lblArtifacts.Name = "lblArtifacts";
            this.lblArtifacts.Size = new System.Drawing.Size(252, 23);
            this.lblArtifacts.TabIndex = 4;
            this.lblArtifacts.Text = "Оберіть артефакти (макс. 2):";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 333);
            this.Controls.Add(this.lblArtifacts);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.clbArtifacts);
            this.Controls.Add(this.cmbScenarios);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Темний ліс";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbScenarios;
        private System.Windows.Forms.CheckedListBox clbArtifacts;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.Label lblArtifacts;
    }
}