namespace DelosSantos_Project
{
    partial class Homepage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage1));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new DelosSantos_Project.CustomControls.GradientPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.contactLabel = new System.Windows.Forms.Label();
            this.CoursesPanel = new System.Windows.Forms.Panel();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.EducPanel = new System.Windows.Forms.Panel();
            this.educLabel = new System.Windows.Forms.Label();
            this.basicInfoPanel = new System.Windows.Forms.Panel();
            this.basicInfoLabel = new System.Windows.Forms.Label();
            this.basicInfo1 = new DelosSantos_Project.Homepage.BasicInfo();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.educationalBackground1 = new DelosSantos_Project.Homepage.EducationalBackground();
            this.offeredCourses1 = new DelosSantos_Project.Homepage.OfferedCourses();
            this.contact1 = new DelosSantos_Project.Homepage.Contact();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInButton = new DelosSantos_Project.CustomControls.RoundButton();
            this.panelContainer.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel8.SuspendLayout();
            this.ContactPanel.SuspendLayout();
            this.CoursesPanel.SuspendLayout();
            this.EducPanel.SuspendLayout();
            this.basicInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.SignInButton);
            this.panelContainer.Controls.Add(this.gradientPanel1);
            this.panelContainer.Controls.Add(this.basicInfo1);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.CloseButton);
            this.panelContainer.Controls.Add(this.educationalBackground1);
            this.panelContainer.Controls.Add(this.offeredCourses1);
            this.panelContainer.Controls.Add(this.contact1);
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint_1);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.panel6);
            this.gradientPanel1.Controls.Add(this.panel8);
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox7);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.sidePanel);
            this.panel8.Controls.Add(this.ContactPanel);
            this.panel8.Controls.Add(this.CoursesPanel);
            this.panel8.Controls.Add(this.EducPanel);
            this.panel8.Controls.Add(this.basicInfoPanel);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.Name = "sidePanel";
            // 
            // ContactPanel
            // 
            this.ContactPanel.Controls.Add(this.contactLabel);
            resources.ApplyResources(this.ContactPanel, "ContactPanel");
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.MouseEnter += new System.EventHandler(this.ContactPanel_MouseEnter);
            this.ContactPanel.MouseHover += new System.EventHandler(this.ContactPanel_MouseHover);
            // 
            // contactLabel
            // 
            resources.ApplyResources(this.contactLabel, "contactLabel");
            this.contactLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactLabel.ForeColor = System.Drawing.Color.White;
            this.contactLabel.Name = "contactLabel";
            // 
            // CoursesPanel
            // 
            this.CoursesPanel.Controls.Add(this.coursesLabel);
            resources.ApplyResources(this.CoursesPanel, "CoursesPanel");
            this.CoursesPanel.Name = "CoursesPanel";
            this.CoursesPanel.MouseEnter += new System.EventHandler(this.CoursesPanel_MouseEnter);
            // 
            // coursesLabel
            // 
            resources.ApplyResources(this.coursesLabel, "coursesLabel");
            this.coursesLabel.BackColor = System.Drawing.Color.Transparent;
            this.coursesLabel.ForeColor = System.Drawing.Color.White;
            this.coursesLabel.Name = "coursesLabel";
            // 
            // EducPanel
            // 
            this.EducPanel.Controls.Add(this.educLabel);
            resources.ApplyResources(this.EducPanel, "EducPanel");
            this.EducPanel.Name = "EducPanel";
            this.EducPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EducPanel_Paint);
            this.EducPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EducPanel_MouseClick);
            this.EducPanel.MouseEnter += new System.EventHandler(this.EducPanel_MouseEnter);
            this.EducPanel.MouseLeave += new System.EventHandler(this.EducPanel_MouseLeave);
            // 
            // educLabel
            // 
            resources.ApplyResources(this.educLabel, "educLabel");
            this.educLabel.BackColor = System.Drawing.Color.Transparent;
            this.educLabel.ForeColor = System.Drawing.Color.White;
            this.educLabel.Name = "educLabel";
            // 
            // basicInfoPanel
            // 
            this.basicInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.basicInfoPanel.Controls.Add(this.basicInfoLabel);
            resources.ApplyResources(this.basicInfoPanel, "basicInfoPanel");
            this.basicInfoPanel.Name = "basicInfoPanel";
            this.basicInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            this.basicInfoPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.basicInfoPanel_MouseClick);
            this.basicInfoPanel.MouseEnter += new System.EventHandler(this.basicInfoPanel_MouseEnter);
            // 
            // basicInfoLabel
            // 
            resources.ApplyResources(this.basicInfoLabel, "basicInfoLabel");
            this.basicInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.basicInfoLabel.ForeColor = System.Drawing.Color.White;
            this.basicInfoLabel.Name = "basicInfoLabel";
            this.basicInfoLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // basicInfo1
            // 
            this.basicInfo1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.basicInfo1, "basicInfo1");
            this.basicInfo1.Name = "basicInfo1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(42)))));
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // educationalBackground1
            // 
            this.educationalBackground1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.educationalBackground1, "educationalBackground1");
            this.educationalBackground1.Name = "educationalBackground1";
            // 
            // offeredCourses1
            // 
            this.offeredCourses1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.offeredCourses1, "offeredCourses1");
            this.offeredCourses1.Name = "offeredCourses1";
            // 
            // contact1
            // 
            this.contact1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.contact1, "contact1");
            this.contact1.Name = "contact1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SignInButton.BackgroundColor = System.Drawing.Color.Empty;
            this.SignInButton.BorderColor = System.Drawing.Color.Transparent;
            this.SignInButton.BorderRadius = 20;
            this.SignInButton.borderSize = 0;
            resources.ApplyResources(this.SignInButton, "SignInButton");
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.TextColor = System.Drawing.Color.Empty;
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Homepage1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage1";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ContactPanel.ResumeLayout(false);
            this.ContactPanel.PerformLayout();
            this.CoursesPanel.ResumeLayout(false);
            this.CoursesPanel.PerformLayout();
            this.EducPanel.ResumeLayout(false);
            this.EducPanel.PerformLayout();
            this.basicInfoPanel.ResumeLayout(false);
            this.basicInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Homepage.BasicInfo basicInfo1;
        private Homepage.EducationalBackground educationalBackground1;
        private Homepage.OfferedCourses offeredCourses1;
        private Homepage.Contact contact1;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Panel CoursesPanel;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Panel EducPanel;
        private System.Windows.Forms.Label educLabel;
        private System.Windows.Forms.Panel basicInfoPanel;
        private System.Windows.Forms.Label basicInfoLabel;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundButton SignInButton;
    }
}

