
namespace Santa_Claus_Is_Coming_To_Town
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.snowFlake = new System.Windows.Forms.PictureBox();
            this.santaClaus = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moon = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaClaus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 319);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(661, 57);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // snowFlake
            // 
            this.snowFlake.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake.Image")));
            this.snowFlake.Location = new System.Drawing.Point(453, 1);
            this.snowFlake.Name = "snowFlake";
            this.snowFlake.Size = new System.Drawing.Size(75, 75);
            this.snowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake.TabIndex = 2;
            this.snowFlake.TabStop = false;
            this.snowFlake.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // santaClaus
            // 
            this.santaClaus.Image = ((System.Drawing.Image)(resources.GetObject("santaClaus.Image")));
            this.santaClaus.Location = new System.Drawing.Point(45, 129);
            this.santaClaus.Name = "santaClaus";
            this.santaClaus.Size = new System.Drawing.Size(127, 66);
            this.santaClaus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaClaus.TabIndex = 3;
            this.santaClaus.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(124, 27);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(0, 1);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(100, 64);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 5;
            this.moon.TabStop = false;
            this.moon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(512, 216);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(74, 107);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 6;
            this.tree.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(45, 251);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(94, 84);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 8;
            this.hut.TabStop = false;
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(261, 129);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(144, 91);
            this.playAgain.TabIndex = 9;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 376);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.santaClaus);
            this.Controls.Add(this.snowFlake);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaClaus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox snowFlake;
        private System.Windows.Forms.PictureBox santaClaus;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.Button playAgain;
    }
}

