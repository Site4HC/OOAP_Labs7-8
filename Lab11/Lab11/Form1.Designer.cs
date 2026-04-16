namespace MovieScraperApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBoxMovies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            listBoxMovies = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;
            // 
            // listBoxMovies
            // 
            listBoxMovies.Location = new Point(12, 60);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(854, 379);
            listBoxMovies.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(880, 460);
            Controls.Add(btnStart);
            Controls.Add(listBoxMovies);
            Name = "Form1";
            Text = "Movie Scraper";
            ResumeLayout(false);
        }
    }
}