namespace Google_Daily_Report
{
    partial class Form_Daily_Report
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_On_Line = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Now_Time = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Button();
            this.label_Now_Account = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip_TOP = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Event = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_TOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_On_Line
            // 
            this.label_On_Line.AutoSize = true;
            this.label_On_Line.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_On_Line.Location = new System.Drawing.Point(362, 33);
            this.label_On_Line.Name = "label_On_Line";
            this.label_On_Line.Size = new System.Drawing.Size(77, 40);
            this.label_On_Line.TabIndex = 0;
            this.label_On_Line.Text = "OFF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 303);
            this.textBox1.TabIndex = 1;
            // 
            // label_Now_Time
            // 
            this.label_Now_Time.AutoSize = true;
            this.label_Now_Time.Location = new System.Drawing.Point(369, 171);
            this.label_Now_Time.Name = "label_Now_Time";
            this.label_Now_Time.Size = new System.Drawing.Size(102, 24);
            this.label_Now_Time.TabIndex = 2;
            this.label_Now_Time.Text = "Now TIme";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(369, 472);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(152, 38);
            this.s.TabIndex = 3;
            this.s.Text = "Sync";
            this.s.UseVisualStyleBackColor = true;
            // 
            // label_Now_Account
            // 
            this.label_Now_Account.AutoSize = true;
            this.label_Now_Account.Location = new System.Drawing.Point(369, 73);
            this.label_Now_Account.Name = "label_Now_Account";
            this.label_Now_Account.Size = new System.Drawing.Size(131, 24);
            this.label_Now_Account.TabIndex = 4;
            this.label_Now_Account.Text = "Now Account";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthCalendar1.Location = new System.Drawing.Point(12, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // menuStrip_TOP
            // 
            this.menuStrip_TOP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip_TOP.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_TOP.Name = "menuStrip_TOP";
            this.menuStrip_TOP.Size = new System.Drawing.Size(539, 24);
            this.menuStrip_TOP.TabIndex = 6;
            this.menuStrip_TOP.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 135);
            this.textBox2.TabIndex = 7;
            // 
            // label_Event
            // 
            this.label_Event.AutoSize = true;
            this.label_Event.Location = new System.Drawing.Point(244, 33);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(69, 24);
            this.label_Event.TabIndex = 8;
            this.label_Event.Text = "Event :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(428, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "/ Line";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form_Daily_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Event);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_Now_Account);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label_Now_Time);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_On_Line);
            this.Controls.Add(this.menuStrip_TOP);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip_TOP;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Daily_Report";
            this.Text = "Daily Report";
            this.menuStrip_TOP.ResumeLayout(false);
            this.menuStrip_TOP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_On_Line;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Now_Time;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Label label_Now_Account;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip_TOP;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

