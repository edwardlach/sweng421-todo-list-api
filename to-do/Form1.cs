using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using to_do.DTOs;
using to_do.State;
using to_do.State.@abstract;
namespace to_do
{
    public partial class Form1 : Form
    {
        Store store;

        public Form1(Store store)
        {
            this.store = store;

            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Task");
            listView1.Columns.Add("Priority");
            listView1.Columns.Add("Due Date");
            listView1.Columns.Add("Status");
            this.UpdateList(this.store.ToDoTaskState.SelectAll());
            
            //observer pattern
            new Observer<ToDoTaskDTO.ToDoTaskSummaryResponse, List<ToDoTaskDTO.ToDoTaskSummaryResponse>>(
                (tasks) =>
                {
                    this.UpdateList(tasks);

                    return tasks;
                })
                .Subscribe(this.store.ToDoTaskState, this.store.ToDoTaskState.SelectAll);

        }

        private void UpdateList(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            //int rowNum = 0;
            tasks.ForEach(task => {
                string[] row = { task.Title, task.Priority, task.DueDate.ToString(), task.Status };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            });

    

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Note_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
