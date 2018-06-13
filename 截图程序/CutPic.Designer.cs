namespace 截图程序
{
    partial class CutPic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutPic));
            this.SuspendLayout();
            // 
            // CutPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CutPic";
            this.Opacity = 0.3D;
            this.Text = "双击界面截图";
            this.Load += new System.EventHandler(this.CutPic_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CutPic_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CutPic_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CutPic_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}