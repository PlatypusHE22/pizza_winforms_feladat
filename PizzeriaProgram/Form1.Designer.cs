namespace PizzeriaProgram {
    partial class Form1 {
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdatBeolvas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFizetendo = new System.Windows.Forms.Label();
            this.tbFizetendo = new System.Windows.Forms.TextBox();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.lblCim = new System.Windows.Forms.Label();
            this.panelPizzak = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(-2, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdatBeolvas);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdatBeolvas
            // 
            this.btnAdatBeolvas.Location = new System.Drawing.Point(253, 377);
            this.btnAdatBeolvas.Name = "btnAdatBeolvas";
            this.btnAdatBeolvas.Size = new System.Drawing.Size(265, 23);
            this.btnAdatBeolvas.TabIndex = 1;
            this.btnAdatBeolvas.Text = "Adatok beolvasása";
            this.btnAdatBeolvas.UseVisualStyleBackColor = true;
            this.btnAdatBeolvas.Click += new System.EventHandler(this.btnAdatBeolvas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzeriaProgram.Properties.Resources.PizzaRat;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.lblFizetendo);
            this.tabPage2.Controls.Add(this.tbFizetendo);
            this.tabPage2.Controls.Add(this.btnBezar);
            this.tabPage2.Controls.Add(this.btnTorol);
            this.tabPage2.Controls.Add(this.btnSzamol);
            this.tabPage2.Controls.Add(this.lblCim);
            this.tabPage2.Controls.Add(this.panelPizzak);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblFizetendo
            // 
            this.lblFizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFizetendo.Location = new System.Drawing.Point(187, 322);
            this.lblFizetendo.Name = "lblFizetendo";
            this.lblFizetendo.Size = new System.Drawing.Size(117, 23);
            this.lblFizetendo.TabIndex = 6;
            this.lblFizetendo.Text = "Fizetendő:";
            this.lblFizetendo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFizetendo
            // 
            this.tbFizetendo.Location = new System.Drawing.Point(310, 325);
            this.tbFizetendo.Name = "tbFizetendo";
            this.tbFizetendo.ReadOnly = true;
            this.tbFizetendo.Size = new System.Drawing.Size(100, 20);
            this.tbFizetendo.TabIndex = 5;
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(591, 384);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 4;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(106, 384);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 3;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(106, 322);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 2;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // lblCim
            // 
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCim.Location = new System.Drawing.Point(283, 33);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(231, 44);
            this.lblCim.TabIndex = 1;
            this.lblCim.Text = "Menüválazték";
            this.lblCim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPizzak
            // 
            this.panelPizzak.AutoScroll = true;
            this.panelPizzak.Location = new System.Drawing.Point(106, 80);
            this.panelPizzak.Name = "panelPizzak";
            this.panelPizzak.Size = new System.Drawing.Size(560, 213);
            this.panelPizzak.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblFizetendo;

        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.TextBox tbFizetendo;

        private System.Windows.Forms.Label lblCim;

        private System.Windows.Forms.Panel panelPizzak;

        private System.Windows.Forms.Button btnAdatBeolvas;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}