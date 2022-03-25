namespace tesListbox
{
    partial class FormTugas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbData = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lBox2 = new System.Windows.Forms.ListBox();
            this.cBoxBlock = new System.Windows.Forms.CheckBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(48, 49);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(31, 15);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Location = new System.Drawing.Point(48, 83);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(41, 15);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "Mode:";
            // 
            // lBox1
            // 
            this.lBox1.FormattingEnabled = true;
            this.lBox1.ItemHeight = 15;
            this.lBox1.Location = new System.Drawing.Point(48, 147);
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(183, 214);
            this.lBox1.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(237, 186);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = ">>";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(237, 218);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = ">";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(237, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "<";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(237, 276);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 23);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "<<";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(237, 305);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 23);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "x";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // lBox2
            // 
            this.lBox2.FormattingEnabled = true;
            this.lBox2.ItemHeight = 15;
            this.lBox2.Location = new System.Drawing.Point(290, 147);
            this.lBox2.Name = "lBox2";
            this.lBox2.Size = new System.Drawing.Size(183, 214);
            this.lBox2.TabIndex = 9;
            // 
            // cBoxBlock
            // 
            this.cBoxBlock.AutoSize = true;
            this.cBoxBlock.Location = new System.Drawing.Point(269, 116);
            this.cBoxBlock.Name = "cBoxBlock";
            this.cBoxBlock.Size = new System.Drawing.Size(55, 19);
            this.cBoxBlock.TabIndex = 10;
            this.cBoxBlock.Text = "Block";
            this.cBoxBlock.UseVisualStyleBackColor = true;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(48, 112);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 11;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(92, 41);
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.Size = new System.Drawing.Size(290, 23);
            this.tBoxData.TabIndex = 12;
            // 
            // cBoxMode
            // 
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Location = new System.Drawing.Point(92, 75);
            this.cBoxMode.Name = "cBoxMode";
            this.cBoxMode.Size = new System.Drawing.Size(139, 23);
            this.cBoxMode.TabIndex = 13;
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxMode);
            this.Controls.Add(this.tBoxData);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.cBoxBlock);
            this.Controls.Add(this.lBox2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lBox1);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.lbData);
            this.Name = "FormTugas";
            this.Text = "Form Tugas";
            this.Load += new System.EventHandler(this.FormTugas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.ListBox lBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ListBox lBox2;
        private System.Windows.Forms.CheckBox cBoxBlock;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox tBoxData;
        private System.Windows.Forms.ComboBox cBoxMode;
    }
}
