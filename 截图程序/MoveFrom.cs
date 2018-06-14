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
        /// 主控件
        /// </summary>
        private Control Form { get; set; }

        /// <summary>
        /// 座标点
        /// </summary>
        private Point pt;

        /// <summary>
        /// 请在Load方法中调用
        /// 例子:
        /// 1=>sender传入panel,form传入null,则在窗体中只能拖动panel
        /// 2=>sender传入panel,form传入this(表示当前窗体),则在窗体中通过拖动panel来手动主窗体
        /// </summary>
        /// <param name="sender">要移动的当前控件</param>
        /// <param name="form">要被移动的控件</param>
        public MoveFrom(Control sender, Control form)
        {
            this.Form = form;
            //注册事件
            sender.MouseDown += new System.Windows.Forms.MouseEventHandler(sender_MouseDown);
            sender.MouseMove += new System.Windows.Forms.MouseEventHandler(sender_MouseMove);


        }

        private void sender_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            if (e.Button == MouseButtons.Left)
            {
                if (Form == null)
                {
                    LocationChange(c, e);

                }
                else
                {
                    LocationChange(Form, e);
                }
            }

        }

        private void LocationChange(Control c, MouseEventArgs e)
        {
            c.Location = new Point(c.Location.X + e.X - pt.X, c.Location.Y + e.Y - pt.Y);
        }

        private void sender_MouseDown(object sender, MouseEventArgs e)
        {
            pt = new Point(e.X, e.Y);
        }
    }
}
