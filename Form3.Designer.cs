namespace FormsProject
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPlayerTurn = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbTitleGame = new System.Windows.Forms.Label();
            this.btEndGame = new System.Windows.Forms.Button();
            this.btRestartGame = new System.Windows.Forms.Button();
            this.lbPlayerWinner = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.pbimage2 = new System.Windows.Forms.PictureBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsProject.Properties.Resources.game_7217379;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbPlayerTurn
            // 
            this.lbPlayerTurn.AutoSize = true;
            this.lbPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerTurn.ForeColor = System.Drawing.Color.Lime;
            this.lbPlayerTurn.Location = new System.Drawing.Point(186, 179);
            this.lbPlayerTurn.Name = "lbPlayerTurn";
            this.lbPlayerTurn.Size = new System.Drawing.Size(163, 42);
            this.lbPlayerTurn.TabIndex = 20;
            this.lbPlayerTurn.Text = "Player 1";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lbTurn.Location = new System.Drawing.Point(33, 179);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(132, 42);
            this.lbTurn.TabIndex = 18;
            this.lbTurn.Text = "Turn  :";
            // 
            // lbTitleGame
            // 
            this.lbTitleGame.AutoSize = true;
            this.lbTitleGame.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleGame.ForeColor = System.Drawing.Color.Yellow;
            this.lbTitleGame.Location = new System.Drawing.Point(580, 9);
            this.lbTitleGame.Name = "lbTitleGame";
            this.lbTitleGame.Size = new System.Drawing.Size(600, 72);
            this.lbTitleGame.TabIndex = 21;
            this.lbTitleGame.Text = "Tic_Tac_Toe Game";
            // 
            // btEndGame
            // 
            this.btEndGame.BackColor = System.Drawing.Color.Black;
            this.btEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEndGame.ForeColor = System.Drawing.Color.Red;
            this.btEndGame.Location = new System.Drawing.Point(13, 433);
            this.btEndGame.Name = "btEndGame";
            this.btEndGame.Size = new System.Drawing.Size(185, 76);
            this.btEndGame.TabIndex = 36;
            this.btEndGame.Text = "End Game";
            this.btEndGame.UseVisualStyleBackColor = false;
            this.btEndGame.Click += new System.EventHandler(this.btEndGame_Click);
            this.btEndGame.MouseEnter += new System.EventHandler(this.btEndGame_MouseEnter);
            this.btEndGame.MouseLeave += new System.EventHandler(this.btEndGame_MouseLeave);
            // 
            // btRestartGame
            // 
            this.btRestartGame.BackColor = System.Drawing.Color.Black;
            this.btRestartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestartGame.ForeColor = System.Drawing.Color.Lime;
            this.btRestartGame.Location = new System.Drawing.Point(226, 433);
            this.btRestartGame.Name = "btRestartGame";
            this.btRestartGame.Size = new System.Drawing.Size(185, 76);
            this.btRestartGame.TabIndex = 35;
            this.btRestartGame.Text = "Resetart Game";
            this.btRestartGame.UseVisualStyleBackColor = false;
            this.btRestartGame.Click += new System.EventHandler(this.btRestartGame_Click);
            this.btRestartGame.MouseEnter += new System.EventHandler(this.btRestartGame_MouseEnter);
            this.btRestartGame.MouseLeave += new System.EventHandler(this.btRestartGame_MouseLeave);
            // 
            // lbPlayerWinner
            // 
            this.lbPlayerWinner.AutoSize = true;
            this.lbPlayerWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbPlayerWinner.Location = new System.Drawing.Point(188, 373);
            this.lbPlayerWinner.Name = "lbPlayerWinner";
            this.lbPlayerWinner.Size = new System.Drawing.Size(234, 46);
            this.lbPlayerWinner.TabIndex = 38;
            this.lbPlayerWinner.Text = "In Progress";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lbWinner.Location = new System.Drawing.Point(33, 373);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(156, 42);
            this.lbWinner.TabIndex = 37;
            this.lbWinner.Text = "Winner :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(33, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "Player 1 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(33, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 42);
            this.label2.TabIndex = 40;
            this.label2.Text = "Player 2 :";
            // 
            // pbImage1
            // 
            this.pbImage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage1.Image = global::FormsProject.Properties.Resources.X;
            this.pbImage1.Location = new System.Drawing.Point(249, 242);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(100, 50);
            this.pbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage1.TabIndex = 41;
            this.pbImage1.TabStop = false;
            // 
            // pbimage2
            // 
            this.pbimage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbimage2.Image = global::FormsProject.Properties.Resources.O;
            this.pbimage2.Location = new System.Drawing.Point(249, 306);
            this.pbimage2.Name = "pbimage2";
            this.pbimage2.Size = new System.Drawing.Size(100, 50);
            this.pbimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbimage2.TabIndex = 42;
            this.pbimage2.TabStop = false;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Black;
            this.bt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt1.Location = new System.Drawing.Point(636, 121);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(139, 100);
            this.bt1.TabIndex = 43;
            this.bt1.Tag = "?";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.button_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Black;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt2.Location = new System.Drawing.Point(838, 121);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(139, 100);
            this.bt2.TabIndex = 44;
            this.bt2.Tag = "?";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.button_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Black;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt3.Location = new System.Drawing.Point(1028, 121);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(139, 100);
            this.bt3.TabIndex = 45;
            this.bt3.Tag = "?";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.button_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Black;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt4.Location = new System.Drawing.Point(636, 256);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(139, 100);
            this.bt4.TabIndex = 46;
            this.bt4.Tag = "?";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.button_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Black;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt5.Location = new System.Drawing.Point(838, 256);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(139, 100);
            this.bt5.TabIndex = 47;
            this.bt5.Tag = "?";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.button_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Black;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt6.Location = new System.Drawing.Point(1028, 256);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(139, 100);
            this.bt6.TabIndex = 48;
            this.bt6.Tag = "?";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.button_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Black;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt7.Location = new System.Drawing.Point(636, 387);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(139, 100);
            this.bt7.TabIndex = 49;
            this.bt7.Tag = "?";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.button_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Black;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt8.Location = new System.Drawing.Point(838, 387);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(139, 100);
            this.bt8.TabIndex = 50;
            this.bt8.Tag = "?";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.button_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Black;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Image = global::FormsProject.Properties.Resources.question_mark_96;
            this.bt9.Location = new System.Drawing.Point(1028, 387);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(139, 100);
            this.bt9.TabIndex = 51;
            this.bt9.Tag = "?";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1251, 521);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.pbimage2);
            this.Controls.Add(this.pbImage1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayerWinner);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.btEndGame);
            this.Controls.Add(this.btRestartGame);
            this.Controls.Add(this.lbTitleGame);
            this.Controls.Add(this.lbPlayerTurn);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Tag = "?";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPlayerTurn;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbTitleGame;
        private System.Windows.Forms.Button btEndGame;
        private System.Windows.Forms.Button btRestartGame;
        private System.Windows.Forms.Label lbPlayerWinner;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.PictureBox pbimage2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
    }
}