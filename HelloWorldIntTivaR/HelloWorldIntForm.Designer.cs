namespace HelloWorldIntTivaR
{
    partial class frmHelloWorldInt
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
            this.grbLanguagesBox = new System.Windows.Forms.GroupBox();
            this.radValyrian = new System.Windows.Forms.RadioButton();
            this.radDothraki = new System.Windows.Forms.RadioButton();
            this.radKlingon = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbLanguagesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLanguagesBox
            // 
            this.grbLanguagesBox.Controls.Add(this.radValyrian);
            this.grbLanguagesBox.Controls.Add(this.radDothraki);
            this.grbLanguagesBox.Controls.Add(this.radKlingon);
            this.grbLanguagesBox.Controls.Add(this.radEnglish);
            this.grbLanguagesBox.Location = new System.Drawing.Point(12, 234);
            this.grbLanguagesBox.Name = "grbLanguagesBox";
            this.grbLanguagesBox.Size = new System.Drawing.Size(434, 97);
            this.grbLanguagesBox.TabIndex = 0;
            this.grbLanguagesBox.TabStop = false;
            this.grbLanguagesBox.Text = "Languages";
            // 
            // radValyrian
            // 
            this.radValyrian.AutoSize = true;
            this.radValyrian.Location = new System.Drawing.Point(327, 44);
            this.radValyrian.Name = "radValyrian";
            this.radValyrian.Size = new System.Drawing.Size(62, 17);
            this.radValyrian.TabIndex = 3;
            this.radValyrian.Text = "Valyrian";
            this.radValyrian.UseVisualStyleBackColor = true;
            this.radValyrian.CheckedChanged += new System.EventHandler(this.radValyrian_CheckedChanged);
            // 
            // radDothraki
            // 
            this.radDothraki.AutoSize = true;
            this.radDothraki.Location = new System.Drawing.Point(230, 44);
            this.radDothraki.Name = "radDothraki";
            this.radDothraki.Size = new System.Drawing.Size(65, 17);
            this.radDothraki.TabIndex = 2;
            this.radDothraki.Text = "Dothraki";
            this.radDothraki.UseVisualStyleBackColor = true;
            this.radDothraki.CheckedChanged += new System.EventHandler(this.radDothraki_CheckedChanged);
            // 
            // radKlingon
            // 
            this.radKlingon.AutoSize = true;
            this.radKlingon.Location = new System.Drawing.Point(138, 44);
            this.radKlingon.Name = "radKlingon";
            this.radKlingon.Size = new System.Drawing.Size(60, 17);
            this.radKlingon.TabIndex = 1;
            this.radKlingon.Text = "Klingon";
            this.radKlingon.UseVisualStyleBackColor = true;
            this.radKlingon.CheckedChanged += new System.EventHandler(this.radKlingon_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Checked = true;
            this.radEnglish.Location = new System.Drawing.Point(6, 44);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(106, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "Common Tongue";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(12, 101);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(198, 34);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Hello World";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.grbLanguagesBox);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International By Tiva R";
            this.grbLanguagesBox.ResumeLayout(false);
            this.grbLanguagesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLanguagesBox;
        private System.Windows.Forms.RadioButton radValyrian;
        private System.Windows.Forms.RadioButton radDothraki;
        private System.Windows.Forms.RadioButton radKlingon;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.Label lblGreeting;
    }
}

