
using System;
using System.Windows.Forms;

namespace UI_Gun_shoot_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.plHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtChamber = new System.Windows.Forms.TextBox();
            this.Gun = new System.Windows.Forms.PictureBox();
            this.txtChances = new System.Windows.Forms.TextBox();
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.pbJoker = new System.Windows.Forms.PictureBox();
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.btnShootAway = new ePOSOne.btnProduct.Button_WOC();
            this.btnSpin = new ePOSOne.btnProduct.Button_WOC();
            this.btnLoadGun = new ePOSOne.btnProduct.Button_WOC();
            this.btnFire = new ePOSOne.btnProduct.Button_WOC();
            this.chamberbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoker)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1357, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plHeader
            // 
            this.plHeader.BackColor = System.Drawing.Color.Transparent;
            this.plHeader.Controls.Add(this.lblLogo);
            this.plHeader.Controls.Add(this.btnExit);
            this.plHeader.Controls.Add(this.button1);
            this.plHeader.Location = new System.Drawing.Point(16, 14);
            this.plHeader.Margin = new System.Windows.Forms.Padding(5);
            this.plHeader.Name = "plHeader";
            this.plHeader.Size = new System.Drawing.Size(1650, 71);
            this.plHeader.TabIndex = 1;
            this.plHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.plHeader_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(22, 9);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(286, 48);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Russian roulette ";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1111, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtChamber
            // 
            this.txtChamber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChamber.Enabled = false;
            this.txtChamber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtChamber.Location = new System.Drawing.Point(1044, 115);
            this.txtChamber.Multiline = true;
            this.txtChamber.Name = "txtChamber";
            this.txtChamber.Size = new System.Drawing.Size(112, 67);
            this.txtChamber.TabIndex = 4;
            this.txtChamber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChamber.Visible = false;
            this.txtChamber.TextChanged += new System.EventHandler(this.txtFire_TextChanged);
            // 
            // Gun
            // 
            this.Gun.Image = ((System.Drawing.Image)(resources.GetObject("Gun.Image")));
            this.Gun.Location = new System.Drawing.Point(625, 777);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(174, 189);
            this.Gun.TabIndex = 7;
            this.Gun.TabStop = false;
            // 
            // txtChances
            // 
            this.txtChances.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChances.Enabled = false;
            this.txtChances.ForeColor = System.Drawing.SystemColors.Info;
            this.txtChances.Location = new System.Drawing.Point(1044, 115);
            this.txtChances.Multiline = true;
            this.txtChances.Name = "txtChances";
            this.txtChances.Size = new System.Drawing.Size(112, 67);
            this.txtChances.TabIndex = 13;
            this.txtChances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChances.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // pbGun
            // 
            this.pbGun.BackColor = System.Drawing.Color.Transparent;
            this.pbGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGun.Image = ((System.Drawing.Image)(resources.GetObject("pbGun.Image")));
            this.pbGun.Location = new System.Drawing.Point(584, 188);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(286, 235);
            this.pbGun.TabIndex = 14;
            this.pbGun.TabStop = false;
            // 
            // pbJoker
            // 
            this.pbJoker.BackColor = System.Drawing.Color.Transparent;
            this.pbJoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJoker.Image = ((System.Drawing.Image)(resources.GetObject("pbJoker.Image")));
            this.pbJoker.Location = new System.Drawing.Point(342, 188);
            this.pbJoker.Name = "pbJoker";
            this.pbJoker.Size = new System.Drawing.Size(286, 235);
            this.pbJoker.TabIndex = 15;
            this.pbJoker.TabStop = false;
            this.pbJoker.Click += new System.EventHandler(this.pbJoker_Click);
            // 
            // btnPoints
            // 
            this.btnPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPoints.FlatAppearance.BorderSize = 5;
            this.btnPoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPoints.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoints.Location = new System.Drawing.Point(16, 93);
            this.btnPoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(150, 51);
            this.btnPoints.TabIndex = 3;
            this.btnPoints.Text = "Points";
            this.btnPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoints.UseVisualStyleBackColor = false;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 5;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRestart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(174, 93);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 51);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPoints.Enabled = false;
            this.txtPoints.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPoints.Location = new System.Drawing.Point(102, 104);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(54, 32);
            this.txtPoints.TabIndex = 17;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.SystemColors.Menu;
            this.msgBox.Enabled = false;
            this.msgBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.msgBox.Location = new System.Drawing.Point(342, 93);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(528, 67);
            this.msgBox.TabIndex = 18;
            this.msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShootAway
            // 
            this.btnShootAway.BackColor = System.Drawing.Color.Transparent;
            this.btnShootAway.BorderColor = System.Drawing.Color.White;
            this.btnShootAway.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShootAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShootAway.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootAway.ForeColor = System.Drawing.Color.Black;
            this.btnShootAway.Location = new System.Drawing.Point(1044, 338);
            this.btnShootAway.Name = "btnShootAway";
            this.btnShootAway.OnHoverBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShootAway.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnShootAway.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnShootAway.Size = new System.Drawing.Size(134, 127);
            this.btnShootAway.TabIndex = 12;
            this.btnShootAway.Text = "Shoot\r\nAway";
            this.btnShootAway.TextColor = System.Drawing.Color.Black;
            this.btnShootAway.UseMnemonic = false;
            this.btnShootAway.UseVisualStyleBackColor = false;
            this.btnShootAway.Click += new System.EventHandler(this.btnShootAway_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpin.BorderColor = System.Drawing.Color.White;
            this.btnSpin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Black;
            this.btnSpin.Location = new System.Drawing.Point(258, 475);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.OnHoverBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSpin.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnSpin.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnSpin.Size = new System.Drawing.Size(134, 127);
            this.btnSpin.TabIndex = 11;
            this.btnSpin.Text = "Spinner";
            this.btnSpin.TextColor = System.Drawing.Color.Black;
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnLoadGun
            // 
            this.btnLoadGun.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadGun.BorderColor = System.Drawing.Color.White;
            this.btnLoadGun.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLoadGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGun.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGun.ForeColor = System.Drawing.Color.Black;
            this.btnLoadGun.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadGun.Location = new System.Drawing.Point(62, 338);
            this.btnLoadGun.Name = "btnLoadGun";
            this.btnLoadGun.OnHoverBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadGun.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadGun.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnLoadGun.Size = new System.Drawing.Size(134, 127);
            this.btnLoadGun.TabIndex = 10;
            this.btnLoadGun.Text = "Load \r\nGun";
            this.btnLoadGun.TextColor = System.Drawing.Color.Black;
            this.btnLoadGun.UseVisualStyleBackColor = false;
            this.btnLoadGun.Click += new System.EventHandler(this.btnLoadGun_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Transparent;
            this.btnFire.BorderColor = System.Drawing.Color.White;
            this.btnFire.ButtonColor = System.Drawing.Color.Crimson;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.Black;
            this.btnFire.Location = new System.Drawing.Point(870, 475);
            this.btnFire.Name = "btnFire";
            this.btnFire.OnHoverBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFire.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnFire.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnFire.Size = new System.Drawing.Size(134, 127);
            this.btnFire.TabIndex = 9;
            this.btnFire.Text = "Fire";
            this.btnFire.TextColor = System.Drawing.Color.Black;
            this.btnFire.UseMnemonic = false;
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // chamberbox
            // 
            this.chamberbox.BackColor = System.Drawing.SystemColors.Menu;
            this.chamberbox.Enabled = false;
            this.chamberbox.ForeColor = System.Drawing.SystemColors.Info;
            this.chamberbox.Location = new System.Drawing.Point(62, 198);
            this.chamberbox.Multiline = true;
            this.chamberbox.Name = "chamberbox";
            this.chamberbox.Size = new System.Drawing.Size(112, 67);
            this.chamberbox.TabIndex = 19;
            this.chamberbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chamberbox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1053, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chances";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chamberbox);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPoints);
            this.Controls.Add(this.pbJoker);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.txtChances);
            this.Controls.Add(this.btnShootAway);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoadGun);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.txtChamber);
            this.Controls.Add(this.plHeader);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plHeader.ResumeLayout(false);
            this.plHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJoker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void btnPoints_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void pbJoker_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void txt2_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void lblLogo_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void plHeader_Paint(object sender, PaintEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel plHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtChamber;
        private System.Windows.Forms.PictureBox Gun;
        private ePOSOne.btnProduct.Button_WOC btnFire;
        private ePOSOne.btnProduct.Button_WOC btnLoadGun;
        private ePOSOne.btnProduct.Button_WOC btnSpin;
        private ePOSOne.btnProduct.Button_WOC btnShootAway;
        private System.Windows.Forms.TextBox txtChances;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.PictureBox pbJoker;
        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtPoints;
        private TextBox msgBox;
        private TextBox chamberbox;
        private Label label1;
    }
}

