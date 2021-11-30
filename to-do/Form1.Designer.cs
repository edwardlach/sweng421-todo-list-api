﻿
namespace to_do
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.moveItemUp = new System.Windows.Forms.Button();
            this.moveItemDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "To-Do List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sort By:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Priority",
            "Type",
            "Alphabetical",
            "Date Due",
            "Date Created"});
            this.sortByComboBox.Location = new System.Drawing.Point(75, 694);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 4;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(315, 158);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(104, 23);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Add New Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(442, 158);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(104, 23);
            this.editItemButton.TabIndex = 6;
            this.editItemButton.Text = "Edit Selected Item";
            this.editItemButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 204);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(516, 471);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // moveItemUp
            // 
            this.moveItemUp.Location = new System.Drawing.Point(577, 229);
            this.moveItemUp.Name = "moveItemUp";
            this.moveItemUp.Size = new System.Drawing.Size(104, 23);
            this.moveItemUp.TabIndex = 9;
            this.moveItemUp.Text = "Move Item Up";
            this.moveItemUp.UseVisualStyleBackColor = true;
            // 
            // moveItemDown
            // 
            this.moveItemDown.Location = new System.Drawing.Point(577, 276);
            this.moveItemDown.Name = "moveItemDown";
            this.moveItemDown.Size = new System.Drawing.Size(104, 23);
            this.moveItemDown.TabIndex = 10;
            this.moveItemDown.Text = "Move Item Down";
            this.moveItemDown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 827);
            this.Controls.Add(this.moveItemDown);
            this.Controls.Add(this.moveItemUp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button moveItemUp;
        private System.Windows.Forms.Button moveItemDown;
    }
}

