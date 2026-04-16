using System;
using System.Windows.Forms;

namespace AuctionApp
{
    public partial class Form1 : Form
    {
        private readonly Auctioneer _auctioneer;

        public Form1()
        {
            InitializeComponent();
            _auctioneer = new Auctioneer();
            _auctioneer.OnLog += LogMessage;
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var name = txtParticipantName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введіть ім'я учасника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var participant = new Participant(name);
            participant.OnNotificationReceived += LogMessage;

            _auctioneer.Attach(participant);
            cmbParticipants.Items.Add(participant);

            txtParticipantName.Clear();
            if (cmbParticipants.Items.Count == 1)
            {
                cmbParticipants.SelectedIndex = 0;
            }
        }

        private void btnRemoveParticipant_Click(object sender, EventArgs e)
        {
            if (cmbParticipants.SelectedItem is Participant selectedParticipant)
            {
                selectedParticipant.OnNotificationReceived -= LogMessage;
                _auctioneer.Detach(selectedParticipant);
                cmbParticipants.Items.Remove(selectedParticipant);

                if (cmbParticipants.Items.Count > 0)
                {
                    cmbParticipants.SelectedIndex = 0;
                }
                else
                {
                    cmbParticipants.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Оберіть учасника для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlaceBid_Click(object sender, EventArgs e)
        {
            if (cmbParticipants.SelectedItem is Participant selectedParticipant)
            {
                decimal bidAmount = numBidAmount.Value;
                _auctioneer.PlaceBid(selectedParticipant, bidAmount);
                lblCurrentBid.Text = $"Поточна ставка: {_auctioneer.CurrentBid} ({_auctioneer.HighestBidder})";
            }
            else
            {
                MessageBox.Show("Оберіть учасника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LogMessage(string message)
        {
            lstLog.Items.Add(message);
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }
    }
}