
namespace TicTacToe
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Oxal = new System.Windows.Forms.Label();
            this.lbl_Xxal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_b4 = new System.Windows.Forms.Button();
            this.btn_b8 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_b5 = new System.Windows.Forms.Button();
            this.btn_b7 = new System.Windows.Forms.Button();
            this.btn_b6 = new System.Windows.Forms.Button();
            this.btn_b9 = new System.Windows.Forms.Button();
            this.btn_b3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Reset.FlatAppearance.BorderSize = 4;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Reset.Location = new System.Drawing.Point(233, 282);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(231, 53);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Oxal);
            this.panel1.Controls.Add(this.lbl_Xxal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 200);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Oxal
            // 
            this.lbl_Oxal.AutoSize = true;
            this.lbl_Oxal.Location = new System.Drawing.Point(101, 92);
            this.lbl_Oxal.Name = "lbl_Oxal";
            this.lbl_Oxal.Size = new System.Drawing.Size(24, 26);
            this.lbl_Oxal.TabIndex = 5;
            this.lbl_Oxal.Text = "0";
            // 
            // lbl_Xxal
            // 
            this.lbl_Xxal.AutoSize = true;
            this.lbl_Xxal.Location = new System.Drawing.Point(101, 48);
            this.lbl_Xxal.Name = "lbl_Xxal";
            this.lbl_Xxal.Size = new System.Drawing.Size(24, 26);
            this.lbl_Xxal.TabIndex = 5;
            this.lbl_Xxal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player O:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(239, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tic Tac Toe ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_b1);
            this.groupBox1.Controls.Add(this.btn_b4);
            this.groupBox1.Controls.Add(this.btn_b8);
            this.groupBox1.Controls.Add(this.btn_b2);
            this.groupBox1.Controls.Add(this.btn_b5);
            this.groupBox1.Controls.Add(this.btn_b7);
            this.groupBox1.Controls.Add(this.btn_b6);
            this.groupBox1.Controls.Add(this.btn_b9);
            this.groupBox1.Controls.Add(this.btn_b3);
            this.groupBox1.Location = new System.Drawing.Point(233, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_b1
            // 
            this.btn_b1.BackColor = System.Drawing.Color.Black;
            this.btn_b1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b1.Location = new System.Drawing.Point(26, 33);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(57, 51);
            this.btn_b1.TabIndex = 5;
            this.btn_b1.UseVisualStyleBackColor = false;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // btn_b4
            // 
            this.btn_b4.BackColor = System.Drawing.Color.Black;
            this.btn_b4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b4.Location = new System.Drawing.Point(26, 90);
            this.btn_b4.Name = "btn_b4";
            this.btn_b4.Size = new System.Drawing.Size(57, 51);
            this.btn_b4.TabIndex = 6;
            this.btn_b4.UseVisualStyleBackColor = false;
            this.btn_b4.Click += new System.EventHandler(this.btn_b4_Click);
            // 
            // btn_b8
            // 
            this.btn_b8.BackColor = System.Drawing.Color.Black;
            this.btn_b8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b8.Location = new System.Drawing.Point(89, 147);
            this.btn_b8.Name = "btn_b8";
            this.btn_b8.Size = new System.Drawing.Size(57, 51);
            this.btn_b8.TabIndex = 13;
            this.btn_b8.UseVisualStyleBackColor = false;
            this.btn_b8.Click += new System.EventHandler(this.btn_b8_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.BackColor = System.Drawing.Color.Black;
            this.btn_b2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b2.Location = new System.Drawing.Point(89, 33);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(57, 51);
            this.btn_b2.TabIndex = 7;
            this.btn_b2.UseVisualStyleBackColor = false;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // btn_b5
            // 
            this.btn_b5.BackColor = System.Drawing.Color.Black;
            this.btn_b5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b5.Location = new System.Drawing.Point(89, 90);
            this.btn_b5.Name = "btn_b5";
            this.btn_b5.Size = new System.Drawing.Size(57, 51);
            this.btn_b5.TabIndex = 12;
            this.btn_b5.UseVisualStyleBackColor = false;
            this.btn_b5.Click += new System.EventHandler(this.btn_b5_Click);
            // 
            // btn_b7
            // 
            this.btn_b7.BackColor = System.Drawing.Color.Black;
            this.btn_b7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b7.Location = new System.Drawing.Point(26, 147);
            this.btn_b7.Name = "btn_b7";
            this.btn_b7.Size = new System.Drawing.Size(57, 51);
            this.btn_b7.TabIndex = 8;
            this.btn_b7.UseVisualStyleBackColor = false;
            this.btn_b7.Click += new System.EventHandler(this.btn_b7_Click);
            // 
            // btn_b6
            // 
            this.btn_b6.BackColor = System.Drawing.Color.Black;
            this.btn_b6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b6.Location = new System.Drawing.Point(151, 90);
            this.btn_b6.Name = "btn_b6";
            this.btn_b6.Size = new System.Drawing.Size(57, 51);
            this.btn_b6.TabIndex = 11;
            this.btn_b6.UseVisualStyleBackColor = false;
            this.btn_b6.Click += new System.EventHandler(this.btn_b6_Click);
            // 
            // btn_b9
            // 
            this.btn_b9.BackColor = System.Drawing.Color.Black;
            this.btn_b9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b9.Location = new System.Drawing.Point(151, 147);
            this.btn_b9.Name = "btn_b9";
            this.btn_b9.Size = new System.Drawing.Size(57, 51);
            this.btn_b9.TabIndex = 9;
            this.btn_b9.UseVisualStyleBackColor = false;
            this.btn_b9.Click += new System.EventHandler(this.btn_b9_Click);
            // 
            // btn_b3
            // 
            this.btn_b3.BackColor = System.Drawing.Color.Black;
            this.btn_b3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_b3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_b3.Location = new System.Drawing.Point(151, 33);
            this.btn_b3.Name = "btn_b3";
            this.btn_b3.Size = new System.Drawing.Size(57, 51);
            this.btn_b3.TabIndex = 10;
            this.btn_b3.UseVisualStyleBackColor = false;
            this.btn_b3.Click += new System.EventHandler(this.btn_b3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(535, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Reset);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Oxal;
        private System.Windows.Forms.Label lbl_Xxal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_b4;
        private System.Windows.Forms.Button btn_b8;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_b5;
        private System.Windows.Forms.Button btn_b7;
        private System.Windows.Forms.Button btn_b6;
        private System.Windows.Forms.Button btn_b9;
        private System.Windows.Forms.Button btn_b3;
    }
}

