using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Menu_Item_ClickButton(object sender, EventArgs e)
        {
            TopLevelMenu.Text += " Hello Wicked world!! ";
        }

        private void Add_SubMenu_ClickButton(object sender, EventArgs e)
        {
            SubItem.Text += "5 + 7 + 9 = 21 ";
        }
    }
}
