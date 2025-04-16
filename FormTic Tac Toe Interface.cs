using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    public partial class FormTic_Tac_Toe_Interface : Form
    {
        public FormTic_Tac_Toe_Interface()
        {
            InitializeComponent();
        }

        private void btExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label4.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 6; i++)
            {
                if (progressBar1.Value <= progressBar1.Maximum)
                {
                    Thread.Sleep(500);

                    label4.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100 + " %");
                    if (progressBar1.Value == 100) {
                        progressBar1.Refresh();
                        label4.Refresh();
                        break;

                    } 
                    progressBar1.Value += 20;
                    progressBar1.Refresh();
                    label4.Refresh();
                }

            }

            progressBar1.Visible = false;
            label4.Visible = false;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            

            Form frm = new Form3();
                frm.ShowDialog();
            
        }

        private void btStartGame_MouseEnter(object sender, EventArgs e)
        {
            btStartGame.BackColor = Color.Green;
        }

        private void btStartGame_MouseLeave(object sender, EventArgs e)
        {
            btStartGame.BackColor = Color.Black;
        }

        private void btExitGame_MouseEnter(object sender, EventArgs e)
        {
            btExitGame.BackColor = Color.DarkRed;
        }

        private void btExitGame_MouseLeave(object sender, EventArgs e)
        {
            btExitGame.BackColor = Color.Black;
        }

        private void FormTic_Tac_Toe_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
