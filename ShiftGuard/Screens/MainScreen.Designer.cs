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
            this.panel2 = new System.Windows.Forms.Panel();
            this.clock_lbl = new System.Windows.Forms.Label();
            this.toggle_shift_lbl = new System.Windows.Forms.Label();
            this.create_timer_lbl = new System.Windows.Forms.Label();
            this.timesheet_lbl = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewTimerBtn = new System.Windows.Forms.Button();
            this.TimeSheetBtn = new System.Windows.Forms.Button();
            this.ShiftSwitchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.timerPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 399);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.timesheet_lbl);
            this.panel2.Controls.Add(this.create_timer_lbl);
            this.panel2.Controls.Add(this.toggle_shift_lbl);
            this.panel2.Controls.Add(this.NewTimerBtn);
            this.panel2.Controls.Add(this.TimeSheetBtn);
            this.panel2.Controls.Add(this.clock_lbl);
            this.panel2.Controls.Add(this.ShiftSwitchButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 91);
            this.panel2.TabIndex = 0;
            // 
            // clock_lbl
            // 
            this.clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_lbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.clock_lbl.Location = new System.Drawing.Point(438, 52);
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(343, 20);
            this.clock_lbl.TabIndex = 1;
            this.clock_lbl.Text = "N/A";
            this.clock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // create_timer_lbl
            // 
            this.create_timer_lbl.AutoSize = true;
            this.create_timer_lbl.Location = new System.Drawing.Point(103, 66);
            this.create_timer_lbl.Name = "create_timer_lbl";
            this.create_timer_lbl.Size = new System.Drawing.Size(58, 13);
            this.create_timer_lbl.TabIndex = 5;
            this.create_timer_lbl.Text = "New Timer";
            // 
            // timesheet_lbl
            // 
            this.timesheet_lbl.AutoSize = true;
            this.timesheet_lbl.Location = new System.Drawing.Point(179, 66);
            this.timesheet_lbl.Name = "timesheet_lbl";
            this.timesheet_lbl.Size = new System.Drawing.Size(56, 13);
            this.timesheet_lbl.TabIndex = 6;
            this.timesheet_lbl.Text = "Timesheet";
            this.timesheet_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // timerPanel
            // 
            this.timerPanel.Controls.Add(this.button1);
            this.timerPanel.Controls.Add(this.label1);
            this.timerPanel.Controls.Add(this.timer);
            this.timerPanel.Location = new System.Drawing.Point(4, 97);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(779, 75);
            this.timerPanel.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Red;
            this.timer.Location = new System.Drawing.Point(3, 26);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(172, 42);
            this.timer.TabIndex = 0;
            this.timer.Text = "00:00:00";
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Elapsed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ShiftGuard.Properties.Resources.start_timer;
            this.button1.Location = new System.Drawing.Point(715, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 60);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
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
            this.TimeSheetBtn.Click += new System.EventHandler(this.button1_Click);
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 396);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Guard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.timerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShiftSwitchButton;
        private System.Windows.Forms.Label clock_lbl;
        private System.Windows.Forms.Button TimeSheetBtn;
        private System.Windows.Forms.Button NewTimerBtn;
        private System.Windows.Forms.Label toggle_shift_lbl;
        private System.Windows.Forms.Label timesheet_lbl;
        private System.Windows.Forms.Label create_timer_lbl;
        private System.Windows.Forms.Panel timerPanel;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

