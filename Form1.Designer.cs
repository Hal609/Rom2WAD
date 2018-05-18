namespace WindowsFormsApp1
{
    partial class Rom2WAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rom2WAD));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.channelID = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_WADBrowse = new System.Windows.Forms.Button();
            this.But_RomBrowse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RTB_USWadPath = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RTB_RomPath = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.channelName = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(809, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(809, 176);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(809, 208);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 6;
            // 
            // channelID
            // 
            this.channelID.Location = new System.Drawing.Point(809, 240);
            this.channelID.Margin = new System.Windows.Forms.Padding(4);
            this.channelID.Name = "channelID";
            this.channelID.Size = new System.Drawing.Size(161, 22);
            this.channelID.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(809, 140);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "WAD Title (Optional) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // But_WADBrowse
            // 
            this.But_WADBrowse.Location = new System.Drawing.Point(584, 153);
            this.But_WADBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.But_WADBrowse.Name = "But_WADBrowse";
            this.But_WADBrowse.Size = new System.Drawing.Size(95, 33);
            this.But_WADBrowse.TabIndex = 14;
            this.But_WADBrowse.Text = "Browse";
            this.But_WADBrowse.UseVisualStyleBackColor = true;
            this.But_WADBrowse.Click += new System.EventHandler(this.WADFILE_Click);
            // 
            // But_RomBrowse
            // 
            this.But_RomBrowse.Location = new System.Drawing.Point(584, 245);
            this.But_RomBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.But_RomBrowse.Name = "But_RomBrowse";
            this.But_RomBrowse.Size = new System.Drawing.Size(95, 33);
            this.But_RomBrowse.TabIndex = 15;
            this.But_RomBrowse.Text = "Browse";
            this.But_RomBrowse.UseVisualStyleBackColor = true;
            this.But_RomBrowse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(563, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Create WAD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 69);
            this.label2.TabIndex = 18;
            this.label2.Text = "DEBUG";
            // 
            // RTB_USWadPath
            // 
            this.RTB_USWadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_USWadPath.Location = new System.Drawing.Point(29, 108);
            this.RTB_USWadPath.Name = "RTB_USWadPath";
            this.RTB_USWadPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB_USWadPath.Size = new System.Drawing.Size(678, 33);
            this.RTB_USWadPath.TabIndex = 21;
            this.RTB_USWadPath.Text = "";
            this.RTB_USWadPath.WordWrap = false;
            this.RTB_USWadPath.TextChanged += new System.EventHandler(this.RTB_USWadPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "US-OoT-1.0.wad :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // RTB_RomPath
            // 
            this.RTB_RomPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_RomPath.Location = new System.Drawing.Point(29, 205);
            this.RTB_RomPath.Name = "RTB_RomPath";
            this.RTB_RomPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB_RomPath.Size = new System.Drawing.Size(678, 33);
            this.RTB_RomPath.TabIndex = 21;
            this.RTB_RomPath.Text = "";
            this.RTB_RomPath.WordWrap = false;
            this.RTB_RomPath.TextChanged += new System.EventHandler(this.RTB_RomPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Compressed Randomiser Rom (32MB) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // channelName
            // 
            this.channelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelName.Location = new System.Drawing.Point(29, 293);
            this.channelName.Name = "channelName";
            this.channelName.Size = new System.Drawing.Size(287, 33);
            this.channelName.TabIndex = 23;
            this.channelName.Text = "OoT Randomized";
            this.channelName.TextChanged += new System.EventHandler(this.channelName_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 40);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rom2Wad";
            // 
            // Rom2WAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(736, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.channelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RTB_RomPath);
            this.Controls.Add(this.RTB_USWadPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.But_RomBrowse);
            this.Controls.Add(this.But_WADBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.channelID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 424);
            this.MinimumSize = new System.Drawing.Size(751, 424);
            this.Name = "Rom2WAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rom2WAD";
            this.Load += new System.EventHandler(this.Rom2WAD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox channelID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_WADBrowse;
        private System.Windows.Forms.Button But_RomBrowse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTB_USWadPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RTB_RomPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox channelName;
        private System.Windows.Forms.Label label6;
    }
}

