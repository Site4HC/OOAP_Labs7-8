namespace MovieScraperApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Button btnStart;

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
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 15;
            this.listBoxMovies.Location = new System.Drawing.Point(12, 53);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(776, 379);
            this.listBoxMovies.TabIndex = 0;

            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Завантажити";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxMovies);
            this.Name = "Form1";
            this.Text = "Movie Scraper";
            this.ResumeLayout(false);
        }
    }
}
