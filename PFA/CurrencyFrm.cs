using Microsoft.EntityFrameworkCore;
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

namespace PFA
{
    public partial class CurrencyFrm : Form
    {
        private readonly FinanceDbContext _dbContext;
        public CurrencyFrm(FinanceDbContext context)
        {
            InitializeComponent();
            _dbContext = context;
            LoadCurrenciesToListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = _dbContext.Currencies.ToList();
            Currency c = new Currency
            {
                Name = textBox1.Text,
                Symbol = textBox2.Text
            };
            var existCurrecie = _dbContext.Currencies.FirstOrDefault(x => x.Name == c.Name);
            if (existCurrecie == null)
            {
                _dbContext.Currencies.Add(c);
                _dbContext.SaveChanges();
                LoadCurrenciesToListView();
            }
            else
            {
                MessageBox.Show("Валюта з таким ім'ям вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCurrenciesToListView()
        {
            listView1.Items.Clear();
            if (listView1.Columns.Count == 0)
            {
                listView1.View = View.Details;
                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Name", 150);
                listView1.Columns.Add("Symbol", 100);
            }
            var currencies = _dbContext.Currencies.ToList();
            foreach (var currency in currencies)
            {
                var item = new ListViewItem(currency.CurrencyId.ToString());
                item.SubItems.Add(currency.Name ?? "");
                item.SubItems.Add(currency.Symbol ?? "");
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string CurencyID = listView1.SelectedItems[0].SubItems[0].Text;
                var currency = _dbContext.Currencies.Find(int.Parse(CurencyID));
                if (currency != null)
                {
                    var result = MessageBox.Show($"Ви впевнені, що хочете видалити валюту\n{currency.Name}?","Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _dbContext.Currencies.Remove(currency);
                        _dbContext.SaveChanges();
                        LoadCurrenciesToListView();
                    }
                }
            }
        }
    }
}
