namespace TandHRace
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
            this.components = new System.ComponentModel.Container();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.pbTurtle = new System.Windows.Forms.PictureBox();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.gbDrawType = new System.Windows.Forms.GroupBox();
            this.rbPictureMode = new System.Windows.Forms.RadioButton();
            this.rbDrawMode = new System.Windows.Forms.RadioButton();
            this.btnHareColor = new System.Windows.Forms.Button();
            this.cdHareColor = new System.Windows.Forms.ColorDialog();
            this.bntTortoiseColor = new System.Windows.Forms.Button();
            this.btnIncreaseTimer = new System.Windows.Forms.Button();
            this.btnSlowTimer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnResetScoreBoard = new System.Windows.Forms.Button();
            this.lblHare = new System.Windows.Forms.Label();
            this.lblTurtle = new System.Windows.Forms.Label();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.txtTortoiseWins = new System.Windows.Forms.TextBox();
            this.txtHareWins = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.lblHareWins = new System.Windows.Forms.Label();
            this.gbNewRace = new System.Windows.Forms.GroupBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.cdTurtleColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurtle)).BeginInit();
            this.gbDrawType.SuspendLayout();
            this.gbNewRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHare
            // 
            this.pbHare.Location = new System.Drawing.Point(12, 25);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(750, 64);
            this.pbHare.TabIndex = 0;
            this.pbHare.TabStop = false;
            this.pbHare.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHare_Paint);
            // 
            // pbTurtle
            // 
            this.pbTurtle.Location = new System.Drawing.Point(12, 106);
            this.pbTurtle.Name = "pbTurtle";
            this.pbTurtle.Size = new System.Drawing.Size(750, 64);
            this.pbTurtle.TabIndex = 1;
            this.pbTurtle.TabStop = false;
            this.pbTurtle.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTurtle_Paint);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPause.Location = new System.Drawing.Point(320, 197);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(57, 52);
            this.btnStartPause.TabIndex = 2;
            this.btnStartPause.Text = "▶";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // gbDrawType
            // 
            this.gbDrawType.Controls.Add(this.rbPictureMode);
            this.gbDrawType.Controls.Add(this.rbDrawMode);
            this.gbDrawType.Location = new System.Drawing.Point(12, 176);
            this.gbDrawType.Name = "gbDrawType";
            this.gbDrawType.Size = new System.Drawing.Size(97, 91);
            this.gbDrawType.TabIndex = 3;
            this.gbDrawType.TabStop = false;
            this.gbDrawType.Text = "Animation Type";
            // 
            // rbPictureMode
            // 
            this.rbPictureMode.AutoSize = true;
            this.rbPictureMode.Location = new System.Drawing.Point(6, 56);
            this.rbPictureMode.Name = "rbPictureMode";
            this.rbPictureMode.Size = new System.Drawing.Size(88, 17);
            this.rbPictureMode.TabIndex = 1;
            this.rbPictureMode.Text = "Picture Mode";
            this.rbPictureMode.UseVisualStyleBackColor = true;
            this.rbPictureMode.CheckedChanged += new System.EventHandler(this.rbPictureMode_CheckedChanged);
            // 
            // rbDrawMode
            // 
            this.rbDrawMode.AutoSize = true;
            this.rbDrawMode.Checked = true;
            this.rbDrawMode.Location = new System.Drawing.Point(6, 26);
            this.rbDrawMode.Name = "rbDrawMode";
            this.rbDrawMode.Size = new System.Drawing.Size(80, 17);
            this.rbDrawMode.TabIndex = 0;
            this.rbDrawMode.TabStop = true;
            this.rbDrawMode.Text = "Draw Mode";
            this.rbDrawMode.UseVisualStyleBackColor = true;
            // 
            // btnHareColor
            // 
            this.btnHareColor.Location = new System.Drawing.Point(132, 230);
            this.btnHareColor.Name = "btnHareColor";
            this.btnHareColor.Size = new System.Drawing.Size(90, 34);
            this.btnHareColor.TabIndex = 6;
            this.btnHareColor.Text = "Hare Color";
            this.btnHareColor.UseVisualStyleBackColor = true;
            this.btnHareColor.Click += new System.EventHandler(this.btnHareColor_Click);
            // 
            // bntTortoiseColor
            // 
            this.bntTortoiseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTortoiseColor.Location = new System.Drawing.Point(132, 185);
            this.bntTortoiseColor.Name = "bntTortoiseColor";
            this.bntTortoiseColor.Size = new System.Drawing.Size(90, 34);
            this.bntTortoiseColor.TabIndex = 7;
            this.bntTortoiseColor.Text = "Tortoise Color";
            this.bntTortoiseColor.UseVisualStyleBackColor = true;
            this.bntTortoiseColor.Click += new System.EventHandler(this.bntTortoiseColor_Click);
            // 
            // btnIncreaseTimer
            // 
            this.btnIncreaseTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseTimer.Location = new System.Drawing.Point(446, 197);
            this.btnIncreaseTimer.Name = "btnIncreaseTimer";
            this.btnIncreaseTimer.Size = new System.Drawing.Size(57, 52);
            this.btnIncreaseTimer.TabIndex = 8;
            this.btnIncreaseTimer.Text = "⏩";
            this.btnIncreaseTimer.UseVisualStyleBackColor = true;
            this.btnIncreaseTimer.Click += new System.EventHandler(this.btnIncreaseTimer_Click);
            // 
            // btnSlowTimer
            // 
            this.btnSlowTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlowTimer.Location = new System.Drawing.Point(257, 197);
            this.btnSlowTimer.Name = "btnSlowTimer";
            this.btnSlowTimer.Size = new System.Drawing.Size(57, 52);
            this.btnSlowTimer.TabIndex = 9;
            this.btnSlowTimer.Text = "⏪";
            this.btnSlowTimer.UseVisualStyleBackColor = true;
            this.btnSlowTimer.Click += new System.EventHandler(this.btnSlowTimer_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(383, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 52);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "⏹";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnResetScoreBoard
            // 
            this.btnResetScoreBoard.Location = new System.Drawing.Point(766, 207);
            this.btnResetScoreBoard.Name = "btnResetScoreBoard";
            this.btnResetScoreBoard.Size = new System.Drawing.Size(89, 45);
            this.btnResetScoreBoard.TabIndex = 11;
            this.btnResetScoreBoard.Text = "Reset Score Board";
            this.btnResetScoreBoard.UseVisualStyleBackColor = true;
            // 
            // lblHare
            // 
            this.lblHare.AutoSize = true;
            this.lblHare.Location = new System.Drawing.Point(15, 9);
            this.lblHare.Name = "lblHare";
            this.lblHare.Size = new System.Drawing.Size(30, 13);
            this.lblHare.TabIndex = 12;
            this.lblHare.Text = "Hare";
            // 
            // lblTurtle
            // 
            this.lblTurtle.AutoSize = true;
            this.lblTurtle.Location = new System.Drawing.Point(15, 91);
            this.lblTurtle.Name = "lblTurtle";
            this.lblTurtle.Size = new System.Drawing.Size(34, 13);
            this.lblTurtle.TabIndex = 13;
            this.lblTurtle.Text = "Turtle";
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(861, 207);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(89, 45);
            this.btnShowStats.TabIndex = 14;
            this.btnShowStats.Text = "Show Stats";
            this.btnShowStats.UseVisualStyleBackColor = true;
            // 
            // txtTortoiseWins
            // 
            this.txtTortoiseWins.Location = new System.Drawing.Point(766, 68);
            this.txtTortoiseWins.Name = "txtTortoiseWins";
            this.txtTortoiseWins.Size = new System.Drawing.Size(30, 20);
            this.txtTortoiseWins.TabIndex = 15;
            // 
            // txtHareWins
            // 
            this.txtHareWins.Location = new System.Drawing.Point(920, 68);
            this.txtHareWins.Name = "txtHareWins";
            this.txtHareWins.Size = new System.Drawing.Size(30, 20);
            this.txtHareWins.TabIndex = 16;
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(842, 68);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(30, 20);
            this.txtDraw.TabIndex = 17;
            // 
            // lblHareWins
            // 
            this.lblHareWins.AutoSize = true;
            this.lblHareWins.Location = new System.Drawing.Point(763, 25);
            this.lblHareWins.Name = "lblHareWins";
            this.lblHareWins.Size = new System.Drawing.Size(57, 13);
            this.lblHareWins.TabIndex = 18;
            this.lblHareWins.Text = "Hare Wins";
            // 
            // gbNewRace
            // 
            this.gbNewRace.Controls.Add(this.lblSteps);
            this.gbNewRace.Controls.Add(this.nudSteps);
            this.gbNewRace.Location = new System.Drawing.Point(546, 185);
            this.gbNewRace.Name = "gbNewRace";
            this.gbNewRace.Size = new System.Drawing.Size(200, 84);
            this.gbNewRace.TabIndex = 19;
            this.gbNewRace.TabStop = false;
            this.gbNewRace.Text = "New Race";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(12, 21);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(37, 13);
            this.lblSteps.TabIndex = 1;
            this.lblSteps.Text = "Steps:";
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(53, 17);
            this.nudSteps.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(62, 20);
            this.nudSteps.TabIndex = 0;
            this.nudSteps.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 281);
            this.Controls.Add(this.gbNewRace);
            this.Controls.Add(this.lblHareWins);
            this.Controls.Add(this.txtDraw);
            this.Controls.Add(this.txtHareWins);
            this.Controls.Add(this.txtTortoiseWins);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.lblTurtle);
            this.Controls.Add(this.lblHare);
            this.Controls.Add(this.btnResetScoreBoard);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSlowTimer);
            this.Controls.Add(this.btnIncreaseTimer);
            this.Controls.Add(this.bntTortoiseColor);
            this.Controls.Add(this.btnHareColor);
            this.Controls.Add(this.gbDrawType);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.pbTurtle);
            this.Controls.Add(this.pbHare);
            this.Name = "Form1";
            this.Text = "Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurtle)).EndInit();
            this.gbDrawType.ResumeLayout(false);
            this.gbDrawType.PerformLayout();
            this.gbNewRace.ResumeLayout(false);
            this.gbNewRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.PictureBox pbTurtle;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.GroupBox gbDrawType;
        private System.Windows.Forms.RadioButton rbPictureMode;
        private System.Windows.Forms.RadioButton rbDrawMode;
        private System.Windows.Forms.Button btnHareColor;
        private System.Windows.Forms.ColorDialog cdHareColor;
        private System.Windows.Forms.Button bntTortoiseColor;
        private System.Windows.Forms.Button btnIncreaseTimer;
        private System.Windows.Forms.Button btnSlowTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnResetScoreBoard;
        private System.Windows.Forms.Label lblHare;
        private System.Windows.Forms.Label lblTurtle;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.TextBox txtTortoiseWins;
        private System.Windows.Forms.TextBox txtHareWins;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Label lblHareWins;
        private System.Windows.Forms.GroupBox gbNewRace;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ColorDialog cdTurtleColor;
    }
}

