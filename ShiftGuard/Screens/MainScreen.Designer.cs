namespace ShiftGuard
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskTimerCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timesheet_lbl = new System.Windows.Forms.Label();
            this.create_timer_lbl = new System.Windows.Forms.Label();
            this.toggle_shift_lbl = new System.Windows.Forms.Label();
            this.ServerDateLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emptyMonitorsLbl = new System.Windows.Forms.Label();
            this.ServerTimeLbl = new System.Windows.Forms.Label();
            this.toggleTaskTimerCountBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewTimerBtn = new System.Windows.Forms.Button();
            this.TimeSheetBtn = new System.Windows.Forms.Button();
            this.ShiftSwitchButton = new System.Windows.Forms.Button();
            this.totalShiftTimeLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emptyActivitiyStackLbl = new System.Windows.Forms.Label();
            this.emptyActivitiyStackDescriptionLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.timerPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 524);
            this.panel1.TabIndex = 0;
            // 
            // timerPanel
            // 
            this.timerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerPanel.Controls.Add(this.totalShiftTimeLbl);
            this.timerPanel.Controls.Add(this.toggleTaskTimerCountBtn);
            this.timerPanel.Controls.Add(this.label1);
            this.timerPanel.Controls.Add(this.TaskTimerCount);
            this.timerPanel.Location = new System.Drawing.Point(4, 97);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(781, 75);
            this.timerPanel.TabIndex = 1;
            this.timerPanel.Click += new System.EventHandler(this.timerPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Elapsed";
            // 
            // TaskTimerCount
            // 
            this.TaskTimerCount.AutoSize = true;
            this.TaskTimerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTimerCount.ForeColor = System.Drawing.Color.Red;
            this.TaskTimerCount.Location = new System.Drawing.Point(3, 26);
            this.TaskTimerCount.Name = "TaskTimerCount";
            this.TaskTimerCount.Size = new System.Drawing.Size(172, 42);
            this.TaskTimerCount.TabIndex = 0;
            this.TaskTimerCount.Text = "00:00:00";
            this.TaskTimerCount.Click += new System.EventHandler(this.timer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ServerTimeLbl);
            this.panel2.Controls.Add(this.timesheet_lbl);
            this.panel2.Controls.Add(this.create_timer_lbl);
            this.panel2.Controls.Add(this.toggle_shift_lbl);
            this.panel2.Controls.Add(this.NewTimerBtn);
            this.panel2.Controls.Add(this.TimeSheetBtn);
            this.panel2.Controls.Add(this.ServerDateLbl);
            this.panel2.Controls.Add(this.ShiftSwitchButton);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 87);
            this.panel2.TabIndex = 0;
            // 
            // timesheet_lbl
            // 
            this.timesheet_lbl.AutoSize = true;
            this.timesheet_lbl.Location = new System.Drawing.Point(179, 66);
            this.timesheet_lbl.Name = "timesheet_lbl";
            this.timesheet_lbl.Size = new System.Drawing.Size(56, 13);
            this.timesheet_lbl.TabIndex = 6;
            this.timesheet_lbl.Text = "Timesheet";
            // 
            // create_timer_lbl
            // 
            this.create_timer_lbl.AutoSize = true;
            this.create_timer_lbl.Location = new System.Drawing.Point(103, 66);
            this.create_timer_lbl.Name = "create_timer_lbl";
            this.create_timer_lbl.Size = new System.Drawing.Size(58, 13);
            this.create_timer_lbl.TabIndex = 5;
            this.create_timer_lbl.Text = "New Timer";
            // 
            // toggle_shift_lbl
            // 
            this.toggle_shift_lbl.AutoSize = true;
            this.toggle_shift_lbl.Location = new System.Drawing.Point(26, 66);
            this.toggle_shift_lbl.Name = "toggle_shift_lbl";
            this.toggle_shift_lbl.Size = new System.Drawing.Size(53, 13);
            this.toggle_shift_lbl.TabIndex = 4;
            this.toggle_shift_lbl.Text = "Start Shift";
            // 
            // ServerDateLbl
            // 
            this.ServerDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerDateLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ServerDateLbl.Location = new System.Drawing.Point(427, 59);
            this.ServerDateLbl.Name = "ServerDateLbl";
            this.ServerDateLbl.Size = new System.Drawing.Size(343, 20);
            this.ServerDateLbl.TabIndex = 1;
            this.ServerDateLbl.Text = "srv_date";
            this.ServerDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.emptyMonitorsLbl);
            this.panel3.Location = new System.Drawing.Point(785, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 499);
            this.panel3.TabIndex = 1;
            // 
            // emptyMonitorsLbl
            // 
            this.emptyMonitorsLbl.AutoSize = true;
            this.emptyMonitorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyMonitorsLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emptyMonitorsLbl.Location = new System.Drawing.Point(24, 245);
            this.emptyMonitorsLbl.Name = "emptyMonitorsLbl";
            this.emptyMonitorsLbl.Size = new System.Drawing.Size(118, 16);
            this.emptyMonitorsLbl.TabIndex = 2;
            this.emptyMonitorsLbl.Text = "No active monitors";
            // 
            // ServerTimeLbl
            // 
            this.ServerTimeLbl.AutoSize = true;
            this.ServerTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerTimeLbl.Location = new System.Drawing.Point(633, 12);
            this.ServerTimeLbl.Name = "ServerTimeLbl";
            this.ServerTimeLbl.Size = new System.Drawing.Size(151, 38);
            this.ServerTimeLbl.TabIndex = 7;
            this.ServerTimeLbl.Text = "00:00:00";
            // 
            // toggleTaskTimerCountBtn
            // 
            this.toggleTaskTimerCountBtn.Enabled = false;
            this.toggleTaskTimerCountBtn.FlatAppearance.BorderSize = 0;
            this.toggleTaskTimerCountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleTaskTimerCountBtn.Image = global::ShiftGuard.Properties.Resources.start_timer;
            this.toggleTaskTimerCountBtn.Location = new System.Drawing.Point(715, 8);
            this.toggleTaskTimerCountBtn.Name = "toggleTaskTimerCountBtn";
            this.toggleTaskTimerCountBtn.Size = new System.Drawing.Size(55, 60);
            this.toggleTaskTimerCountBtn.TabIndex = 3;
            this.toggleTaskTimerCountBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ShiftGuard.Properties.Resources.clock;
            this.button2.Location = new System.Drawing.Point(583, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 60);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NewTimerBtn
            // 
            this.NewTimerBtn.FlatAppearance.BorderSize = 0;
            this.NewTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTimerBtn.Image = global::ShiftGuard.Properties.Resources.timer_new;
            this.NewTimerBtn.Location = new System.Drawing.Point(106, 3);
            this.NewTimerBtn.Name = "NewTimerBtn";
            this.NewTimerBtn.Size = new System.Drawing.Size(55, 60);
            this.NewTimerBtn.TabIndex = 3;
            this.NewTimerBtn.UseVisualStyleBackColor = true;
            // 
            // TimeSheetBtn
            // 
            this.TimeSheetBtn.FlatAppearance.BorderSize = 0;
            this.TimeSheetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeSheetBtn.Image = global::ShiftGuard.Properties.Resources.timesheet;
            this.TimeSheetBtn.Location = new System.Drawing.Point(180, 3);
            this.TimeSheetBtn.Name = "TimeSheetBtn";
            this.TimeSheetBtn.Size = new System.Drawing.Size(55, 60);
            this.TimeSheetBtn.TabIndex = 2;
            this.TimeSheetBtn.UseVisualStyleBackColor = true;
            this.TimeSheetBtn.Click += new System.EventHandler(this.TimeSheetBtn_Click);
            // 
            // ShiftSwitchButton
            // 
            this.ShiftSwitchButton.FlatAppearance.BorderSize = 0;
            this.ShiftSwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShiftSwitchButton.Image = global::ShiftGuard.Properties.Resources.shift_begin;
            this.ShiftSwitchButton.Location = new System.Drawing.Point(21, 3);
            this.ShiftSwitchButton.Name = "ShiftSwitchButton";
            this.ShiftSwitchButton.Size = new System.Drawing.Size(58, 60);
            this.ShiftSwitchButton.TabIndex = 0;
            this.ShiftSwitchButton.UseVisualStyleBackColor = true;
            this.ShiftSwitchButton.Click += new System.EventHandler(this.ShiftSwitchButton_Click);
            // 
            // totalShiftTimeLbl
            // 
            this.totalShiftTimeLbl.AutoSize = true;
            this.totalShiftTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShiftTimeLbl.Location = new System.Drawing.Point(339, 27);
            this.totalShiftTimeLbl.Name = "totalShiftTimeLbl";
            this.totalShiftTimeLbl.Size = new System.Drawing.Size(119, 20);
            this.totalShiftTimeLbl.TabIndex = 4;
            this.totalShiftTimeLbl.Text = "Total Shift Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emptyActivitiyStackDescriptionLbl);
            this.groupBox1.Controls.Add(this.emptyActivitiyStackLbl);
            this.groupBox1.Location = new System.Drawing.Point(4, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activities/Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(789, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AD User: Name Surname";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyActivitiyStackLbl
            // 
            this.emptyActivitiyStackLbl.AutoSize = true;
            this.emptyActivitiyStackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyActivitiyStackLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emptyActivitiyStackLbl.Location = new System.Drawing.Point(329, 163);
            this.emptyActivitiyStackLbl.Name = "emptyActivitiyStackLbl";
            this.emptyActivitiyStackLbl.Size = new System.Drawing.Size(143, 20);
            this.emptyActivitiyStackLbl.TabIndex = 0;
            this.emptyActivitiyStackLbl.Text = "No Timers Active";
            // 
            // emptyActivitiyStackDescriptionLbl
            // 
            this.emptyActivitiyStackDescriptionLbl.AutoSize = true;
            this.emptyActivitiyStackDescriptionLbl.Location = new System.Drawing.Point(283, 193);
            this.emptyActivitiyStackDescriptionLbl.Name = "emptyActivitiyStackDescriptionLbl";
            this.emptyActivitiyStackDescriptionLbl.Size = new System.Drawing.Size(234, 13);
            this.emptyActivitiyStackDescriptionLbl.TabIndex = 1;
            this.emptyActivitiyStackDescriptionLbl.Text = "Click on \"New Timer\" to create a new task timer";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(976, 563);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Guard";
            this.panel1.ResumeLayout(false);
            this.timerPanel.ResumeLayout(false);
            this.timerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShiftSwitchButton;
        private System.Windows.Forms.Label ServerDateLbl;
        private System.Windows.Forms.Button TimeSheetBtn;
        private System.Windows.Forms.Button NewTimerBtn;
        private System.Windows.Forms.Label toggle_shift_lbl;
        private System.Windows.Forms.Label timesheet_lbl;
        private System.Windows.Forms.Label create_timer_lbl;
        private System.Windows.Forms.Panel timerPanel;
        private System.Windows.Forms.Label TaskTimerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toggleTaskTimerCountBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label emptyMonitorsLbl;
        private System.Windows.Forms.Label ServerTimeLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label totalShiftTimeLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emptyActivitiyStackLbl;
        private System.Windows.Forms.Label emptyActivitiyStackDescriptionLbl;
    }
}

