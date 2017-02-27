namespace picfix
{
    partial class frmMain
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tslmIBatchFix = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmlIReduce = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(1048, 25);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "菜单导航";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslmIBatchFix});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(44, 21);
            this.tsmFile.Text = "文件";
            // 
            // tslmIBatchFix
            // 
            this.tslmIBatchFix.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmlIReduce});
            this.tslmIBatchFix.Name = "tslmIBatchFix";
            this.tslmIBatchFix.Size = new System.Drawing.Size(152, 22);
            this.tslmIBatchFix.Text = "批量处理";
            // 
            // tlmlIReduce
            // 
            this.tlmlIReduce.Name = "tlmlIReduce";
            this.tlmlIReduce.Size = new System.Drawing.Size(152, 22);
            this.tlmlIReduce.Text = "压缩";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 714);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tslmIBatchFix;
        private System.Windows.Forms.ToolStripMenuItem tlmlIReduce;
    }
}