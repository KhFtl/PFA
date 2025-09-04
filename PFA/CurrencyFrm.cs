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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var item = _dbContext.Currencies.ToList();
           Currency c = new Currency
           {
               Name = "Доллар",
               Symbol = "$"
           };
           _dbContext.Currencies.Add(c);
           _dbContext.SaveChanges();
        }
    }
}
