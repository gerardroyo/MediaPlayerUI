using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customerDesign();
        }
        private void customerDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible)
            panelMediaSubMenu.Visible = false;

            if (panelPlaylistSubmenu.Visible)
                panelPlaylistSubmenu.Visible = false;

            if (panelToolsSubMenu.Visible)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }
#endregion

        private void btnPlaylistManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }
        #region PlaylistSubMenu

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }
#endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu

        private void button15_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }
#endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            // Code
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
