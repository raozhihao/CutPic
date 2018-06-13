using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截图程序
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Point pt;
        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
        }

        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                this.Location = new Point(this.Location.X + px, this.Location.Y + py);

                pt = Cursor.Position;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CutPic s = new 截图程序.CutPic();
            s.NormalMain += S_NormalMain;
            s.Show();
            this.Focus();
        }

        private void S_NormalMain()
        {
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按下ESC取消截图
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
