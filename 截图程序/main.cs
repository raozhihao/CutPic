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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// 开始截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //打开截图容器
            CutMain s = new 截图程序.CutMain();
            //初始化事件
            s.NormalMain += S_NormalMain;
            
            s.Show();
            this.Focus();
        }

        /// <summary>
        /// 使主窗体恢复正常状态
        /// </summary>
        private void S_NormalMain()
        {
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

       
        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /// <summary>
       /// 最小化按钮
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MoveFrom m = new 截图程序.MoveFrom(this);
        }
    }
}
