using System;
using System.Windows.Forms;
using DateInterpreterSimulation.Services;

namespace DateInterpreterSimulation
{
    public partial class Form1 : Form
    {
        private readonly DateParser _parser = new DateParser();

        public Form1()
        {
            InitializeComponent();
            cmbFormat.SelectedIndex = 0; 
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string inputDate = txtDate.Text.Trim();
            string format = cmbFormat.Text;

            if (string.IsNullOrEmpty(inputDate))
            {
                MessageBox.Show("Введіть дату!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var context = _parser.Parse(inputDate, format);

            if (context.IsValid)
            {
                lblResult.Text = $"Успіх!\nДень: {context.Day:D2}\nМісяць: {context.Month:D2}\nРік: {context.Year}";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = $"Помилка: {context.ErrorMessage}";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}