using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string first = "", second = "";
        double firstdb = 0, seconddb = 0, converter = 0;
        double GEL = 1, USD = 3.10, RUB = 0.04;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbfirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            first = cbfirst.Text;
        }

        private void cbsecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            second = cbsecond.Text;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            converter = Convert.ToDouble(tbfirst.Text);
            switch (first)
            {
                case "GEL":
                    converter = converter / GEL;
                    break;
                case "USD":
                    converter = converter * USD;
                    break;
                case "RUB":
                    converter = converter * RUB;
                    break;
            }
            switch (second)
            {
                case "GEL":
                    converter = converter / GEL;
                    break;
                case "USD":
                    converter = converter / USD;
                    break;
                case "RUB":
                    converter = converter / RUB;
                    break;
            }
            tbansw.Text = converter.ToString();
        }
    }
}
