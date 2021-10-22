
namespace Phumla_Kamnandi_30.Presentation
{
    partial class RoomAvailabilityForm
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
            this.roomAvailabiltyListView = new System.Windows.Forms.ListView();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDateRmAvail = new System.Windows.Forms.TextBox();
            this.btnSubmitRmAvail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomAvailabiltyListView
            // 
            this.roomAvailabiltyListView.HideSelection = false;
            this.roomAvailabiltyListView.Location = new System.Drawing.Point(39, 100);
            this.roomAvailabiltyListView.Name = "roomAvailabiltyListView";
            this.roomAvailabiltyListView.Size = new System.Drawing.Size(707, 254);
            this.roomAvailabiltyListView.TabIndex = 2;
            this.roomAvailabiltyListView.UseCompatibleStateImageBehavior = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(386, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // txtDateRmAvail
            // 
            this.txtDateRmAvail.Location = new System.Drawing.Point(444, 58);
            this.txtDateRmAvail.Name = "txtDateRmAvail";
            this.txtDateRmAvail.Size = new System.Drawing.Size(184, 20);
            this.txtDateRmAvail.TabIndex = 4;
            // 
            // btnSubmitRmAvail
            // 
            this.btnSubmitRmAvail.Location = new System.Drawing.Point(671, 56);
            this.btnSubmitRmAvail.Name = "btnSubmitRmAvail";
            this.btnSubmitRmAvail.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRmAvail.TabIndex = 5;
            this.btnSubmitRmAvail.Text = "Submit";
            this.btnSubmitRmAvail.UseVisualStyleBackColor = true;
            // 
            // RoomAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitRmAvail);
            this.Controls.Add(this.txtDateRmAvail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.roomAvailabiltyListView);
            this.Name = "RoomAvailabilityForm";
            this.Text = "RoomAvailabilityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView roomAvailabiltyListView;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDateRmAvail;
        private System.Windows.Forms.Button btnSubmitRmAvail;
    }
}