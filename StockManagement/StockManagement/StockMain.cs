using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class StockMain : Form
    {        
        public StockMain()
        {
            InitializeComponent();

            List<string> colnames = new List<string> ();
            foreach (var item in Properties.Settings.Default.colnames)
            {
                colnames.Add(item);
            }            

            MdiClient ctlMDI;
            // Loop through all controls looking for the control of type MDIClient
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    if (ctl.GetType() == typeof(MdiClient))
                    {
                        // Attempt to cast the control to type MDIClient
                        ctlMDI = (MdiClient)ctl;

                        // Set the BackColor of the MDIClient Control
                        ctlMDI.BackColor = this.BackColor;
                        break;
                    }                    
                }
                catch (InvalidCastException)
                {
                    // Catch and ignore error if casting failed
                    //throw;
                }
            }

            //Process.Start("D:/Inventor Trials/WasteTray.ipt");
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = this.MdiChildren;

            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
                     
            /*
            if (child.Length != 0)
            {
                // Only one products form will be open at any one time
                foreach (var item in child)
                {
                    if (item.GetType() == typeof(Products))
                    {
                        item.Focus();
                        break;
                    }
                    else
                    {
                        Products pro = new Products();
                        pro.MdiParent = this;
                        pro.Show();
                        break;
                    }
                }
            }
            else
            {
                Products pro = new Products();
                pro.MdiParent = this;
                pro.Show();
            }   */                  
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
