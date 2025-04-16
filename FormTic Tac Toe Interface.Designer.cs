namespace FormsProject
{
    partial class FormTic_Tac_Toe_Interface
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
            this.lbTitleGame = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btStartGame = new System.Windows.Forms.Button();
            this.btExitGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleGame
            // 
            this.lbTitleGame.AutoSize = true;
            this.lbTitleGame.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleGame.ForeColor = System.Drawing.Color.Yellow;
            this.lbTitleGame.Location = new System.Drawing.Point(371, 9);
            this.lbTitleGame.Name = "lbTitleGame";
            this.lbTitleGame.Size = new System.Drawing.Size(600, 72);
            this.lbTitleGame.TabIndex = 1;
            this.lbTitleGame.Text = "Tic_Tac_Toe Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsProject.Properties.Resources.game_7217379;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormsProject.Properties.Resources.game_7217379;
            this.pictureBox2.Location = new System.Drawing.Point(1020, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btStartGame
            // 
            this.btStartGame.BackColor = System.Drawing.Color.Black;
            this.btStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartGame.ForeColor = System.Drawing.Color.Lime;
            this.btStartGame.Location = new System.Drawing.Point(515, 198);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(334, 84);
            this.btStartGame.TabIndex = 4;
            this.btStartGame.Text = "Start Game";
            this.btStartGame.UseVisualStyleBackColor = false;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            this.btStartGame.MouseEnter += new System.EventHandler(this.btStartGame_MouseEnter);
            this.btStartGame.MouseLeave += new System.EventHandler(this.btStartGame_MouseLeave);
            // 
            // btExitGame
            // 
            this.btExitGame.BackColor = System.Drawing.Color.Black;
            this.btExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitGame.ForeColor = System.Drawing.Color.Red;
            this.btExitGame.Location = new System.Drawing.Point(515, 314);
            this.btExitGame.Name = "btExitGame";
            this.btExitGame.Size = new System.Drawing.Size(334, 84);
            this.btExitGame.TabIndex = 5;
            this.btExitGame.Text = "Exit";
            this.btExitGame.UseVisualStyleBackColor = false;
            this.btExitGame.Click += new System.EventHandler(this.btExitGame_Click);
            this.btExitGame.MouseEnter += new System.EventHandler(this.btExitGame_MouseEnter);
            this.btExitGame.MouseLeave += new System.EventHandler(this.btExitGame_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.Location = new System.Drawing.Point(515, 151);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(763, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "0%";
            this.label4.Visible = false;
            // 
            // FormTic_Tac_Toe_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btExitGame);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitleGame);
            this.DoubleBuffered = true;
            this.Name = "FormTic_Tac_Toe_Interface";
            this.Text = "FormTic_Tac_Toe_Interface";
            this.Load += new System.EventHandler(this.FormTic_Tac_Toe_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Button btExitGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
    }
}