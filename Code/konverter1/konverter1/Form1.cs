using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;


namespace konverter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = nbrb();
        }

        private String nbrb()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            //String response = wc.DownloadString("http://www.nbrb.by/");
            String response = wc.DownloadString("http://www.nbrb.by/API/ExRates/Currencies");
            String rate = System.Text.RegularExpressions.Regex.Match(response, @"1 Евро</td><td align=""right"">([0-9]+\.[0-9]+)").Groups[1].Value;
            return "EUR" + rate + "\n";
        }

       
       
       
    }
}
