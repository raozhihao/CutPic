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
    public partial class CutPic : Form
    {

        public event Action NormalMain;
        public CutPic()
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
            bit.Save(save.FileName,System.Drawing.Imaging.ImageFormat.Bmp);

            //截完图后,激活主窗体
            NormalMain?.Invoke();
            //关闭截图窗体
            this.Close();
        }


        private void CutPic_KeyDown(object sender, KeyEventArgs e)
        {
            ///按Esc后取消截图
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                NormalMain?.Invoke();
            }
        }

        private void CutPic_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CutPic_Load(object sender, EventArgs e)
        {
            //程序启动后,最大化
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
