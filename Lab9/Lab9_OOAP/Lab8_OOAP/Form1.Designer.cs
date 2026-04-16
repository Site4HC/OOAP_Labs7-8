namespace AuctionApp
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
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.btnRemoveParticipant = new System.Windows.Forms.Button();
            this.cmbParticipants = new System.Windows.Forms.ComboBox();
            this.numBidAmount = new System.Windows.Forms.NumericUpDown();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblCurrentBid = new System.Windows.Forms.Label();
            this.lblParticipantName = new System.Windows.Forms.Label();
            this.lblSelectParticipant = new System.Windows.Forms.Label();
            this.lblBidAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBidAmount)).BeginInit();
            this.SuspendLayout();

            this.lblParticipantName.AutoSize = true;
            this.lblParticipantName.Location = new System.Drawing.Point(12, 15);
            this.lblParticipantName.Name = "lblParticipantName";
            this.lblParticipantName.Size = new System.Drawing.Size(84, 13);
            this.lblParticipantName.Text = "Ім'я учасника:";

            this.txtParticipantName.Location = new System.Drawing.Point(102, 12);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(120, 20);

            this.btnAddParticipant.Location = new System.Drawing.Point(228, 10);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(100, 23);
            this.btnAddParticipant.Text = "Додати";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);

            this.lblSelectParticipant.AutoSize = true;
            this.lblSelectParticipant.Location = new System.Drawing.Point(12, 53);
            this.lblSelectParticipant.Name = "lblSelectParticipant";
            this.lblSelectParticipant.Size = new System.Drawing.Size(52, 13);
            this.lblSelectParticipant.Text = "Учасник:";

            this.cmbParticipants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParticipants.FormattingEnabled = true;
            this.cmbParticipants.Location = new System.Drawing.Point(102, 50);
            this.cmbParticipants.Name = "cmbParticipants";
            this.cmbParticipants.Size = new System.Drawing.Size(120, 21);

            this.btnRemoveParticipant.Location = new System.Drawing.Point(228, 48);
            this.btnRemoveParticipant.Name = "btnRemoveParticipant";
            this.btnRemoveParticipant.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveParticipant.Text = "Видалити";
            this.btnRemoveParticipant.UseVisualStyleBackColor = true;
            this.btnRemoveParticipant.Click += new System.EventHandler(this.btnRemoveParticipant_Click);

            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Location = new System.Drawing.Point(12, 82);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(46, 13);
            this.lblBidAmount.Text = "Ставка:";

            this.numBidAmount.Location = new System.Drawing.Point(102, 80);
            this.numBidAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numBidAmount.Name = "numBidAmount";
            this.numBidAmount.Size = new System.Drawing.Size(120, 20);

            this.btnPlaceBid.Location = new System.Drawing.Point(228, 77);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(100, 23);
            this.btnPlaceBid.Text = "Зробити ставку";
            this.btnPlaceBid.UseVisualStyleBackColor = true;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click);

            this.lblCurrentBid.AutoSize = true;
            this.lblCurrentBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentBid.Location = new System.Drawing.Point(12, 115);
            this.lblCurrentBid.Name = "lblCurrentBid";
            this.lblCurrentBid.Size = new System.Drawing.Size(147, 16);
            this.lblCurrentBid.Text = "Поточна ставка: 0";

            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(15, 145);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(400, 186);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 341);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblCurrentBid);
            this.Controls.Add(this.btnPlaceBid);
            this.Controls.Add(this.numBidAmount);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.btnRemoveParticipant);
            this.Controls.Add(this.cmbParticipants);
            this.Controls.Add(this.lblSelectParticipant);
            this.Controls.Add(this.btnAddParticipant);
            this.Controls.Add(this.txtParticipantName);
            this.Controls.Add(this.lblParticipantName);
            this.Name = "Form1";
            this.Text = "Аукціон (Observer)";
            ((System.ComponentModel.ISupportInitialize)(this.numBidAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnRemoveParticipant;
        private System.Windows.Forms.ComboBox cmbParticipants;
        private System.Windows.Forms.NumericUpDown numBidAmount;
        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblCurrentBid;
        private System.Windows.Forms.Label lblParticipantName;
        private System.Windows.Forms.Label lblSelectParticipant;
        private System.Windows.Forms.Label lblBidAmount;
    }
}