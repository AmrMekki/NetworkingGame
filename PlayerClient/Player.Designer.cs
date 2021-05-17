namespace PlayerClient
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.lblP6 = new System.Windows.Forms.Label();
            this.lblP5 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblConnected = new System.Windows.Forms.Label();
            this.pnlQuestions.SuspendLayout();
            this.groupBoxPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(153)))), ((int)(((byte)(224)))));
            this.pnlQuestions.Controls.Add(this.labelQuestion);
            this.pnlQuestions.ForeColor = System.Drawing.Color.White;
            this.pnlQuestions.Location = new System.Drawing.Point(32, 240);
            this.pnlQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(592, 156);
            this.pnlQuestions.TabIndex = 31;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(259, 67);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(102, 28);
            this.labelQuestion.TabIndex = 13;
            this.labelQuestion.Text = "Question:";
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(330, 490);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(294, 86);
            this.btnD.TabIndex = 30;
            this.btnD.Text = "D.";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(32, 490);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(294, 86);
            this.btnC.TabIndex = 29;
            this.btnC.Text = "C.";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(330, 400);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(294, 86);
            this.btnB.TabIndex = 28;
            this.btnB.Text = "B. ";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(32, 400);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(294, 86);
            this.btnA.TabIndex = 27;
            this.btnA.Text = "A.";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnConnect.Location = new System.Drawing.Point(408, 159);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 52);
            this.btnConnect.TabIndex = 25;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(142, 168);
            this.txtIP.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtIP.MaxLength = 12;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(256, 41);
            this.txtIP.TabIndex = 21;
            this.txtIP.Text = "192.168.1.23";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(26, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Server:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblPlayerName.Location = new System.Drawing.Point(19, 44);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(229, 68);
            this.lblPlayerName.TabIndex = 47;
            this.lblPlayerName.Text = "Player:";
            // 
            // btnQuit
            // 
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnQuit.Location = new System.Drawing.Point(518, 159);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(106, 52);
            this.btnQuit.TabIndex = 48;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(153)))), ((int)(((byte)(224)))));
            this.groupBoxPlayers.Controls.Add(this.lblP6);
            this.groupBoxPlayers.Controls.Add(this.lblP5);
            this.groupBoxPlayers.Controls.Add(this.lblP4);
            this.groupBoxPlayers.Controls.Add(this.lblP3);
            this.groupBoxPlayers.Controls.Add(this.lblP2);
            this.groupBoxPlayers.Controls.Add(this.lblP1);
            this.groupBoxPlayers.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPlayers.Location = new System.Drawing.Point(11, 596);
            this.groupBoxPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPlayers.Size = new System.Drawing.Size(678, 176);
            this.groupBoxPlayers.TabIndex = 49;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Players";
            // 
            // lblP6
            // 
            this.lblP6.AutoSize = true;
            this.lblP6.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP6.Location = new System.Drawing.Point(513, 109);
            this.lblP6.Name = "lblP6";
            this.lblP6.Size = new System.Drawing.Size(0, 54);
            this.lblP6.TabIndex = 25;
            // 
            // lblP5
            // 
            this.lblP5.AutoSize = true;
            this.lblP5.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP5.Location = new System.Drawing.Point(278, 109);
            this.lblP5.Name = "lblP5";
            this.lblP5.Size = new System.Drawing.Size(0, 54);
            this.lblP5.TabIndex = 24;
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.Location = new System.Drawing.Point(41, 109);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(0, 54);
            this.lblP4.TabIndex = 23;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(513, 15);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(0, 54);
            this.lblP3.TabIndex = 22;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(277, 15);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(0, 54);
            this.lblP2.TabIndex = 21;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(41, 15);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(0, 54);
            this.lblP1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(450, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 46);
            this.label5.TabIndex = 51;
            this.label5.Text = "Timer";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ProgressBar1.AnimationFunction")));
            this.ProgressBar1.AnimationSpeed = 500;
            this.ProgressBar1.BackColor = System.Drawing.Color.White;
            this.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar1.Font = new System.Drawing.Font("Myriad Arabic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.ForeColor = System.Drawing.Color.White;
            this.ProgressBar1.InnerColor = System.Drawing.Color.White;
            this.ProgressBar1.InnerMargin = 2;
            this.ProgressBar1.InnerWidth = -1;
            this.ProgressBar1.Location = new System.Drawing.Point(524, 44);
            this.ProgressBar1.MarqueeAnimationSpeed = 2000;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.OuterColor = System.Drawing.Color.White;
            this.ProgressBar1.OuterMargin = -25;
            this.ProgressBar1.OuterWidth = 26;
            this.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ProgressBar1.ProgressWidth = 6;
            this.ProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.Size = new System.Drawing.Size(100, 100);
            this.ProgressBar1.StartAngle = 270;
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar1.SubscriptText = "";
            this.ProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar1.SuperscriptText = "";
            this.ProgressBar1.TabIndex = 50;
            this.ProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar1.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.ForeColor = System.Drawing.Color.Red;
            this.lblConnected.Location = new System.Drawing.Point(54, 209);
            this.lblConnected.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(369, 36);
            this.lblConnected.TabIndex = 52;
            this.lblConnected.Text = "Not Connected To Server";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.groupBoxPlayers);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlayer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPlayer_MouseMove);
            this.pnlQuestions.ResumeLayout(false);
            this.pnlQuestions.PerformLayout();
            this.groupBoxPlayers.ResumeLayout(false);
            this.groupBoxPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBoxPlayers;
        private System.Windows.Forms.Label lblP6;
        private System.Windows.Forms.Label lblP5;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar.CircularProgressBar ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblConnected;
    }
}

