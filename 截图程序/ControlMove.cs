using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截图程序
{
    /// <summary>
    /// 控制鼠标移动类
    /// </summary>
    class ControlMove
    {
        /// <summary>
        /// 座标点
        /// </summary>
       private static Point pt;

        /// <summary>
        /// 鼠标按下时的座标点方法
        /// </summary>
        public static void MouseDown()
        {
            pt= Cursor.Position;
        }

        /// <summary>
        /// 鼠标移动时的座标点方法
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="e"></param>
        public static void MouseMove(Control sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                sender.Location = new Point(sender.Location.X + px, sender.Location.Y + py);

                pt = Cursor.Position;
            }
        }


    }
}
