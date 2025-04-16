using System;
using System.Drawing;
using System.Windows.Forms;
using FormsProject.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {

            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 450, 200, 900, 200);
            e.Graphics.DrawLine(pen, 450, 300, 900, 300);
            e.Graphics.DrawLine(pen, 600, 100, 600, 400);
            e.Graphics.DrawLine(pen, 750, 100, 750, 400);
        }
        enum enPlayerTurn { Player1=1,Player2=2};
        enPlayerTurn PlayerTurn=enPlayerTurn.Player1;

        
        byte Counter = 0;
        void DisabledButtons()
        {
            System.Windows.Forms.Button[] buttons = { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 };
            for(byte i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Tag.ToString() == "?")
                {
                    buttons[i].Enabled = false;

                }

            }


        }
        void EnabledButtons()
        {
            System.Windows.Forms.Button[] buttons = { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 };
            for (byte i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Tag.ToString() == "?")
                {
                    buttons[i].Enabled = true;

                }

            }


        }
        private void btRestartGame_MouseEnter(object sender, EventArgs e)
        {
            btRestartGame.BackColor = Color.Green;
        }

        private void btRestartGame_MouseLeave(object sender, EventArgs e)
        {
            btRestartGame.BackColor = Color.Black;
        }

        private void btEndGame_MouseEnter(object sender, EventArgs e)
        {
            btEndGame.BackColor = Color.DarkRed;
        }
        private bool CheckDraw()
        {
            if (Counter == 9)
            {
                MessageBox.Show("Draw","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return true;
            }
            return false;

        }
        private void btEndGame_MouseLeave(object sender, EventArgs e)
        {
            btEndGame.BackColor = Color.Black;
        }
        private bool CheckGameOver(System.Windows.Forms.Button button1, System.Windows.Forms.Button button2, System.Windows.Forms.Button button3)
        {
            if (button1.Tag.ToString()!="?"&&(button1.Tag.ToString() == button2.Tag.ToString() && button2.Tag.ToString() == button3.Tag.ToString()))
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                MessageBox.Show("Game Over",lbPlayerTurn.Text+" Winner",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbPlayerWinner.Text = lbPlayerTurn.Text;
                lbPlayerTurn.Text = "Game Over";
                DisabledButtons();

                return true;
            }
            else
            {
                if (CheckDraw())
                {
                    lbPlayerWinner.Text = "Draw";
                    lbPlayerTurn.Text = "Game Over";
                    return true;
                }



            }

            return false;
        }
        private bool CheckWinner()
        {
            if (CheckGameOver(bt1, bt2, bt3))
            {
                return true;
            }
            if (CheckGameOver(bt4, bt5, bt6))
            {
                return true;
            }
            if (CheckGameOver(bt7, bt8, bt9))
            {
                return true;
            }
            if (CheckGameOver(bt1, bt4, bt7))
            {
                return true;
            }
            if (CheckGameOver(bt2, bt5, bt8))
            {
                return true;
            }
            if (CheckGameOver(bt3, bt6, bt9))
            {
                return true;
            }
            if (CheckGameOver(bt1, bt5, bt9))
            {
                return true;
            }
            if (CheckGameOver(bt3, bt5, bt7))
            {
                return true;
            }
            return false;
        }
        void ChangeImage(System.Windows.Forms.Button button)
        {
            if (button.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayerTurn.Player1:

                        button.Tag = "X";
                        button.Image = Properties.Resources.X;

                        Counter++;
                        if (CheckWinner())
                            return;
                        
                        PlayerTurn = enPlayerTurn.Player2;
                        lbPlayerTurn.Text = "Player 2";
                        break;
                    case enPlayerTurn.Player2:

                        button.Tag = "O";
                        button.Image = Properties.Resources.O;
                        Counter++;
                        if (CheckWinner())
                            return;
                        
                        PlayerTurn = enPlayerTurn.Player1;
                        lbPlayerTurn.Text = "Player 1";

                        break;
                }
            }
            else
            {

                MessageBox.Show("Wrong Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        
        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((System.Windows.Forms.Button)sender);

        }

        private void Form3_Load(object sender, EventArgs e)
        { }

        private void btEndGame_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void RestButton(System.Windows.Forms.Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }
        void RestartGame()
        {

            RestButton(bt1);
            RestButton(bt2);
            RestButton(bt3);
            RestButton(bt4);
            RestButton(bt5);
            RestButton(bt6);
            RestButton(bt7);
            RestButton(bt8);
            RestButton(bt9);
            lbPlayerTurn.Text = "Player 1";
            PlayerTurn = enPlayerTurn.Player1;
            Counter = 0;
            lbPlayerWinner.Text = "In Progrees";
            EnabledButtons();
        }
        private void btRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
    
}
