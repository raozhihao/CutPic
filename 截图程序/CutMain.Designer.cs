namespace 截图程序
{
    partial class CutMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutMain));
            this.SuspendLayout();
            // 
            // CutMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CutMain";
            this.Opacity = 0.4D;
            this.Text = "双击界面截图";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CutPic_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CutPic_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CutPic_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CutPic_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}