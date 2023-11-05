using DelosSantos_Project.CustomControls;
using DelosSantos_Project.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Forms
{
    public partial class DisplayForm : Form, IButtonWindow
    {
        private Color transparentDefault = Color.Transparent;
        private Color redHoveredClicked = Color.FromArgb(194, 44, 56);
        public DisplayForm()
        {
            InitializeComponent();
            //Apply Rounded Form
            RoundedForms.ApplyRoundedRegion(this, Width, Height, 20, 20);
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboard21_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            CloseHandler();
        }

        public void CloseHandler()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?","Log Out",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Homepage1 homepage1 = new Homepage1();
                homepage1.Show();
                this.Hide();
            }
        }

        private void transparentBackgroundTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CloseHandler();
        }

        public void ResetColorAll()
        {
            pnl_Dashboard.BackColor = transparentDefault;
            pnl_Community.BackColor = transparentDefault;
            pnl_Career.BackColor = transparentDefault;
        }


        public void HoveredPart(Panel panel)
        {
            panel.BackColor = redHoveredClicked;

            Point currentLocation = sidePanel.Location;

            int panelX = panel.Location.X;
            int panelY = panel.Location.Y;

            sidePanel.Location = new Point(panelX, panelY);
        }

        private void Panel_MouseEvent(object sender, EventArgs e, Panel panel, Control control)
        {
            this.ResetColorAll();
            this.HoveredPart(panel);
            control.BringToFront();
        }

        private void pnl_Community_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_MouseEvent(this, e, pnl_Community,community1);
        }

        private void pnl_Community_MouseEnter(object sender, EventArgs e)
        {
            Panel_MouseEvent(this, e, pnl_Community,community1);

        }

       

        //Dashboard
        private void pnl_Dashboard_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_MouseEvent(this, e, pnl_Dashboard, dashboard1);
        }

        private void pnl_Dashboard_MouseEnter(object sender, EventArgs e)
        {
            Panel_MouseEvent(this, e, pnl_Dashboard, dashboard1);

        }

       


        //Career
        private void pnl_Career_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_MouseEvent(this, e,pnl_Career, careerSupport1);

        }

        private void pnl_Career_MouseEnter(object sender, EventArgs e)
        {
            Panel_MouseEvent(this, e,pnl_Career, careerSupport1);

        }

       
    }
}
