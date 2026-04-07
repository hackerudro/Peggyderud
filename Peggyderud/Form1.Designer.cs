namespace Peggyderud
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradientpanel4 = new Peggyderud.gradientpanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gradientpanel3 = new Peggyderud.gradientpanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gradientpanel2 = new Peggyderud.gradientpanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientpanel1 = new Peggyderud.gradientpanel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientpanel4.SuspendLayout();
            this.gradientpanel3.SuspendLayout();
            this.gradientpanel2.SuspendLayout();
            this.gradientpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-44, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 450);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // gradientpanel4
            // 
            this.gradientpanel4.colorbottom = System.Drawing.Color.MidnightBlue;
            this.gradientpanel4.colortop = System.Drawing.Color.MidnightBlue;
            this.gradientpanel4.Controls.Add(this.panel8);
            this.gradientpanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientpanel4.Location = new System.Drawing.Point(416, 10);
            this.gradientpanel4.Name = "gradientpanel4";
            this.gradientpanel4.Size = new System.Drawing.Size(10, 430);
            this.gradientpanel4.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel8.Location = new System.Drawing.Point(0, -50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 60);
            this.panel8.TabIndex = 5;
            // 
            // gradientpanel3
            // 
            this.gradientpanel3.colorbottom = System.Drawing.Color.MidnightBlue;
            this.gradientpanel3.colortop = System.Drawing.Color.MidnightBlue;
            this.gradientpanel3.Controls.Add(this.panel6);
            this.gradientpanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientpanel3.Location = new System.Drawing.Point(0, 10);
            this.gradientpanel3.Name = "gradientpanel3";
            this.gradientpanel3.Size = new System.Drawing.Size(10, 430);
            this.gradientpanel3.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Firebrick;
            this.panel6.Location = new System.Drawing.Point(0, -50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 60);
            this.panel6.TabIndex = 5;
            // 
            // gradientpanel2
            // 
            this.gradientpanel2.colorbottom = System.Drawing.Color.CornflowerBlue;
            this.gradientpanel2.colortop = System.Drawing.Color.Black;
            this.gradientpanel2.Controls.Add(this.panel2);
            this.gradientpanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientpanel2.Location = new System.Drawing.Point(0, 440);
            this.gradientpanel2.Name = "gradientpanel2";
            this.gradientpanel2.Size = new System.Drawing.Size(426, 10);
            this.gradientpanel2.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(-50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 10);
            this.panel2.TabIndex = 2;
            // 
            // gradientpanel1
            // 
            this.gradientpanel1.colorbottom = System.Drawing.Color.Black;
            this.gradientpanel1.colortop = System.Drawing.Color.CornflowerBlue;
            this.gradientpanel1.Controls.Add(this.panel4);
            this.gradientpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientpanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientpanel1.Name = "gradientpanel1";
            this.gradientpanel1.Size = new System.Drawing.Size(426, 10);
            this.gradientpanel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(-50, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 10);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.gradientpanel4);
            this.Controls.Add(this.gradientpanel3);
            this.Controls.Add(this.gradientpanel2);
            this.Controls.Add(this.gradientpanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientpanel4.ResumeLayout(false);
            this.gradientpanel3.ResumeLayout(false);
            this.gradientpanel2.ResumeLayout(false);
            this.gradientpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private gradientpanel gradientpanel1;
        private gradientpanel gradientpanel2;
        private gradientpanel gradientpanel3;
        private gradientpanel gradientpanel4;
    }
}

