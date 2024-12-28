using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ManagerialReportsForm : Form
    {
        private Label lblManagerialReports;
        private Button btnGenerateReport;

        private void InitializeComponent()
        {
            this.lblManagerialReports = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagerialReports
            // 
            this.lblManagerialReports.AutoSize = true;
            this.lblManagerialReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblManagerialReports.Location = new System.Drawing.Point(20, 20);
            this.lblManagerialReports.Name = "lblManagerialReports";
            this.lblManagerialReports.Size = new System.Drawing.Size(194, 24);
            this.lblManagerialReports.TabIndex = 0;
            this.lblManagerialReports.Text = "Managerial Reports";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 60);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(177, 62);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Managerial Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // ManagerialReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lblManagerialReports);
            this.Name = "ManagerialReportsForm";
            this.Text = "Managerial Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
