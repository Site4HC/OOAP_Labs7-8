using System;
using System.Windows.Forms;
using JournalEditorial.Core;

namespace JournalEditorial
{
    public partial class MainForm : Form
    {
        private EmployeeHandler _editorialChain;

        public MainForm()
        {
            InitializeComponent();
            BuildChain();
        }

        private void BuildChain()
        {

            var editor = new EditorHandler();
            var layout = new LayoutMakerHandler();
            var designer = new DesignerHandler();

            editor.SetNext(layout);
            layout.SetNext(designer);

            _editorialChain = editor;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var task = new EditorialTask(txtTitle.Text, (TaskType)cmbTaskType.SelectedIndex);
                string result = _editorialChain.Handle(task);
                txtLog.AppendText($"{DateTime.Now:HH:mm:ss} > {result}{Environment.NewLine}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Валідація", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Критичний збій", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}