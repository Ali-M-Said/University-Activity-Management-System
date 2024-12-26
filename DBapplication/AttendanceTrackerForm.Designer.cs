using System.Windows.Forms;

namespace DBapplication
{
    partial class FeedbackAndAttendanceTrackerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ComboBox cbEventFilter;
        private DateTimePicker dpFromDate;
        private DateTimePicker dpToDate;
        private Button btnFilter;
        private DataGridView dgvEventDetails;
        private Button btnExport;
        private Button btnViewDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbEventFilter = new System.Windows.Forms.ComboBox();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvEventDetails = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Attendance Tracker";
            // 
            // cbEventFilter
            // 
            this.cbEventFilter.FormattingEnabled = true;
            this.cbEventFilter.Location = new System.Drawing.Point(20, 60);
            this.cbEventFilter.Name = "cbEventFilter";
            this.cbEventFilter.Size = new System.Drawing.Size(200, 24);
            this.cbEventFilter.TabIndex = 1;
            // 
            // dpFromDate
            // 
            this.dpFromDate.Location = new System.Drawing.Point(240, 60);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(200, 22);
            this.dpFromDate.TabIndex = 2;
            // 
            // dpToDate
            // 
            this.dpToDate.Location = new System.Drawing.Point(460, 60);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.Size = new System.Drawing.Size(200, 22);
            this.dpToDate.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(680, 60);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dgvEventDetails
            // 
            this.dgvEventDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventDetails.Location = new System.Drawing.Point(20, 100);
            this.dgvEventDetails.Name = "dgvEventDetails";
            this.dgvEventDetails.RowHeadersWidth = 51;
            this.dgvEventDetails.Size = new System.Drawing.Size(760, 300);
            this.dgvEventDetails.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(600, 420);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 30);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export to Excel/PDF";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(20, 420);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(180, 30);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // FeedbackAndAttendanceTrackerForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvEventDetails);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dpToDate);
            this.Controls.Add(this.dpFromDate);
            this.Controls.Add(this.cbEventFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "FeedbackAndAttendanceTrackerForm";
            this.Text = "Feedback and Attendance Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
