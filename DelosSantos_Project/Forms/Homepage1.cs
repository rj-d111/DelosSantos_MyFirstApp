using DelosSantos_Project.CustomControls;
using DelosSantos_Project.Homepage;
using DelosSantos_Project.Implementations;
using DelosSantos_Project.Implementations.Inherited;
using DelosSantos_Project.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project
{
    public partial class Homepage1 : Form, ISidePanel, IButtonWindow
    {
        private Color transparentDefault = Color.Transparent;
        private Color redHoveredClicked = Color.FromArgb(194, 44, 56);
        public Homepage1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.HoveredPart(basicInfoPanel, basicInfoLabel);
            //Apply Rounded Form
            RoundedForms.ApplyRoundedRegion(this, Width, Height, 20, 20);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            CloseHandler();

        }


        private void CenterPanel(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Location = new Point(
    this.ClientSize.Width / 2 - flowLayoutPanel.Size.Width / 2,
    this.ClientSize.Height / 2 - flowLayoutPanel.Size.Height / 2);
            flowLayoutPanel.Anchor = AnchorStyles.None;
        }
        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ResetColorAll()
        {
            basicInfoPanel.BackColor = transparentDefault;
            EducPanel.BackColor = transparentDefault;
            CoursesPanel.BackColor = transparentDefault;
            ContactPanel.BackColor = transparentDefault;            
        } 
    

        public void HoveredPart(Panel panel, Label label)
        {
            panel.BackColor = redHoveredClicked;
           
            Point currentLocation = sidePanel.Location;

            int panelX = panel.Location.X;
            int panelY = panel.Location.Y;

            sidePanel.Location = new Point(panelX, panelY);
        }


        private void Panel_MouseEvent(object sender, EventArgs e, Panel panel, Label label, Control control)
        {
            this.ResetColorAll();
            this.HoveredPart(panel, label);
            control.BringToFront();
        }


        private void EducPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_MouseEvent(sender, e , EducPanel, educLabel, educationalBackground1);

        }

        private void basicInfoPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_MouseEvent(sender, e, basicInfoPanel, basicInfoLabel, basicInfo1);

        }

        private void CoursesPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_MouseEvent(sender, e, CoursesPanel, coursesLabel, offeredCourses1);

        }

        private void ContactPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_MouseEvent(sender, e , ContactPanel, contactLabel, contact1);
        }

        public void ClickedPart(Panel panel, Label label)
        {
            this.ResetColorAll();
            this.HoveredPart(ContactPanel, contactLabel);
        }

        private void basicInfoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Panel_MouseEvent(sender, e, basicInfoPanel, basicInfoLabel, basicInfo1);
        }

        private void EducPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Panel_MouseEvent(sender, e, EducPanel, educLabel, educationalBackground1);
        }

        private void ContactPanel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Panel_MouseEvent(sender, e , ContactPanel, contactLabel, contact1);

        }

        private void ContactPanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CloseHandler()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Message", MessageBoxButtons.YesNo);

            // If the user clicked Yes, quit the application.
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void EducPanel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void EducPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            this.Hide();
        }
    }

}
