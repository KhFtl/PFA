using PFA.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PFA
{
    public partial class WalletFrm : Form
    {
        private readonly FinanceDbContext _dbContext;
        public WalletFrm(FinanceDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadCurrencies();
            LoadTableWallets();
        }
        private void LoadCurrencies()
        {
            var currencyNames = _dbContext.Currencies.ToList();
            comboBox1.DataSource = currencyNames;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CurrencyId";
        }

        private void LoadTableWallets()
        {
            var wallets = _dbContext.Wallets
                .Select(w => new
                {
                    WalletId = w.WalletId,
                    Name = w.Name,
                    Balance = w.Balance,
                    Symbol = w.Currency != null ? w.Currency.Symbol : "",
                    Currency = w.Currency != null ? w.Currency.Name : ""
                })
                .ToList();

            dgrv_wallet.DataSource = wallets;

            // Set Ukrainian column headers
            dgrv_wallet.Columns["Name"].HeaderText = "Назва гаманця";
            dgrv_wallet.Columns["Balance"].HeaderText = "Баланс";
            dgrv_wallet.Columns["Symbol"].HeaderText = "Символ валюти";
            dgrv_wallet.Columns["Currency"].HeaderText = "Валюта";

            // Hide WalletId column
            dgrv_wallet.Columns["WalletId"].Visible = false;

            // Set column order: Name, Balance, Symbol, Currency
            dgrv_wallet.Columns["Name"].DisplayIndex = 0;
            dgrv_wallet.Columns["Balance"].DisplayIndex = 1;
            dgrv_wallet.Columns["Symbol"].DisplayIndex = 2;
            dgrv_wallet.Columns["Currency"].DisplayIndex = 3;

            dgrv_wallet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? walletName = textBox1.Text;
            decimal? Balance = textBox2.Text.Length > 0 ? decimal.Parse(textBox2.Text) : null;
            int? CurrencyId = Convert.ToInt32(comboBox1.SelectedValue);
            if (walletName == null || Balance == null || CurrencyId == null)
            { 
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Wallet wallet = new Wallet
            {
                Name = walletName,
                Balance = (decimal)Balance,
                CurrencyId = (int)CurrencyId
            };
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
            LoadTableWallets();
        }
    }
}
