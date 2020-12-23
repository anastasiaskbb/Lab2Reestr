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
    public partial class Form1 : Form
    {

        DataBase db = (DataBase)Application.OpenForms["DataBase"];
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            textBox2.Text=db.dataGridView1.Rows[rand.Next(0, db.dataGridView1.RowCount-1)].Cells[0].Value.ToString();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(checkCard())
            {
                services sc = new services(textBox2.Text);
                sc.Show();
                this.Close();
            }
            else
            {
                label3.Visible = true;

            }
        }

        private bool checkCard()
        {

            for (int i = 0; i < db.dataGridView1.RowCount - 1; i++)
            {
                if (db.dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox2.Text)
                {
                    if (db.dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox1.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
