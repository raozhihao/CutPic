using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截图程序
{
    class MoveFrom
    {
        /// <summary>
        /// 座标点
        /// </summary>
        private static Point pt;
        public MoveFrom(Control sender)
        {
            //注册事件
            sender.MouseDown += new System.Windows.Forms.MouseEventHandler(CutPic_MouseDown);
            sender.MouseMove += new System.Windows.Forms.MouseEventHandler(CutPic_MouseMove);
        }

        private void CutPic_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                c.Location = new Point(c.Location.X + px, c.Location.Y + py);

                pt = Cursor.Position;
            }

        }

        private void CutPic_MouseDown(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
          
        }
    }
}
