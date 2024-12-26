using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ReservationHistoryForm : Form
    {
       

        private void InitializeComponent()
        {
            this.lblReservationHistory = new System.Windows.Forms.Label();
            this.dgvReservationHistory = new System.Windows.Forms.DataGridView();
            this.ColLocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilterByDate = new System.Windows.Forms.Button();
            this.btnFilterByLocation = new System.Windows.Forms.Button();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservationHistory
            // 
            this.lblReservationHistory.AutoSize = true;
            this.lblReservationHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationHistory.Location = new System.Drawing.Point(20, 20);
            this.lblReservationHistory.Name = "lblReservationHistory";
            this.lblReservationHistory.Size = new System.Drawing.Size(176, 24);
            this.lblReservationHistory.TabIndex = 0;
            this.lblReservationHistory.Text = "Reservation History";
            // 
            // dgvReservationHistory
            // 
            this.dgvReservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLocName,
            this.ColStartTime,
            this.ColEndTime,
            this.ColReservationDate});
            this.dgvReservationHistory.Location = new System.Drawing.Point(20, 60);
            this.dgvReservationHistory.Name = "dgvReservationHistory";
            this.dgvReservationHistory.Size = new System.Drawing.Size(540, 200);
            this.dgvReservationHistory.TabIndex = 1;
            // 
            // ColLocName
            // 
            this.ColLocName.HeaderText = "Location Name";
            this.ColLocName.Name = "ColLocName";
            this.ColLocName.Width = 150;
            // 
            // ColStartTime
            // 
            this.ColStartTime.HeaderText = "Start Time";
            this.ColStartTime.Name = "ColStartTime";
            this.ColStartTime.Width = 100;
            // 
            // ColEndTime
            // 
            this.ColEndTime.HeaderText = "End Time";
            this.ColEndTime.Name = "ColEndTime";
            this.ColEndTime.Width = 100;
            // 
            // ColReservationDate
            // 
            this.ColReservationDate.HeaderText = "Reservation Date";
            this.ColReservationDate.Name = "ColReservationDate";
            this.ColReservationDate.Width = 150;
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.Location = new System.Drawing.Point(20, 280);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(200, 30);
            this.btnFilterByDate.TabIndex = 2;
            this.btnFilterByDate.Text = "Filter by Date";
            this.btnFilterByDate.UseVisualStyleBackColor = true;
            // 
            // btnFilterByLocation
            // 
            this.btnFilterByLocation.Location = new System.Drawing.Point(280, 280);
            this.btnFilterByLocation.Name = "btnFilterByLocation";
            this.btnFilterByLocation.Size = new System.Drawing.Size(200, 30);
            this.btnFilterByLocation.TabIndex = 3;
            this.btnFilterByLocation.Text = "Filter by Location";
            this.btnFilterByLocation.UseVisualStyleBackColor = true;
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(20, 320);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFilterDate.TabIndex = 4;
            // 
            // cmbFilterLocation
            // 
            this.cmbFilterLocation.FormattingEnabled = true;
            this.cmbFilterLocation.Location = new System.Drawing.Point(280, 320);
            this.cmbFilterLocation.Name = "cmbFilterLocation";
            this.cmbFilterLocation.Size = new System.Drawing.Size(200, 24);
            this.cmbFilterLocation.TabIndex = 5;
            // 
            // ReservationHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.cmbFilterLocation);
            this.Controls.Add(this.dtpFilterDate);
            this.Controls.Add(this.btnFilterByLocation);
            this.Controls.Add(this.btnFilterByDate);
            this.Controls.Add(this.dgvReservationHistory);
            this.Controls.Add(this.lblReservationHistory);
            this.Name = "ReservationHistoryForm";
            this.Text = "Reservation History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declare controls as private members
        private Label lblReservationHistory;
        private DataGridView dgvReservationHistory;
        private DataGridViewTextBoxColumn ColLocName;
        private DataGridViewTextBoxColumn ColStartTime;
        private DataGridViewTextBoxColumn ColEndTime;
        private DataGridViewTextBoxColumn ColReservationDate;
        private Button btnFilterByDate;
        private Button btnFilterByLocation;
        private DateTimePicker dtpFilterDate;
        private ComboBox cmbFilterLocation;
    }
}
