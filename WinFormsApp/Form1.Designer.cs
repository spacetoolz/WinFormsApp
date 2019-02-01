namespace WinFormsApp
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.lbl2Nameprompt = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tb2age = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblBanner.Font = new System.Drawing.Font("Stencil", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.Location = new System.Drawing.Point(521, 78);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(911, 64);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "My First Winforms Application";
            this.lblBanner.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2Nameprompt
            // 
            this.lbl2Nameprompt.AutoSize = true;
            this.lbl2Nameprompt.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Nameprompt.Location = new System.Drawing.Point(240, 225);
            this.lbl2Nameprompt.Name = "lbl2Nameprompt";
            this.lbl2Nameprompt.Size = new System.Drawing.Size(265, 33);
            this.lbl2Nameprompt.TabIndex = 1;
            this.lbl2Nameprompt.Text = "Enter your Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Location = new System.Drawing.Point(237, 261);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 39);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(502, 402);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(361, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tb2age
            // 
            this.tb2age.Location = new System.Drawing.Point(788, 261);
            this.tb2age.Name = "tb2age";
            this.tb2age.Size = new System.Drawing.Size(288, 39);
            this.tb2age.TabIndex = 5;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(798, 225);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(241, 33);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "Enter your age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1866, 1141);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tb2age);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbl2Nameprompt);
            this.Controls.Add(this.lblBanner);
            this.Font = new System.Drawing.Font("Stencil", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "MyFirstWinformApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lbl2Nameprompt;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tb2age;
        private System.Windows.Forms.Label lbAge;
    }
}

