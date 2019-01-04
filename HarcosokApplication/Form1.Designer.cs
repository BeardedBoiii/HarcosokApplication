namespace HarcosokApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HarcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.harcosBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegAddBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.keppesegLeirasTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcosok Létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // HarcosNeveTextBox
            // 
            this.HarcosNeveTextBox.Location = new System.Drawing.Point(48, 29);
            this.HarcosNeveTextBox.Name = "HarcosNeveTextBox";
            this.HarcosNeveTextBox.Size = new System.Drawing.Size(262, 20);
            this.HarcosNeveTextBox.TabIndex = 2;
            // 
            // harcosBtn
            // 
            this.harcosBtn.Location = new System.Drawing.Point(401, 32);
            this.harcosBtn.Name = "harcosBtn";
            this.harcosBtn.Size = new System.Drawing.Size(75, 23);
            this.harcosBtn.TabIndex = 3;
            this.harcosBtn.Text = "Létrehozás";
            this.harcosBtn.UseVisualStyleBackColor = true;
            this.harcosBtn.Click += new System.EventHandler(this.harcosBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Képpeség hozzáadás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Használó";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Név";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Leírás";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(78, 94);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(232, 21);
            this.hasznaloComboBox.TabIndex = 8;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(78, 126);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(232, 20);
            this.kepessegNeveTextBox.TabIndex = 9;
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(401, 98);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(243, 55);
            this.leirasTextBox.TabIndex = 10;
            // 
            // kepessegAddBtn
            // 
            this.kepessegAddBtn.Location = new System.Drawing.Point(21, 156);
            this.kepessegAddBtn.Name = "kepessegAddBtn";
            this.kepessegAddBtn.Size = new System.Drawing.Size(75, 23);
            this.kepessegAddBtn.TabIndex = 11;
            this.kepessegAddBtn.Text = "Hozzáad";
            this.kepessegAddBtn.UseVisualStyleBackColor = true;
            this.kepessegAddBtn.Click += new System.EventHandler(this.kepessegAddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Harcosok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Képességei";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Leírás";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(27, 242);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(179, 186);
            this.harcosokListBox.TabIndex = 15;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.HosListBoxChange);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(272, 242);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(126, 186);
            this.kepessegekListBox.TabIndex = 16;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegListBoxChange);
            // 
            // keppesegLeirasTextBox
            // 
            this.keppesegLeirasTextBox.Location = new System.Drawing.Point(443, 242);
            this.keppesegLeirasTextBox.Multiline = true;
            this.keppesegLeirasTextBox.Name = "keppesegLeirasTextBox";
            this.keppesegLeirasTextBox.Size = new System.Drawing.Size(235, 117);
            this.keppesegLeirasTextBox.TabIndex = 17;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(323, 434);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Törlés";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(603, 365);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Modósít";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 491);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.keppesegLeirasTextBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kepessegAddBtn);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.harcosBtn);
            this.Controls.Add(this.HarcosNeveTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HarcosNeveTextBox;
        private System.Windows.Forms.Button harcosBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Button kepessegAddBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.TextBox keppesegLeirasTextBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}

