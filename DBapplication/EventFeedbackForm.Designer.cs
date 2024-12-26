using System.Windows.Forms;

namespace DBapplication
{
    partial class EventFeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ComboBox cbEventFilter;
        private Button btnFilter;
        private DataGridView dgvFeedback;
        private Button btnExportFeedback;
        private Button btnViewResponse;
        private TextBox txtResponse;
        private Label lblResponse;

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
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnExportFeedback = new System.Windows.Forms.Button();
            this.btnViewResponse = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Event Feedback Form";
            // 
            // cbEventFilter
            // 
            this.cbEventFilter.FormattingEnabled = true;
            this.cbEventFilter.Location = new System.Drawing.Point(20, 60);
            this.cbEventFilter.Name = "cbEventFilter";
            this.cbEventFilter.Size = new System.Drawing.Size(200, 21);
            this.cbEventFilter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(240, 60);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(20, 100);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.Size = new System.Drawing.Size(760, 300);
            this.dgvFeedback.TabIndex = 3;
            // 
            // btnExportFeedback
            // 
            this.btnExportFeedback.Location = new System.Drawing.Point(600, 420);
            this.btnExportFeedback.Name = "btnExportFeedback";
            this.btnExportFeedback.Size = new System.Drawing.Size(180, 30);
            this.btnExportFeedback.TabIndex = 4;
            this.btnExportFeedback.Text = "Export Feedback";
            this.btnExportFeedback.UseVisualStyleBackColor = true;
            // 
            // btnViewResponse
            // 
            this.btnViewResponse.Location = new System.Drawing.Point(20, 420);
            this.btnViewResponse.Name = "btnViewResponse";
            this.btnViewResponse.Size = new System.Drawing.Size(180, 30);
            this.btnViewResponse.TabIndex = 5;
            this.btnViewResponse.Text = "View Response";
            this.btnViewResponse.UseVisualStyleBackColor = true;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(20, 470);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(65, 13);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "Response:";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(100, 470);
            this.txtResponse.Multiline = true;
            this.txtResponse.Size = new System.Drawing.Size(680, 60);
            this.txtResponse.TabIndex = 7;
            // 
            // EventFeedbackForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnViewResponse);
            this.Controls.Add(this.btnExportFeedback);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbEventFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "EventFeedbackForm";
            this.Text = "Event Feedback Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
