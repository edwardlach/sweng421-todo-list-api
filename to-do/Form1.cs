using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Task");
            listView1.Columns.Add("Priority");
            listView1.Columns.Add("Due Date");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            {
                string[] row = { "Get the Groceries", "High", "Today" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);

                string[] row2 = { "Pickup Timmy from Baseball", "Low", "Today" };
                var listViewItem2 = new ListViewItem(row2);
                listView1.Items.Add(listViewItem2);

                string[] row3 = { "Put Elf on Shelf", "Medium", "Today" };
                var listViewItem3 = new ListViewItem(row3);
                listView1.Items.Add(listViewItem3);
                listView1.Items[1].BackColor = Color.Red;
                listView1.Items[1].ForeColor = Color.White;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
