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
    public partial class Form1 : Form
    {
        private readonly FinanceDbContext dbContext; 
        public Form1(FinanceDbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyFrm cF = new CurrencyFrm(dbContext);
            cF.ShowDialog();
        }
    }
}
