
namespace Phumla_Kamnandi_30.Presentation
{
    partial class CreateBookingForm
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
            this.gbxBooking = new System.Windows.Forms.GroupBox();
            this.numRoomsCombo = new System.Windows.Forms.ComboBox();
            this.checkOutPicker = new System.Windows.Forms.DateTimePicker();
            this.checkInPicker = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitBooking = new System.Windows.Forms.Button();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.radMed = new System.Windows.Forms.RadioButton();
            this.radLow = new System.Windows.Forms.RadioButton();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblNumRooms = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.gbxBooking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBooking
            // 
            this.gbxBooking.Controls.Add(this.exitButton);
            this.gbxBooking.Controls.Add(this.numRoomsCombo);
            this.gbxBooking.Controls.Add(this.checkOutPicker);
            this.gbxBooking.Controls.Add(this.checkInPicker);
            this.gbxBooking.Controls.Add(this.btnCancel);
            this.gbxBooking.Controls.Add(this.btnSubmitBooking);
            this.gbxBooking.Controls.Add(this.radHigh);
            this.gbxBooking.Controls.Add(this.radMed);
            this.gbxBooking.Controls.Add(this.radLow);
            this.gbxBooking.Controls.Add(this.lblRate);
            this.gbxBooking.Controls.Add(this.lblNumRooms);
            this.gbxBooking.Controls.Add(this.lblCheckOut);
            this.gbxBooking.Controls.Add(this.lblCheckIn);
            this.gbxBooking.Location = new System.Drawing.Point(25, 37);
            this.gbxBooking.Name = "gbxBooking";
            this.gbxBooking.Size = new System.Drawing.Size(427, 191);
            this.gbxBooking.TabIndex = 3;
            this.gbxBooking.TabStop = false;
            this.gbxBooking.Text = "Booking Details";
            this.gbxBooking.Enter += new System.EventHandler(this.gbxBooking_Enter);
            // 
            // numRoomsCombo
            // 
            this.numRoomsCombo.FormattingEnabled = true;
            this.numRoomsCombo.Location = new System.Drawing.Point(122, 104);
            this.numRoomsCombo.Name = "numRoomsCombo";
            this.numRoomsCombo.Size = new System.Drawing.Size(121, 21);
            this.numRoomsCombo.TabIndex = 17;
            this.numRoomsCombo.SelectedIndexChanged += new System.EventHandler(this.numRoomsCombo_SelectedIndexChanged);
            // 
            // checkOutPicker
            // 
            this.checkOutPicker.Location = new System.Drawing.Point(122, 73);
            this.checkOutPicker.Name = "checkOutPicker";
            this.checkOutPicker.Size = new System.Drawing.Size(200, 20);
            this.checkOutPicker.TabIndex = 15;
            this.checkOutPicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // checkInPicker
            // 
            this.checkInPicker.Location = new System.Drawing.Point(122, 38);
            this.checkInPicker.Name = "checkInPicker";
            this.checkInPicker.Size = new System.Drawing.Size(200, 20);
            this.checkInPicker.TabIndex = 5;
            this.checkInPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitBooking
            // 
            this.btnSubmitBooking.Location = new System.Drawing.Point(346, 85);
            this.btnSubmitBooking.Name = "btnSubmitBooking";
            this.btnSubmitBooking.Size = new System.Drawing.Size(75, 40);
            this.btnSubmitBooking.TabIndex = 7;
            this.btnSubmitBooking.Text = "Submit Booking";
            this.btnSubmitBooking.UseVisualStyleBackColor = true;
            this.btnSubmitBooking.Click += new System.EventHandler(this.btnSubmitBooking_Click);
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Location = new System.Drawing.Point(263, 139);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(47, 17);
            this.radHigh.TabIndex = 13;
            this.radHigh.TabStop = true;
            this.radHigh.Text = "High";
            this.radHigh.UseVisualStyleBackColor = true;
            this.radHigh.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // radMed
            // 
            this.radMed.AutoSize = true;
            this.radMed.Location = new System.Drawing.Point(195, 139);
            this.radMed.Name = "radMed";
            this.radMed.Size = new System.Drawing.Size(62, 17);
            this.radMed.TabIndex = 12;
            this.radMed.TabStop = true;
            this.radMed.Text = "Medium";
            this.radMed.UseVisualStyleBackColor = true;
            this.radMed.CheckedChanged += new System.EventHandler(this.radMed_CheckedChanged);
            // 
            // radLow
            // 
            this.radLow.AutoSize = true;
            this.radLow.Location = new System.Drawing.Point(144, 139);
            this.radLow.Name = "radLow";
            this.radLow.Size = new System.Drawing.Size(45, 17);
            this.radLow.TabIndex = 11;
            this.radLow.TabStop = true;
            this.radLow.Text = "Low";
            this.radLow.UseVisualStyleBackColor = true;
            this.radLow.CheckedChanged += new System.EventHandler(this.radLow_CheckedChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(16, 141);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(75, 13);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Rate (Season)";
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.AutoSize = true;
            this.lblNumRooms.Location = new System.Drawing.Point(16, 107);
            this.lblNumRooms.Name = "lblNumRooms";
            this.lblNumRooms.Size = new System.Drawing.Size(92, 13);
            this.lblNumRooms.TabIndex = 9;
            this.lblNumRooms.Text = "Number of Rooms";
            this.lblNumRooms.Click += new System.EventHandler(this.lblNumRooms_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(16, 73);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(84, 13);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check-Out Date";
            this.lblCheckOut.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(16, 38);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(76, 13);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "Check-In Date";
            this.lblCheckIn.Click += new System.EventHandler(this.lblCheckIn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(346, 168);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 481);
            this.Controls.Add(this.gbxBooking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateBookingForm";
            this.Text = "Create Booking";
            this.Load += new System.EventHandler(this.CreateBookingForm_Load);
            this.gbxBooking.ResumeLayout(false);
            this.gbxBooking.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxBooking;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblNumRooms;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Button btnSubmitBooking;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.RadioButton radMed;
        private System.Windows.Forms.RadioButton radLow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker checkOutPicker;
        private System.Windows.Forms.DateTimePicker checkInPicker;
        private System.Windows.Forms.ComboBox numRoomsCombo;
        private System.Windows.Forms.Button exitButton;
    }
}