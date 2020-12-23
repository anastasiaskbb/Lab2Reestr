using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reestr2
{
    public partial class withdraw : Form
    {
        string numCard;
        DataBase db = (DataBase)Application.OpenForms["DataBase"];
        string Score;
        public withdraw(string score, string numberCard)
        {
            InitializeComponent();
            Score = score;
            numCard = numberCard;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double RUB = 0;
            double DOL = 0;
            for (int i = 0; i < db.dataGridView2.RowCount - 1; i++)
            {
                if (db.dataGridView2.Rows[i].Cells[0].Value.ToString() == Score)
                {
                    RUB = Convert.ToDouble(db.dataGridView2.Rows[i].Cells[1].Value.ToString()) - Convert.ToDouble(numericUpDown1.Value);
                    DOL = Convert.ToDouble(db.dataGridView2.Rows[i].Cells[2].Value.ToString()) - Convert.ToDouble(numericUpDown2.Value);
                    if (RUB >= 0 && DOL>=0)
                    {
                        db.dataGridView2.Rows[i].Cells[1].Value = RUB.ToString();
                        db.dataGridView2.Rows[i].Cells[2].Value = DOL.ToString();
                    }
                    else
                    {
                        label4.Visible = true;
                        
                        return;
                    }
                }
            }

            db.textBox1.Text += "Со счета: " + Score + " сняты рубли в размере: " + Convert.ToDouble(numericUpDown1.Value) + "руб, время: " + DateTime.Now.ToString() + "\r\n" + " сняты доллары в размере: " + Convert.ToDouble(numericUpDown2.Value) + "$ \r\nвремя:" + DateTime.Now.ToString() + "\r\n";
            


            if (checkBox1.Checked)
            {
                Check ch = new Check();
                ch.textBox1.Text = "Номер карты: " + numCard + "\r\nНа вашем счету:" + "\r\n" + RUB + " рублей" + "\r\n" + DOL + " долларов" + "\r\n \r\n OOO СБЕРНАСТЯ";
                ch.Show();
            }
            services sc = (services)Application.OpenForms["services"];
            sc.Close();
            Form1 f = new Form1();
            f.Show();
            this.Close();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
