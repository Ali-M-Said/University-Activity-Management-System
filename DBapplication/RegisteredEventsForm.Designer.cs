using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class RegisteredEventsForm : Form
    {
        

        private void InitializeComponent()
        {
            this.lblRegisteredEvents = new System.Windows.Forms.Label();
            this.grpRegisteredEvents = new System.Windows.Forms.GroupBox();
            this.dgvRegisteredEvents = new System.Windows.Forms.DataGridView();
            this.grpRegisteredEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisteredEvents
            // 
            this.lblRegisteredEvents.AutoSize = true;
            this.lblRegisteredEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRegisteredEvents.Location = new System.Drawing.Point(20, 20);
            this.lblRegisteredEvents.Name = "lblRegisteredEvents";
            this.lblRegisteredEvents.Size = new System.Drawing.Size(181, 24);
            this.lblRegisteredEvents.TabIndex = 0;
            this.lblRegisteredEvents.Text = "Registered Events";
            // 
            // grpRegisteredEvents
            // 
            this.grpRegisteredEvents.Controls.Add(this.dgvRegisteredEvents);
            this.grpRegisteredEvents.Location = new System.Drawing.Point(20, 60);
            this.grpRegisteredEvents.Name = "grpRegisteredEvents";
            this.grpRegisteredEvents.Size = new System.Drawing.Size(600, 300);
            this.grpRegisteredEvents.TabIndex = 1;
            this.grpRegisteredEvents.TabStop = false;
            this.grpRegisteredEvents.Text = "Event List";
            // 
            // dgvRegisteredEvents
            // 
            this.dgvRegisteredEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredEvents.Location = new System.Drawing.Point(20, 30);
            this.dgvRegisteredEvents.Name = "dgvRegisteredEvents";
            this.dgvRegisteredEvents.RowHeadersWidth = 51;
            this.dgvRegisteredEvents.Size = new System.Drawing.Size(550, 200);
            this.dgvRegisteredEvents.TabIndex = 0;
            // 
            // RegisteredEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.grpRegisteredEvents);
            this.Controls.Add(this.lblRegisteredEvents);
            this.Name = "RegisteredEventsForm";
            this.Text = "Registered Events";
            this.grpRegisteredEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblRegisteredEvents;
        private GroupBox grpRegisteredEvents;
        private DataGridView dgvRegisteredEvents;
    }
}
