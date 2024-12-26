using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AvailableSpaces : Form
    {
  

        private void InitializeComponent()
        {
            this.lblAvailableSpaces = new System.Windows.Forms.Label();
            this.dgvAvailableSpaces = new System.Windows.Forms.DataGridView();
            this.ColLocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReserveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReserveSpace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableSpaces
            // 
            this.lblAvailableSpaces.AutoSize = true;
            this.lblAvailableSpaces.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableSpaces.Location = new System.Drawing.Point(20, 20);
            this.lblAvailableSpaces.Name = "lblAvailableSpaces";
            this.lblAvailableSpaces.Size = new System.Drawing.Size(145, 19);
            this.lblAvailableSpaces.TabIndex = 0;
            this.lblAvailableSpaces.Text = "Available Spaces:";
            // 
            // dgvAvailableSpaces
            // 
            this.dgvAvailableSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableSpaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLocName,
            this.ColCapacity,
            this.ColLocType,
            this.ColStartTime,
            this.ColEndTime,
            this.ColReserveButton});
            this.dgvAvailableSpaces.Location = new System.Drawing.Point(20, 50);
            this.dgvAvailableSpaces.Name = "dgvAvailableSpaces";
            this.dgvAvailableSpaces.RowHeadersWidth = 51;
            this.dgvAvailableSpaces.Size = new System.Drawing.Size(600, 250);
            this.dgvAvailableSpaces.TabIndex = 1;
            // 
            // ColLocName
            // 
            this.ColLocName.HeaderText = "Location Name";
            this.ColLocName.MinimumWidth = 6;
            this.ColLocName.Name = "ColLocName";
            this.ColLocName.Width = 125;
            // 
            // ColCapacity
            // 
            this.ColCapacity.HeaderText = "Capacity";
            this.ColCapacity.MinimumWidth = 6;
            this.ColCapacity.Name = "ColCapacity";
            this.ColCapacity.Width = 125;
            // 
            // ColLocType
            // 
            this.ColLocType.HeaderText = "Location Type";
            this.ColLocType.MinimumWidth = 6;
            this.ColLocType.Name = "ColLocType";
            this.ColLocType.Width = 125;
            // 
            // ColStartTime
            // 
            this.ColStartTime.HeaderText = "Start Time";
            this.ColStartTime.MinimumWidth = 6;
            this.ColStartTime.Name = "ColStartTime";
            this.ColStartTime.Width = 125;
            // 
            // ColEndTime
            // 
            this.ColEndTime.HeaderText = "End Time";
            this.ColEndTime.MinimumWidth = 6;
            this.ColEndTime.Name = "ColEndTime";
            this.ColEndTime.Width = 125;
            // 
            // ColReserveButton
            // 
            this.ColReserveButton.HeaderText = "Reserve";
            this.ColReserveButton.MinimumWidth = 6;
            this.ColReserveButton.Name = "ColReserveButton";
            this.ColReserveButton.Text = "Reserve";
            this.ColReserveButton.UseColumnTextForButtonValue = true;
            this.ColReserveButton.Width = 75;
            // 
            // btnReserveSpace
            // 
            this.btnReserveSpace.Location = new System.Drawing.Point(20, 320);
            this.btnReserveSpace.Name = "btnReserveSpace";
            this.btnReserveSpace.Size = new System.Drawing.Size(600, 30);
            this.btnReserveSpace.TabIndex = 2;
            this.btnReserveSpace.Text = "Reserve Selected Space";
            this.btnReserveSpace.UseVisualStyleBackColor = true;
            // 
            // AvailableSpaces
            // 
            this.ClientSize = new System.Drawing.Size(650, 370);
            this.Controls.Add(this.btnReserveSpace);
            this.Controls.Add(this.dgvAvailableSpaces);
            this.Controls.Add(this.lblAvailableSpaces);
            this.Name = "AvailableSpaces";
            this.Text = "Available Spaces";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblAvailableSpaces;
        private DataGridView dgvAvailableSpaces;
        private DataGridViewTextBoxColumn ColLocName;
        private DataGridViewTextBoxColumn ColCapacity;
        private DataGridViewTextBoxColumn ColLocType;
        private DataGridViewTextBoxColumn ColStartTime;
        private DataGridViewTextBoxColumn ColEndTime;
        private DataGridViewButtonColumn ColReserveButton;
        private Button btnReserveSpace;
    }
}
