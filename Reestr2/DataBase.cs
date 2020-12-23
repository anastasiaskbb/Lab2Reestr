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
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("221100", "0414", "165");
            this.dataGridView2.Rows.Add("165", "100000", "756");
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool unique = true;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox2.Text)
                {
                    unique = false;
                }
            }

            if (unique)
            {
                var rand = new Random();
                String randomNum = rand.Next(100, 1000).ToString();
                dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, randomNum);
                dataGridView2.Rows.Add(randomNum, "0", "0");
                return;
            }
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
