using SoftwareDevelopmentSimulation.Base;
using SoftwareDevelopmentSimulation.Interfaces;
using SoftwareDevelopmentSimulation.Models;
using SoftwareDevelopmentSimulation.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace SoftwareDevelopmentSimulation
{
    public partial class Form1 : Form
    {
        private readonly IProjectManager _pm;
        private readonly List<Colleague> _team = new List<Colleague>();

        public Form1()
        {
            InitializeComponent();
            _pm = new ProjectManager(msg => listBoxLogs.Items.Add(msg));
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я працівника.");
                return;
            }

            Colleague member = cmbRole.Text switch
            {
                "Програміст" => new Developer(txtName.Text, _pm),
                "Тестувальник" => new Tester(txtName.Text, _pm),
                "Замовник" => new Customer(txtName.Text, _pm),
                _ => null
            };

            if (member != null)
            {
                _pm.RegisterColleague(member);
                _team.Add(member);
                cmbSenders.Items.Add($"{member.Role}: {member.Name}");
                txtName.Clear();
            }

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
  
            if (cmbSenders.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть, хто відправляє повідомлення!");
                return;
            }

            var senderObj = _team[cmbSenders.SelectedIndex];
            string message = txtMessage.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                senderObj.Send(message);
                txtMessage.Clear();
            }
        }
    }
}