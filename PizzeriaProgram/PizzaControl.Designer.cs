using System.ComponentModel;

namespace PizzeriaProgram {
    partial class PizzaControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbKivalaszt = new System.Windows.Forms.CheckBox();
            this.rbKicsi = new System.Windows.Forms.RadioButton();
            this.rbNagy = new System.Windows.Forms.RadioButton();
            this.lblDarab = new System.Windows.Forms.Label();
            this.numDarab = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKivalaszt
            // 
            this.cbKivalaszt.Location = new System.Drawing.Point(3, 0);
            this.cbKivalaszt.Name = "cbKivalaszt";
            this.cbKivalaszt.Size = new System.Drawing.Size(104, 24);
            this.cbKivalaszt.TabIndex = 0;
            this.cbKivalaszt.Text = "checkBox1";
            this.cbKivalaszt.UseVisualStyleBackColor = true;
            // 
            // rbKicsi
            // 
            this.rbKicsi.Location = new System.Drawing.Point(128, 0);
            this.rbKicsi.Name = "rbKicsi";
            this.rbKicsi.Size = new System.Drawing.Size(104, 24);
            this.rbKicsi.TabIndex = 1;
            this.rbKicsi.TabStop = true;
            this.rbKicsi.Text = "radioButton1";
            this.rbKicsi.UseVisualStyleBackColor = true;
            // 
            // rbNagy
            // 
            this.rbNagy.Location = new System.Drawing.Point(262, 0);
            this.rbNagy.Name = "rbNagy";
            this.rbNagy.Size = new System.Drawing.Size(89, 24);
            this.rbNagy.TabIndex = 2;
            this.rbNagy.TabStop = true;
            this.rbNagy.Text = "radioButton2";
            this.rbNagy.UseVisualStyleBackColor = true;
            // 
            // lblDarab
            // 
            this.lblDarab.Location = new System.Drawing.Point(482, 1);
            this.lblDarab.Name = "lblDarab";
            this.lblDarab.Size = new System.Drawing.Size(53, 23);
            this.lblDarab.TabIndex = 4;
            this.lblDarab.Text = "Darab";
            this.lblDarab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numDarab
            // 
            this.numDarab.Location = new System.Drawing.Point(393, 3);
            this.numDarab.Name = "numDarab";
            this.numDarab.Size = new System.Drawing.Size(83, 20);
            this.numDarab.TabIndex = 5;
            // 
            // PizzaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.numDarab);
            this.Controls.Add(this.lblDarab);
            this.Controls.Add(this.rbNagy);
            this.Controls.Add(this.rbKicsi);
            this.Controls.Add(this.cbKivalaszt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PizzaControl";
            this.Size = new System.Drawing.Size(538, 26);
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numDarab;

        private System.Windows.Forms.Label lblDarab;

        private System.Windows.Forms.RadioButton rbKicsi;
        private System.Windows.Forms.RadioButton rbNagy;

        private System.Windows.Forms.CheckBox cbKivalaszt;

        #endregion
    }
}