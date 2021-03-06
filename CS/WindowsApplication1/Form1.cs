using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dockManager1.BeginInit();
            try
            {
                if (dockPanel1.Visibility == DockVisibility.Hidden)
                {
                    dockPanel1.Visibility = DockVisibility.AutoHide;
                }
                else
                    dockPanel1.Visibility = DockVisibility.Hidden;
            }
            finally
            {
                dockManager1.EndInit();
            }
        }
    }
}