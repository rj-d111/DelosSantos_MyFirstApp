namespace DelosSantos_Project.Forms
{
    partial class Register
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
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.basicInfo1 = new DelosSantos_Project.Registration.BasicInformation();
            this.gradientPanel1 = new DelosSantos_Project.CustomControls.GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentBackgroundTextBox1 = new DelosSantos_Project.CustomControls.TransparentBackgroundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contact1 = new DelosSantos_Project.Registration.Contact();
            this.educationalBg1 = new DelosSantos_Project.Registration.EducationalBg();
            this.consent1 = new DelosSantos_Project.Registration.Consent();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.White;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox21.Enabled = false;
            this.textBox21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.textBox21.HideSelection = false;
            this.textBox21.Location = new System.Drawing.Point(492, 14);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(772, 23);
            this.textBox21.TabIndex = 57;
            this.textBox21.Text = "Please fill all the required fields";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(984, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(290, 0, 3, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseButton.Size = new System.Drawing.Size(23, 27);
            this.CloseButton.TabIndex = 68;
            this.CloseButton.Text = "×";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // basicInfo1
            // 
            this.basicInfo1.BackColor = System.Drawing.Color.White;
            this.basicInfo1.Location = new System.Drawing.Point(466, 44);
            this.basicInfo1.Name = "basicInfo1";
            this.basicInfo1.Size = new System.Drawing.Size(540, 492);
            this.basicInfo1.TabIndex = 67;
            this.basicInfo1.Load += new System.EventHandler(this.basicInfo1_Load_1);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.transparentBackgroundTextBox1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(461, 541);
            this.gradientPanel1.TabIndex = 47;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DelosSantos_Project.Properties.Resources.registration_form;
            this.pictureBox2.Location = new System.Drawing.Point(105, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DelosSantos_Project.Properties.Resources.lpu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // transparentBackgroundTextBox1
            // 
            this.transparentBackgroundTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.transparentBackgroundTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transparentBackgroundTextBox1.ColorBottom = System.Drawing.Color.Empty;
            this.transparentBackgroundTextBox1.ColorTop = System.Drawing.Color.Empty;
            this.transparentBackgroundTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.transparentBackgroundTextBox1.Enabled = false;
            this.transparentBackgroundTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.transparentBackgroundTextBox1.ForeColor = System.Drawing.Color.White;
            this.transparentBackgroundTextBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.transparentBackgroundTextBox1.Location = new System.Drawing.Point(18, 358);
            this.transparentBackgroundTextBox1.Multiline = true;
            this.transparentBackgroundTextBox1.Name = "transparentBackgroundTextBox1";
            this.transparentBackgroundTextBox1.ReadOnly = true;
            this.transparentBackgroundTextBox1.Size = new System.Drawing.Size(426, 118);
            this.transparentBackgroundTextBox1.TabIndex = 101;
            this.transparentBackgroundTextBox1.Text = "Reconnect with your classmates and alma mater \r\n        by registering for your a" +
    "lumni account.";
            this.transparentBackgroundTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 100;
            this.label1.Text = "Registration";
            // 
            // contact1
            // 
            this.contact1.BackColor = System.Drawing.Color.White;
            this.contact1.Location = new System.Drawing.Point(462, 43);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(540, 492);
            this.contact1.TabIndex = 69;
            this.contact1.Load += new System.EventHandler(this.contact1_Load);
            // 
            // educationalBg1
            // 
            this.educationalBg1.BackColor = System.Drawing.Color.White;
            this.educationalBg1.Location = new System.Drawing.Point(467, 43);
            this.educationalBg1.Name = "educationalBg1";
            this.educationalBg1.Size = new System.Drawing.Size(540, 492);
            this.educationalBg1.TabIndex = 70;
            // 
            // consent1
            // 
            this.consent1.BackColor = System.Drawing.Color.White;
            this.consent1.Location = new System.Drawing.Point(467, 45);
            this.consent1.Name = "consent1";
            this.consent1.Size = new System.Drawing.Size(540, 492);
            this.consent1.TabIndex = 71;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.basicInfo1);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.contact1);
            this.Controls.Add(this.educationalBg1);
            this.Controls.Add(this.consent1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.TransparentBackgroundTextBox transparentBackgroundTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label CloseButton;
        public Registration.BasicInformation basicInfo1;
        public Registration.Contact contact1;
        public Registration.EducationalBg educationalBg1;
        public Registration.Consent consent1;
    }
}