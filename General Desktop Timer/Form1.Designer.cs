namespace General_Desktop_Timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startworktimerbutton = new System.Windows.Forms.Button();
            this.startmisctimerbutton = new System.Windows.Forms.Button();
            this.stopworktimerbutton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pausetimerbutton = new System.Windows.Forms.Button();
            this.displaycounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HydratasktextBox = new System.Windows.Forms.TextBox();
            this.clientnametextBox3 = new System.Windows.Forms.TextBox();
            this.publishdatetextBox4 = new System.Windows.Forms.TextBox();
            this.notestextBox5 = new System.Windows.Forms.TextBox();
            this.StatusNamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startworktimerbutton
            // 
            this.startworktimerbutton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.startworktimerbutton.Location = new System.Drawing.Point(12, 69);
            this.startworktimerbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startworktimerbutton.Name = "startworktimerbutton";
            this.startworktimerbutton.Size = new System.Drawing.Size(416, 59);
            this.startworktimerbutton.TabIndex = 0;
            this.startworktimerbutton.Text = "Start Work Timer";
            this.startworktimerbutton.UseVisualStyleBackColor = true;
            this.startworktimerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startmisctimerbutton
            // 
            this.startmisctimerbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.startmisctimerbutton.Location = new System.Drawing.Point(14, 196);
            this.startmisctimerbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startmisctimerbutton.Name = "startmisctimerbutton";
            this.startmisctimerbutton.Size = new System.Drawing.Size(174, 48);
            this.startmisctimerbutton.TabIndex = 3;
            this.startmisctimerbutton.Text = "Start Misc Timer";
            this.startmisctimerbutton.UseVisualStyleBackColor = true;
            this.startmisctimerbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // stopworktimerbutton
            // 
            this.stopworktimerbutton.BackColor = System.Drawing.Color.Red;
            this.stopworktimerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stopworktimerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.stopworktimerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopworktimerbutton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.stopworktimerbutton.Location = new System.Drawing.Point(14, 382);
            this.stopworktimerbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopworktimerbutton.Name = "stopworktimerbutton";
            this.stopworktimerbutton.Size = new System.Drawing.Size(416, 71);
            this.stopworktimerbutton.TabIndex = 4;
            this.stopworktimerbutton.Text = "Stop Timer";
            this.stopworktimerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.stopworktimerbutton.UseVisualStyleBackColor = false;
            this.stopworktimerbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "General_Desktop_Timer";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem5,
            this.menuItem4,
            this.menuItem9});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Start Work Timer";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Start Pre-Work Timer";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Start Post-Work Timer";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.menuItem5.Text = "Start Misc Timer";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Emergency Break";
            this.menuItem6.Click += new System.EventHandler(this.SubmenuItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Meeting";
            this.menuItem7.Click += new System.EventHandler(this.SubmenuItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "Misc Break";
            this.menuItem8.Click += new System.EventHandler(this.SubmenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "Close";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 5;
            this.menuItem9.Text = "Pause Timer";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(15, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 21);
            this.textBox1.TabIndex = 5;
            // 
            // pausetimerbutton
            // 
            this.pausetimerbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pausetimerbutton.Location = new System.Drawing.Point(243, 196);
            this.pausetimerbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pausetimerbutton.Name = "pausetimerbutton";
            this.pausetimerbutton.Size = new System.Drawing.Size(187, 48);
            this.pausetimerbutton.TabIndex = 6;
            this.pausetimerbutton.Text = "Pause Timer";
            this.pausetimerbutton.UseVisualStyleBackColor = false;
            this.pausetimerbutton.Click += new System.EventHandler(this.button6_Click);
            // 
            // displaycounter
            // 
            this.displaycounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displaycounter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.displaycounter.Location = new System.Drawing.Point(14, 297);
            this.displaycounter.Name = "displaycounter";
            this.displaycounter.Size = new System.Drawing.Size(415, 40);
            this.displaycounter.TabIndex = 7;
            this.displaycounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(478, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hydra Task Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(478, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(478, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publish Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(478, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notes";
            // 
            // HydratasktextBox
            // 
            this.HydratasktextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.HydratasktextBox.Location = new System.Drawing.Point(479, 55);
            this.HydratasktextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HydratasktextBox.Name = "HydratasktextBox";
            this.HydratasktextBox.Size = new System.Drawing.Size(240, 22);
            this.HydratasktextBox.TabIndex = 12;
            // 
            // clientnametextBox3
            // 
            this.clientnametextBox3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.clientnametextBox3.Location = new System.Drawing.Point(482, 133);
            this.clientnametextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientnametextBox3.Name = "clientnametextBox3";
            this.clientnametextBox3.Size = new System.Drawing.Size(240, 22);
            this.clientnametextBox3.TabIndex = 13;
            // 
            // publishdatetextBox4
            // 
            this.publishdatetextBox4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.publishdatetextBox4.Location = new System.Drawing.Point(482, 209);
            this.publishdatetextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.publishdatetextBox4.Name = "publishdatetextBox4";
            this.publishdatetextBox4.Size = new System.Drawing.Size(240, 22);
            this.publishdatetextBox4.TabIndex = 14;
            // 
            // notestextBox5
            // 
            this.notestextBox5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.notestextBox5.Location = new System.Drawing.Point(482, 297);
            this.notestextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notestextBox5.Name = "notestextBox5";
            this.notestextBox5.Size = new System.Drawing.Size(240, 22);
            this.notestextBox5.TabIndex = 15;
            // 
            // StatusNamecomboBox1
            // 
            this.StatusNamecomboBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.StatusNamecomboBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StatusNamecomboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StatusNamecomboBox1.FormattingEnabled = true;
            this.StatusNamecomboBox1.Items.AddRange(new object[] {
            "Provider Hierarchies",
            "Provider Hierarchies - QA",
            "Admin",
            "Quality Rosters",
            "Quality Rosters - QA",
            "Control Totals",
            "Procedure Code",
            "Data Acquisition"});
            this.StatusNamecomboBox1.Location = new System.Drawing.Point(38, 38);
            this.StatusNamecomboBox1.Name = "StatusNamecomboBox1";
            this.StatusNamecomboBox1.Size = new System.Drawing.Size(354, 29);
            this.StatusNamecomboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 479);
            this.Controls.Add(this.StatusNamecomboBox1);
            this.Controls.Add(this.notestextBox5);
            this.Controls.Add(this.publishdatetextBox4);
            this.Controls.Add(this.clientnametextBox3);
            this.Controls.Add(this.HydratasktextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displaycounter);
            this.Controls.Add(this.pausetimerbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopworktimerbutton);
            this.Controls.Add(this.startmisctimerbutton);
            this.Controls.Add(this.startworktimerbutton);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Matt\'s Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startworktimerbutton;
        private System.Windows.Forms.Button startmisctimerbutton;
        private System.Windows.Forms.Button stopworktimerbutton;
        
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pausetimerbutton;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.Label displaycounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HydratasktextBox;
        private System.Windows.Forms.TextBox clientnametextBox3;
        private System.Windows.Forms.TextBox publishdatetextBox4;
        private System.Windows.Forms.TextBox notestextBox5;
        private System.Windows.Forms.ComboBox StatusNamecomboBox1;
    }
}

