using System;
using System.Windows.Forms;

namespace GameTopUpApp
{
    public partial class MainForm : Form
    {
        // Saldo awal pemain
        private int playerBalance = 1000;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Menampilkan saldo awal pemain
            UpdateBalanceLabel();
        }

        private void topUpButton_Click(object sender, EventArgs e)
        {
            // Mendapatkan jumlah top-up yang dimasukkan oleh pemain
            int topUpAmount;
            if (int.TryParse(topUpTextBox.Text, out topUpAmount) && topUpAmount > 0)
            {
                // Menambahkan jumlah top-up ke saldo pemain
                playerBalance += topUpAmount;

                // Memperbarui saldo pemain
                UpdateBalanceLabel();

                // Memberi tahu pemain bahwa top-up berhasil
                MessageBox.Show("Top-up berhasil dilakukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mengosongkan kotak teks top-up
                topUpTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Masukkan jumlah top-up yang valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBalanceLabel()
        {
            // Memperbarui label saldo dengan saldo pemain yang terbaru
            balanceLabel.Text = "Saldo Anda: $" + playerBalance.ToString();
        }
    }
}
