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
    public partial class services : Form
    {
        public string numberCard;
        public string score;
        DataBase db = (DataBase)Application.OpenForms["DataBase"];

        public services(String numCard)
        {
            InitializeComponent();
            numberCard = numCard;

            for (int i = 0; i < db.dataGridView1.RowCount - 1; i++)
            {
                if (db.dataGridView1.Rows[i].Cells[0].Value.ToString() == numberCard)
                {
                    score = db.dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Add add = new Add(score, numberCard);
            add.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string moneyDOL = "";
            string moneyRUB = "";
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

            db.textBox1.Text += "Напечатана выписка \r\nкарта: " + numberCard + " возвращена владельцу \r\nвремя: " + DateTime.Now.ToString() + "\r\n";
            Check ch = new Check();
            for (int i = 0; i < db.dataGridView2.RowCount - 1; i++)
            {
                if (db.dataGridView2.Rows[i].Cells[0].Value.ToString() == score)
                {
                    moneyDOL = db.dataGridView2.Rows[i].Cells[2].Value.ToString();
                    moneyRUB = db.dataGridView2.Rows[i].Cells[1].Value.ToString();
                }
            }
            ch.textBox1.Text = "Номер карты: " + numberCard + "\r\nНа вашем счету:" + "\r\n" + moneyRUB + " рублей" + "\r\n" + moneyDOL + " долларов" + "\r\n \r\n OOO СБЕРНАСТЯ";
            ch.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            withdraw wd = new withdraw(score, numberCard);
            wd.ShowDialog();
        }
    }
}
