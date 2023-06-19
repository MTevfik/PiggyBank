using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PiggyBank.Exceptions;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        MoneyBox moneyBox = new MoneyBox(50000);

        private readonly List<BankNote> Banknotes = new List<BankNote>();
        private readonly List<Coin> Coins = new List<Coin>();
        private readonly BindingList<Money> banknotesInMoneyBox = new BindingList<Money>();
        private readonly BindingList<Money> coinsInMoneyBox = new BindingList<Money>();

        Money selected;
        string willAdd;
        bool isFolded = false;
        int numberOfBreak = 0;
        double accumulatedAmount = 0;
        double totalVolume = 0;
        double extraVolume = 0;


        public Form1()
        {
            InitializeComponent();
            CreateMoney();
            UpdateData(banknotesInMoneyBox, coinsInMoneyBox);
        }

        private void CreateMoney()
        {
            Coins.Add(new Coin() { Key = "1 Kuruş", Val = 0.01, Cap = 16.50, Height = 1.35 });
            Coins.Add(new Coin() { Key = "5 Kuruş", Val = 0.05, Cap = 17.50, Height = 1.65 });
            Coins.Add(new Coin() { Key = "10 Kuruş", Val = 0.10, Cap = 18.50, Height = 1.65 });
            Coins.Add(new Coin() { Key = "25 Kuruş", Val = 0.25, Cap = 20.50, Height = 1.65 });
            Coins.Add(new Coin() { Key = "50 Kuruş", Val = 0.50, Cap = 23.85, Height = 1.90 });
            Coins.Add(new Coin() { Key = "1 Lira", Val = 1.0, Cap = 26.15, Height = 1.90 });

            Banknotes.Add(new BankNote() { Key = "5 Lira", Val = 5.0, Width = 64.0, Length = 130.0, Height = 0.25 });
            Banknotes.Add(new BankNote() { Key = "10 Lira", Val = 10.0, Width = 64.0, Length = 136.0, Height = 0.25 });
            Banknotes.Add(new BankNote() { Key = "20 Lira", Val = 20.0, Width = 68.0, Length = 142.0, Height = 0.25 });
            Banknotes.Add(new BankNote() { Key = "50 Lira", Val = 50.0, Width = 68.0, Length = 148.0, Height = 0.25 });
            Banknotes.Add(new BankNote() { Key = "100 Lira", Val = 100.0, Width = 72.0, Length = 154.0, Height = 0.25 });
            Banknotes.Add(new BankNote() { Key = "200 Lira", Val = 200.0, Width = 72.0, Length = 160.0, Height = 0.25 });

            cmbBankNote.Items.Add("Kağıt Para Seçiniz");
            foreach (var item in Banknotes)
            {
                cmbBankNote.Items.Add(item.Key);
            }
            cmbBankNote.SelectedIndex = 0;
            cmbCoin.Items.Add("Madeni Para Seçiniz");
            foreach (var item in Coins)
            {
                cmbCoin.Items.Add(item.Key);
            }
            cmbCoin.SelectedIndex = 0;
        }
        private void cmbBankNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBankNote.SelectedIndex > 0)
            {
                cmbCoin.Enabled = false;
                buttonFold.Visible = true;
                willAdd = cmbBankNote.SelectedItem.ToString();
                foreach (var item in Banknotes)
                {
                    if (willAdd == item.Key)
                    {
                        selected = (BankNote)item;
                    }
                }
            }
        }
        private void cmbCoin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCoin.SelectedIndex > 0)
            {
                cmbBankNote.Enabled = false;
                buttonFold.Visible = false;
                willAdd = cmbCoin.SelectedItem.ToString();
                foreach (var item in Coins)
                {
                    if (willAdd == item.Key)
                    {
                        selected = (Coin)item;
                    }
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null)
                {
                    throw new NotSelectedMoney();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (selected is Coin)
            {
                Coin bozukpara = (Coin)selected;
                try
                {
                    if (totalVolume + bozukpara.Value() + bozukpara.ExtraVolume(selected.Value()) > moneyBox.MoneyBoxValue)
                    {
                        throw new FullMoneyBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetData();
                }
                coinsInMoneyBox.Add(bozukpara);
                accumulatedAmount += bozukpara.Val;
                totalVolume += bozukpara.Value() + bozukpara.ExtraVolume(bozukpara.Value());
                extraVolume += bozukpara.ExtraVolume(bozukpara.Value());

                moneyBox.Add(bozukpara.Value() + bozukpara.ExtraVolume(bozukpara.Value()));
                PrintVolume();
            }
            else if (selected is BankNote)
            {
                BankNote kagitpara = (BankNote)selected;
                try
                {
                    if (totalVolume + kagitpara.Value() + kagitpara.ExtraVolume(selected.Value()) > moneyBox.MoneyBoxValue)
                    {
                        throw new FullMoneyBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetData();
                }
                try
                {
                    if (isFolded == false)
                    {
                        throw new BanknoteNotFolded();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                banknotesInMoneyBox.Add(kagitpara);
                accumulatedAmount += kagitpara.Val;
                totalVolume += kagitpara.Value() + kagitpara.ExtraVolume(kagitpara.Value());
                extraVolume += kagitpara.ExtraVolume(kagitpara.Value());

                moneyBox.Add(kagitpara.Value() + kagitpara.ExtraVolume(kagitpara.Value()));
                PrintVolume();
            }
            buttonShake.Enabled = true;
            ResetData();
        }
        private void ResetData()
        {
            cmbCoin.SelectedIndex = 0;
            cmbBankNote.SelectedIndex = 0;
            isFolded = false;
            buttonFold.Text = "Katla!";
            buttonFold.Enabled = true;
            buttonFold.Visible = false;
            selected = null;
            cmbCoin.Enabled = true;
            cmbBankNote.Enabled = true;
        }
        private void buttonFold_Click(object sender, EventArgs e)
        {
            BankNote willFold = (BankNote)selected;
            if (willFold != null)
            {
                isFolded = true;
                willFold.Fold(willFold.Value());
                buttonFold.Text = "Katlandı!";
                buttonFold.Enabled = false;
            }
        }
        private void buttonShake_Click(object sender, EventArgs e)
        {
            if (totalVolume > extraVolume)
            {
                totalVolume = totalVolume - moneyBox.Shake(extraVolume);
                moneyBox.Add(-moneyBox.Shake(extraVolume));
            }
            extraVolume = 0;
            buttonShake.Enabled = false;
            PrintVolume();
            ResetData();
        }
        private void buttonBreak_Click(object sender, EventArgs e)
        {
            if (numberOfBreak == 0)
            {
                UpdateData(banknotesInMoneyBox, coinsInMoneyBox, accumulatedAmount);
                try
                {
                    if (accumulatedAmount > 0)
                    {
                    }
                    else
                    {
                        throw new EmptyMoneyBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                buttonBreak.Text = "Yapıştır!";
                buttonAdd.Enabled = false;
                buttonFold.Enabled = false;
                buttonShake.Enabled = false;
                banknotesInMoneyBox.Clear();
                coinsInMoneyBox.Clear();
                numberOfBreak++;
                cmbCoin.Enabled = false;
                cmbBankNote.Enabled = false;
                ResetMoneyBox();
            }
            else if (numberOfBreak == 1)
            {
                string fullPath = Environment.CurrentDirectory;
                string parentPath = Directory.GetParent(fullPath).Parent.FullName;
                string imagePath = parentPath + "\\Resources\\yapistir.png";
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
                buttonBreak.Text = "Kır!";
                cmbCoin.Enabled = true;
                cmbBankNote.Enabled = true;
                buttonAdd.Enabled = true;
                buttonFold.Enabled = true;
                buttonShake.Enabled = true;
                numberOfBreak++;
                ResetMoneyBox();
            }
            else if (numberOfBreak > 1)
            {
                UpdateData(banknotesInMoneyBox, coinsInMoneyBox, accumulatedAmount);
                try
                {
                    if (accumulatedAmount > 0)
                    {

                    }
                    else
                    {
                        throw new EmptyMoneyBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                buttonBreak.Text = "Kırılamaz!";
                buttonAdd.Enabled = false;
                buttonBreak.Enabled = false;
                buttonFold.Enabled = false;
                buttonShake.Enabled = false;
                ResetMoneyBox();
                try
                {
                    throw new CanNotBeUsed();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }
        private void ResetMoneyBox()
        {
            accumulatedAmount = 0;
            moneyBox.Amount = 0;
            totalVolume = 0;
            extraVolume = 0;
            lblVolume.Text = "Hacim: 0";
            lblExtra.Text = "Boşluk: 0";
        }
        public void PrintVolume()
        {
            lblVolume.Text = "Hacim : " + totalVolume.ToString();
            lblExtra.Text = "Boşluk : " + extraVolume.ToString();
        }
        public void UpdateData(BindingList<Money> kagitlar, BindingList<Money> bozuklar, double birikmis)
        {
            lblAmount.Text = "Biriken Miktar: " + birikmis.ToString() + "₺";
            string fullPath = Environment.CurrentDirectory;
            string parentPath = Directory.GetParent(fullPath).Parent.FullName;
            string imagePath = parentPath + "\\Resources\\kirik.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            dgvBanknotes.Visible = true;
            dgvBanknotes.DataSource = null;
            dgvBanknotes.DataSource = kagitlar.ToList();
            dgvCoins.Visible = true;
            dgvCoins.DataSource = null;
            dgvCoins.DataSource = bozuklar.ToList();
        }
        public void UpdateData(BindingList<Money> kagitlar, BindingList<Money> bozuklar)
        {
            lblAmount.Text = "Biriken Miktar: ****";
            string fullPath = Environment.CurrentDirectory;
            string parentPath = Directory.GetParent(fullPath).Parent.FullName;
            string imagePath = parentPath + "\\Resources\\piggy-bank-agua.png";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            dgvBanknotes.Visible = false;
            dgvBanknotes.DataSource = null;
            dgvBanknotes.DataSource = kagitlar.ToList();
            dgvCoins.Visible = false;
            dgvCoins.DataSource = null;
            dgvCoins.DataSource = bozuklar.ToList();
        }
    }
}
