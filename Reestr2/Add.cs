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
    public partial class Add : Form
    {
        string numCard;
        DataBase db = (DataBase)Application.OpenForms["DataBase"];
        string Score;
        public Add(string score, string numberCard)
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
                    RUB = Convert.ToDouble(db.dataGridView2.Rows[i].Cells[1].Value.ToString()) + Convert.ToDouble(numericUpDown1.Value);
                    DOL = Convert.ToDouble(db.dataGridView2.Rows[i].Cells[2].Value.ToString()) + Convert.ToDouble(numericUpDown2.Value);
                    
                    
                    db.dataGridView2.Rows[i].Cells[1].Value = RUB.ToString();
                    db.dataGridView2.Rows[i].Cells[2].Value = DOL.ToString();
                    
                    
                }
            }

            db.textBox1.Text += "На счет: " + Score + " внесены рубли в размере: " + Convert.ToDouble(numericUpDown1.Value) + "руб, время: " + DateTime.Now.ToString() + "\r\n" + "внесены доллары в размере: " + Convert.ToDouble(numericUpDown2.Value) + "$ \r\nвремя:" + DateTime.Now.ToString() + "\r\n";



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
    }
}
