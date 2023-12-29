using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Explorer_And_Menu
{
    public partial class Form1 : Form
    {
       
            public Form1()
            {
                InitializeComponent();
              
            }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            var folder = new FolderBrowserDialog();
            folder.ShowDialog();
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDisk.ShowDialog();
            //var folder = new FolderBrowserDialog();
            //folder.ShowDialog();
        }
    }
}

