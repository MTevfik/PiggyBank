
using System;
using System.Windows.Forms;

namespace PiggyBank
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFold = new System.Windows.Forms.Button();
            this.buttonBreak = new System.Windows.Forms.Button();
            this.buttonShake = new System.Windows.Forms.Button();
            this.cmbBankNote = new System.Windows.Forms.ComboBox();
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.dgvBanknotes = new System.Windows.Forms.DataGridView();
            this.dgvCoins = new System.Windows.Forms.DataGridView();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanknotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(375, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 47);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Para Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFold
            // 
            this.buttonFold.Location = new System.Drawing.Point(375, 130);
            this.buttonFold.Name = "buttonFold";
            this.buttonFold.Size = new System.Drawing.Size(127, 47);
            this.buttonFold.TabIndex = 1;
            this.buttonFold.Text = "Parayı Katla";
            this.buttonFold.UseMnemonic = false;
            this.buttonFold.UseVisualStyleBackColor = true;
            this.buttonFold.Click += new System.EventHandler(this.buttonFold_Click);
            // 
            // buttonBreak
            // 
            this.buttonBreak.Location = new System.Drawing.Point(375, 184);
            this.buttonBreak.Name = "buttonBreak";
            this.buttonBreak.Size = new System.Drawing.Size(127, 47);
            this.buttonBreak.TabIndex = 3;
            this.buttonBreak.Text = "Kumbarayı Kır";
            this.buttonBreak.UseVisualStyleBackColor = true;
            this.buttonBreak.Click += new System.EventHandler(this.buttonBreak_Click);
            // 
            // buttonShake
            // 
            this.buttonShake.Location = new System.Drawing.Point(375, 77);
            this.buttonShake.Name = "buttonShake";
            this.buttonShake.Size = new System.Drawing.Size(127, 47);
            this.buttonShake.TabIndex = 2;
            this.buttonShake.Text = "Salla";
            this.buttonShake.UseVisualStyleBackColor = true;
            this.buttonShake.Click += new System.EventHandler(this.buttonShake_Click);
            // 
            // cmbBankNote
            // 
            this.cmbBankNote.FormattingEnabled = true;
            this.cmbBankNote.Location = new System.Drawing.Point(31, 38);
            this.cmbBankNote.Name = "cmbBankNote";
            this.cmbBankNote.Size = new System.Drawing.Size(129, 21);
            this.cmbBankNote.TabIndex = 4;
            this.cmbBankNote.Text = "Kağıt Para";
            this.cmbBankNote.SelectedIndexChanged += new System.EventHandler(this.cmbBankNote_SelectedIndexChanged);
            // 
            // cmbCoin
            // 
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(194, 38);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(129, 21);
            this.cmbCoin.TabIndex = 5;
            this.cmbCoin.Text = "Madeni Para";
            this.cmbCoin.SelectedIndexChanged += new System.EventHandler(this.cmbCoin_SelectedIndexChanged_1);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVolume.Location = new System.Drawing.Point(28, 94);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(71, 18);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Hacim : 0";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtra.Location = new System.Drawing.Point(28, 147);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(74, 18);
            this.lblExtra.TabIndex = 7;
            this.lblExtra.Text = "Boşluk : 0";
            // 
            // dgvBanknotes
            // 
            this.dgvBanknotes.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvBanknotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanknotes.Location = new System.Drawing.Point(10, 388);
            this.dgvBanknotes.Name = "dgvBanknotes";
            this.dgvBanknotes.Size = new System.Drawing.Size(242, 118);
            this.dgvBanknotes.TabIndex = 8;
            // 
            // dgvCoins
            // 
            this.dgvCoins.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoins.Location = new System.Drawing.Point(271, 388);
            this.dgvCoins.Name = "dgvCoins";
            this.dgvCoins.Size = new System.Drawing.Size(242, 118);
            this.dgvCoins.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(26, 189);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(79, 29);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(535, 526);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dgvCoins);
            this.Controls.Add(this.dgvBanknotes);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.cmbCoin);
            this.Controls.Add(this.cmbBankNote);
            this.Controls.Add(this.buttonBreak);
            this.Controls.Add(this.buttonShake);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PiggyBank";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanknotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                MessageBox.Show("# PiggyBank uygulamasına hoşgeldiniz! \n# Eklemek isteğiniz para türünü seçtikten sonra (eğer " +
                    "kağıt para seçtiyseniz katlamak zorundasınız!) para ekle butonuna tıklamalısınız. \n# Kumbara içerisindeki " +
                    "gereksiz boşlukları yok etmek ve daha fazla para ekleyebilmek için salla butonuna tıklayabilirsiniz. \n# Kumbara içerisinde biriken " +
                    "miktarı görmek için bir defaya mahsus kumbarayı kırabilir ve yapıştırabilirsiniz.","Piggy-Bank Bilgilendirme!");
            });
        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFold;
        private System.Windows.Forms.Button buttonBreak;
        private System.Windows.Forms.Button buttonShake;
        private System.Windows.Forms.ComboBox cmbBankNote;
        private System.Windows.Forms.ComboBox cmbCoin;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.DataGridView dgvBanknotes;
        private System.Windows.Forms.DataGridView dgvCoins;
        private System.Windows.Forms.Label lblAmount;
        private EventHandler lblAmount_Click;
    }
}

