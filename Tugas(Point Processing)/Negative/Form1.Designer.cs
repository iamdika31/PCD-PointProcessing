namespace Negative
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNegative = new System.Windows.Forms.Button();
			this.btnPower = new System.Windows.Forms.Button();
			this.btnPiecewise = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(51, 71);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(472, 498);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(547, 71);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(472, 498);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(210, 573);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "ORIGINAL";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(733, 573);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "HASIL";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(1069, 88);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 87);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|PNG|*.png";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(17, 28);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "Log transform";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.form1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.form1ToolStripMenuItem.Text = "Bit Slicing";
			this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.form2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
			this.form2ToolStripMenuItem.Text = "Image Subtraction";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form3ToolStripMenuItem
			// 
			this.form3ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.form3ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
			this.form3ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
			this.form3ToolStripMenuItem.Text = "Logical Operation";
			this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
			// 
			// btnNegative
			// 
			this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNegative.ForeColor = System.Drawing.Color.White;
			this.btnNegative.Location = new System.Drawing.Point(17, 64);
			this.btnNegative.Margin = new System.Windows.Forms.Padding(4);
			this.btnNegative.Name = "btnNegative";
			this.btnNegative.Size = new System.Drawing.Size(131, 28);
			this.btnNegative.TabIndex = 7;
			this.btnNegative.Text = "Negative";
			this.btnNegative.UseVisualStyleBackColor = true;
			this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
			// 
			// btnPower
			// 
			this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPower.ForeColor = System.Drawing.Color.White;
			this.btnPower.Location = new System.Drawing.Point(17, 100);
			this.btnPower.Margin = new System.Windows.Forms.Padding(4);
			this.btnPower.Name = "btnPower";
			this.btnPower.Size = new System.Drawing.Size(131, 28);
			this.btnPower.TabIndex = 8;
			this.btnPower.Text = "Power Law";
			this.btnPower.UseVisualStyleBackColor = true;
			this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
			// 
			// btnPiecewise
			// 
			this.btnPiecewise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPiecewise.ForeColor = System.Drawing.Color.White;
			this.btnPiecewise.Location = new System.Drawing.Point(17, 136);
			this.btnPiecewise.Margin = new System.Windows.Forms.Padding(4);
			this.btnPiecewise.Name = "btnPiecewise";
			this.btnPiecewise.Size = new System.Drawing.Size(131, 28);
			this.btnPiecewise.TabIndex = 9;
			this.btnPiecewise.Text = "Piecewise-Linear";
			this.btnPiecewise.UseVisualStyleBackColor = true;
			this.btnPiecewise.Click += new System.EventHandler(this.btnPiecewise_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
			this.btnReset.Location = new System.Drawing.Point(1069, 389);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 78);
			this.btnReset.TabIndex = 10;
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnPower);
			this.panel1.Controls.Add(this.btnNegative);
			this.panel1.Controls.Add(this.btnPiecewise);
			this.panel1.Location = new System.Drawing.Point(1032, 188);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(163, 178);
			this.panel1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(55, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 10;
			this.label3.Text = "Menu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel2.Controls.Add(this.bunifuFlatButton1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1207, 46);
			this.panel2.TabIndex = 12;
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.Highlight;
			this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.Highlight;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 90D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(1162, 0);
			this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.Highlight;
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(45, 45);
			this.bunifuFlatButton1.TabIndex = 13;
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(16, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(245, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tugas 1 Image Processing";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1207, 607);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Image Processing";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnPiecewise;
        private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
	}
}

