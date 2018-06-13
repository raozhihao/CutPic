using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 截图程序
{
    public partial class CutMain : Form
    {

        public event Action NormalMain;
        public CutMain()
        {
            InitializeComponent();
        }

        private void CutPic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            //开始截图

            //设置窗体的透明度为0
             this.Opacity = 0;
            //构造图片
            Bitmap bit = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bit);
            //截取背景图
            g.CopyFromScreen(this.Location, new Point(0, 0), bit.Size);
            SaveFileDialog save = new SaveFileDialog();
            //打开保存
            save.ShowDialog();
            bit.Save(save.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);

            //截完图后,激活主窗体
            NormalMain?.Invoke();
            //关闭截图窗体
            this.Close();
        }

        /// <summary>
        /// 键盘按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutPic_KeyDown(object sender, KeyEventArgs e)
        {
            ///按Esc后取消截图
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                ///使主窗体显示出来
                NormalMain?.Invoke();
            }
        }

       
       
        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutPic_MouseDown(object sender, MouseEventArgs e)
        {
            ControlMove.MouseDown();
        }
        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutPic_MouseMove(object sender, MouseEventArgs e)
        {
            ControlMove.MouseMove(this,e);
        }

    }
}
