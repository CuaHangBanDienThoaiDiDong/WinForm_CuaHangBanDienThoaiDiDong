using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm1.TopLevel = false;
            //this.panel3.Controls.Add(frm1);
            //frm1.Size = this.panel3.Size;  // Thiết lập kích thước của Form 2 bằng kích thước của Panel
            //frm1.Location = new System.Drawing.Point(0, 0);
            //frm1.Show();
        }
    }
}
