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
using to_do.Services;
using to_do.State.Filter.Task;
using to_do.Decorators;

namespace to_do
{
    public partial class Form1 : Form
    {
        Store store;
        IToDoTaskService taskService;
        ToDoTaskDTO.ToDoTaskSummaryResponse currentSelectedItem;
        ITaskFilter filter;
        public int changeCount = 0;
        TaskComponent taskPrototype;


        public Form1(Store store, IToDoTaskService taskService)
        {
            this.store = store;
            this.taskService = taskService;
            this.filter = new TaskNoFilter();
            this.taskPrototype = new TaskComponent(new ToDoTaskDTO.ToDoTaskSummaryResponse());

            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Task");
            listView1.Columns.Add("Priority");
            listView1.Columns.Add("Due Date");
            listView1.Columns.Add("Status");
            this.UpdateList(this.store.ToDoTaskState.SelectAll());
            this.UpdateChanges(this.store.ChangeState.SelectAll());

            //observer pattern
            new Observer<ToDoTaskDTO.ToDoTaskSummaryResponse, List<ToDoTaskDTO.ToDoTaskSummaryResponse>>(
                (tasks) =>
                {
                    this.UpdateList(tasks);
                    return tasks;
                })
                .Subscribe(this.store.ToDoTaskState, this.store.ToDoTaskState.SelectAll);

            //observer pattern
            new Observer<ChangeDTO.ChangeResponse, List<ChangeDTO.ChangeResponse>>(
                (changes) =>
                {
                    this.UpdateChanges(changes);
                    return changes;
                })
                .Subscribe(this.store.ChangeState, this.store.ChangeState.SelectAll);

        }

        private void UpdateChanges(List<ChangeDTO.ChangeResponse> changes)
        {
                changes.ForEach(change =>
                Console.WriteLine("-----> " + change.ChangingUser.FirstName + " " + change.Value + " Task: " + change.Task.Title));
        }
        private void UpdateList(List<ToDoTaskDTO.ToDoTaskSummaryResponse> tasks)
        {
            
            listView1.Items.Clear();
            tasks = filter.filter(tasks);

            

            //int rowNum = 0;
           tasks.ForEach(task => {
               TaskComponent taskComponent = (TaskComponent)taskPrototype.Clone();
               taskComponent.SetTask(task);
               ITaskComponent styled = taskComponent;
               if (task.Priority.Equals("HIGH"))
               {
                   styled = new TaskHighPriorityDecorator(taskComponent);
               }
               else if (task.DueDate < DateTime.Now)
               {
                   styled = new TaskPastDueDecorator(taskComponent);
               }
               
                listView1.Items.Add(styled.ToListViewItem());
            });

            


        }
        private async void addItemButton_Click(object sender, EventArgs e)
        {
            {
                ToDoTaskDTO.ToDoTaskCreateRequest request = new ToDoTaskDTO.ToDoTaskCreateRequest();
                request.Title = textBox1.Text;
                request.Description = textBox1.Text;
                request.DueDate = dateTimePicker1.Value;
                request.Priority = comboBox2.Text;
                request.Status = comboBox3.Text;

                request.ListId = store.ToDoListState.SelectActive().Id;
                request.UserId = store.UserState.SelectActive().Id;

                ToDoTaskDTO.ToDoTaskResponse taskResponse = await taskService.Create(request);
                ToDoTaskDTO.ToDoTaskSummaryResponse toDoTaskSummaryResponse = new ToDoTaskDTO.ToDoTaskSummaryResponse(taskResponse);
                this.store.ToDoTaskState.AddTo(toDoTaskSummaryResponse);
            }
        }
        private async void editItemButton_Click(object sender, EventArgs e)
        {

            ToDoTaskDTO.ToDoTaskUpdateRequest updateRequest = new ToDoTaskDTO.ToDoTaskUpdateRequest();

            updateRequest.Title = textBox1.Text;
            updateRequest.Description = textBox1.Text;
            updateRequest.DueDate = dateTimePicker1.Value;
            updateRequest.Priority = comboBox2.Text;
            updateRequest.Status = comboBox3.Text;
            updateRequest.UserId = this.store.UserState.SelectActive().Id;

            ToDoTaskDTO.ToDoTaskResponse taskResponse = await taskService.Update(updateRequest, currentSelectedItem.Id);
            ToDoTaskDTO.ToDoTaskSummaryResponse toDoTaskSummaryResponse = new ToDoTaskDTO.ToDoTaskSummaryResponse(taskResponse);
            this.store.ToDoTaskState.Update(toDoTaskSummaryResponse);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedItem = (ToDoTaskDTO.ToDoTaskSummaryResponse)listView1.SelectedItems[0].Tag;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Past Due":
                    filter = new TaskPastDueFilter();
                    break;
                case "Due Soon":
                    filter = new TaskDueSoonFilter();   
                    break;
                case "HIGH":
                case "MEDIUM":
                case "LOW":
                    filter = new TaskPriorityFilter(comboBox1.Text);
                    break;
                case "BLOCKED":
                case "IN_PROGRESS":
                case "COMPLETE":
                case "ON_DECK":
                    filter = new TaskStatusFilter(comboBox1.Text);
                    break;
                default:
                    filter = new TaskNoFilter();
                    break;

            }

            this.UpdateList(this.store.ToDoTaskState.SelectAll());
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



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Note_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
