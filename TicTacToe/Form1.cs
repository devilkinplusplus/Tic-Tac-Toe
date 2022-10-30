using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int playerXxal = 0;
        int playerOxal = 0;
        bool yoxla = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Reset.Enabled = false;
            yoxla = false;
        }
        string XmiOmu()
        {
            string text = "";
            if (!yoxla)
            {
                text = "X";
                yoxla = true;
            }
            else
            {
                text = "O";
                yoxla = false;
            }
            return text;
        }
        void AfterGame()
        {
            for(int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if(groupBox1.Controls[i] is Button)
                {
                    if (groupBox1.Controls[i].Text=="")
                    {
                        groupBox1.Controls[i].Enabled = false;
                    }
                }
            }
        }
        void WinOrLose()
        {
            if ((btn_b1.Text=="X"&&btn_b2.Text=="X"&&btn_b3.Text=="X")||(btn_b4.Text=="X"&&btn_b5.Text=="X"
                &&btn_b6.Text=="X")||(btn_b7.Text=="X"&&btn_b8.Text=="X"&&btn_b9.Text=="X")||
                (btn_b1.Text=="X"&&btn_b4.Text=="X"&&btn_b7.Text=="X")||(btn_b2.Text=="X"&&btn_b5.Text=="X"&&btn_b8.Text=="X")
                ||(btn_b3.Text=="X"&&btn_b6.Text=="X"&&btn_b9.Text=="X")||(btn_b1.Text=="X"&&btn_b5.Text=="X"&&btn_b9.Text=="X")
                ||(btn_b3.Text=="X"&&btn_b5.Text=="X"&&btn_b7.Text=="X"))                
            {
                MessageBox.Show("Player X won", "Oyun bitdi", MessageBoxButtons.OK);
                playerXxal++;
                AfterGame();
            }
            else if ((btn_b1.Text == "O" && btn_b2.Text == "O" && btn_b3.Text == "O") || (btn_b4.Text == "O" && btn_b5.Text == "O"
                && btn_b6.Text == "O") || (btn_b7.Text == "O" && btn_b8.Text == "O" && btn_b9.Text == "O") ||
                (btn_b1.Text == "O" && btn_b4.Text == "O" && btn_b7.Text == "O") || (btn_b2.Text == "O" && btn_b5.Text == "O" && btn_b8.Text == "O")
                || (btn_b3.Text == "O" && btn_b6.Text == "O" && btn_b9.Text == "O") || (btn_b1.Text == "O" && btn_b5.Text == "O" && btn_b9.Text == "O")
                || (btn_b3.Text == "O" && btn_b5.Text == "O" && btn_b7.Text == "O"))
            {
                MessageBox.Show("Player O won","Oyun bitdi", MessageBoxButtons.OK);
                playerOxal++;
                AfterGame();
            }
            else 
            {
                if ((btn_b1.Text != "" && btn_b2.Text != "" && btn_b3.Text != "") && (btn_b4.Text != "" && btn_b5.Text != ""
                && btn_b6.Text != "") && (btn_b7.Text != "" && btn_b8.Text != "" && btn_b9.Text != "") &&
                (btn_b1.Text != "" && btn_b4.Text != "" && btn_b7.Text != "") && (btn_b2.Text != "" && btn_b5.Text != "" && btn_b8.Text != "")
                && (btn_b3.Text != "" && btn_b6.Text != "" && btn_b9.Text != "") && (btn_b1.Text != "" && btn_b5.Text != "" && btn_b9.Text != "")
                && (btn_b3.Text != "" && btn_b5.Text != "" && btn_b7.Text != ""))
                {
                    MessageBox.Show("Bərabərə","Oyun bitdi",MessageBoxButtons.OK);                   
                }             
            }
            lbl_Xxal.Text = playerXxal.ToString();
            lbl_Oxal.Text = playerOxal.ToString();
        }
        private void btn_b1_Click(object sender, EventArgs e)
        {
            if (btn_b1.Text=="")
            {
                btn_b1.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib","Error",MessageBoxButtons.OK);
            }            
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            if (btn_b2.Text=="")
            {
                btn_b2.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }                        
        }

        private void btn_b3_Click(object sender, EventArgs e)
        {
            if (btn_b3.Text=="")
            {
                btn_b3.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }                     
        }
        private void btn_b4_Click(object sender, EventArgs e)
        {
            if (btn_b4.Text=="")
            {
                btn_b4.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }            
        }

        private void btn_b5_Click(object sender, EventArgs e)
        {
            if (btn_b5.Text=="")
            {
                btn_b5.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }                    
        }

        private void btn_b6_Click(object sender, EventArgs e)
        {
            if (btn_b6.Text=="")
            {
                btn_b6.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }            
        }

        private void btn_b7_Click(object sender, EventArgs e)
        {
            if (btn_b7.Text=="")
            {
                btn_b7.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }  
        }
        private void btn_b8_Click(object sender, EventArgs e)
        {
            if (btn_b8.Text=="")
            {
                btn_b8.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_b9_Click(object sender, EventArgs e)
        {
            if (btn_b9.Text=="")
            {
                btn_b9.Text = XmiOmu();
                btn_Reset.Enabled = true;
                WinOrLose();
            }
            else
            {
                MessageBox.Show("Bu xana artıq seçilib", "Error", MessageBoxButtons.OK);
            }   
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_b1.Text = "";
            btn_b2.Text = "";
            btn_b3.Text = "";
            btn_b4.Text = "";
            btn_b5.Text = "";
            btn_b6.Text = "";
            btn_b7.Text = "";
            btn_b8.Text = "";
            btn_b9.Text = "";
            yoxla = false;
            for(int i = 0; i<groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is Button)
                {
                    groupBox1.Controls[i].Enabled = true;
                }
            }
        }
    }
}
