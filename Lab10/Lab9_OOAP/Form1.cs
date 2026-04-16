using DarkForestGame;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab9_OOAP
{
    public partial class Form1 : Form
    {
        private Unit _unit;
        private List<IScenario> _scenarios;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            _unit = new Unit();
            _scenarios = new List<IScenario>
            {
                new ForestScenario(),
                new RiverScenario(),
                new MountainScenario(),
                new DarkForestScenario()
            };

            cmbScenarios.DataSource = _scenarios;
            cmbScenarios.DisplayMember = "Name";

            clbArtifacts.Items.Add(Artifact.ForestCloak);
            clbArtifacts.Items.Add(Artifact.WaterBoots);
            clbArtifacts.Items.Add(Artifact.MountainClaws);
            clbArtifacts.Items.Add(Artifact.LightLantern);
        }

        private void clbArtifacts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbArtifacts.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Можна обрати не більше двох артефактів.", "Обмеження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _unit.ClearArtifacts();

            foreach (Artifact artifact in clbArtifacts.CheckedItems)
            {
                _unit.AddArtifact(artifact);
            }

            if (cmbScenarios.SelectedItem is IScenario selectedScenario)
            {
                _unit.SetScenario(selectedScenario);
                string result = _unit.Play();
                MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}