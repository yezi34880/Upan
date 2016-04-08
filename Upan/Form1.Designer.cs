namespace Upan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbJPG = new System.Windows.Forms.CheckBox();
            this.cbTXT = new System.Windows.Forms.CheckBox();
            this.cbDOC = new System.Windows.Forms.CheckBox();
            this.cbPPT = new System.Windows.Forms.CheckBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtCopyPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJPG
            // 
            this.cbJPG.AutoSize = true;
            this.cbJPG.Checked = true;
            this.cbJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPG.Location = new System.Drawing.Point(33, 20);
            this.cbJPG.Name = "cbJPG";
            this.cbJPG.Size = new System.Drawing.Size(42, 16);
            this.cbJPG.TabIndex = 1;
            this.cbJPG.Text = "jpg";
            this.cbJPG.UseVisualStyleBackColor = true;
            // 
            // cbTXT
            // 
            this.cbTXT.AutoSize = true;
            this.cbTXT.Checked = true;
            this.cbTXT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTXT.Location = new System.Drawing.Point(130, 20);
            this.cbTXT.Name = "cbTXT";
            this.cbTXT.Size = new System.Drawing.Size(42, 16);
            this.cbTXT.TabIndex = 2;
            this.cbTXT.Text = "txt";
            this.cbTXT.UseVisualStyleBackColor = true;
            // 
            // cbDOC
            // 
            this.cbDOC.AutoSize = true;
            this.cbDOC.Checked = true;
            this.cbDOC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDOC.Location = new System.Drawing.Point(33, 54);
            this.cbDOC.Name = "cbDOC";
            this.cbDOC.Size = new System.Drawing.Size(42, 16);
            this.cbDOC.TabIndex = 3;
            this.cbDOC.Text = "doc";
            this.cbDOC.UseVisualStyleBackColor = true;
            // 
            // cbPPT
            // 
            this.cbPPT.AutoSize = true;
            this.cbPPT.Checked = true;
            this.cbPPT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPPT.Location = new System.Drawing.Point(130, 54);
            this.cbPPT.Name = "cbPPT";
            this.cbPPT.Size = new System.Drawing.Size(42, 16);
            this.cbPPT.TabIndex = 4;
            this.cbPPT.Text = "ppt";
            this.cbPPT.UseVisualStyleBackColor = true;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.cbPPT);
            this.gbType.Controls.Add(this.cbJPG);
            this.gbType.Controls.Add(this.cbDOC);
            this.gbType.Controls.Add(this.cbTXT);
            this.gbType.Location = new System.Drawing.Point(12, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(314, 85);
            this.gbType.TabIndex = 5;
            this.gbType.TabStop = false;
            this.gbType.Text = "复制格式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.txtCopyPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(6, 47);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtCopyPath
            // 
            this.txtCopyPath.Location = new System.Drawing.Point(6, 20);
            this.txtCopyPath.Name = "txtCopyPath";
            this.txtCopyPath.ReadOnly = true;
            this.txtCopyPath.Size = new System.Drawing.Size(302, 21);
            this.txtCopyPath.TabIndex = 0;
            this.txtCopyPath.Text = "C:\\\\Copy";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "U盘窃取";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "U盘窃取";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbJPG;
        private System.Windows.Forms.CheckBox cbTXT;
        private System.Windows.Forms.CheckBox cbDOC;
        private System.Windows.Forms.CheckBox cbPPT;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtCopyPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

