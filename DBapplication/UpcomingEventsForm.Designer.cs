using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class UpcomingEventsForm : Form
    {
       

        private void InitializeComponent()
        {
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.grpUpcomingEvents = new System.Windows.Forms.GroupBox();
            this.dgvUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegister = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpUpcomingEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 20);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(178, 24);
            this.lblUpcomingEvents.TabIndex = 0;
            this.lblUpcomingEvents.Text = "Upcoming Events";
            // 
            // grpUpcomingEvents
            // 
            this.grpUpcomingEvents.Controls.Add(this.dgvUpcomingEvents);
            this.grpUpcomingEvents.Controls.Add(this.btnRegister);
            this.grpUpcomingEvents.Location = new System.Drawing.Point(20, 60);
            this.grpUpcomingEvents.Name = "grpUpcomingEvents";
            this.grpUpcomingEvents.Size = new System.Drawing.Size(600, 300);
            this.grpUpcomingEvents.TabIndex = 1;
            this.grpUpcomingEvents.TabStop = false;
            this.grpUpcomingEvents.Text = "Event List";
            // 
            // dgvUpcomingEvents
            // 
            this.dgvUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colDescription,
            this.colStartDate,
            this.colEndDate,
            this.colCategory,
            this.colLocationName,
            this.colRegister});
            this.dgvUpcomingEvents.Location = new System.Drawing.Point(20, 30);
            this.dgvUpcomingEvents.Name = "dgvUpcomingEvents";
            this.dgvUpcomingEvents.Size = new System.Drawing.Size(550, 200);
            this.dgvUpcomingEvents.TabIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.Name = "colEndDate";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // colLocationName
            // 
            this.colLocationName.HeaderText = "Location Name";
            this.colLocationName.Name = "colLocationName";
            // 
            // colRegister
            // 
            this.colRegister.HeaderText = "Register";
            this.colRegister.Name = "colRegister";
            this.colRegister.Text = "Register";
            this.colRegister.UseColumnTextForButtonValue = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(20, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register for Event";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // UpcomingEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.grpUpcomingEvents);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Name = "UpcomingEventsForm";
            this.Text = "Upcoming Events";
            this.grpUpcomingEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declare controls as private members
        private Label lblUpcomingEvents;
        private GroupBox grpUpcomingEvents;
        private DataGridView dgvUpcomingEvents;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colLocationName;
        private DataGridViewButtonColumn colRegister;
        private Button btnRegister;
    }
}
