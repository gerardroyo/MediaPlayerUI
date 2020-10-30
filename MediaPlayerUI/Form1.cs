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

        private void button2_Click(object sender, EventArgs e)
        {
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
    }
}
