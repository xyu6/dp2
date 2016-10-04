﻿namespace DigitalPlatform.Drawing
{
    partial class CameraClipDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraClipDialog));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_getAndClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_shoot = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ratate = new System.Windows.Forms.ToolStripButton();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_preview = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage_clip = new System.Windows.Forms.TabPage();
            this.tabPage_result = new System.Windows.Forms.TabPage();
            this.toolStripButton_clip_output = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_clip_autoCorp = new System.Windows.Forms.ToolStripButton();
            this.pictureBox_result = new System.Windows.Forms.PictureBox();
            this.pictureBox_clip = new DigitalPlatform.Drawing.ClipControl();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_preview.SuspendLayout();
            this.tabPage_clip.SuspendLayout();
            this.tabPage_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clip)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_getAndClose,
            this.toolStripButton_shoot,
            this.toolStripSeparator1,
            this.toolStripButton_clip_autoCorp,
            this.toolStripButton_clip_output,
            this.toolStripSeparator2,
            this.toolStripButton_ratate,
            this.toolStripButton_copy,
            this.toolStripButton_paste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 253);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(549, 29);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_getAndClose
            // 
            this.toolStripButton_getAndClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_getAndClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_getAndClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton_getAndClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_getAndClose.Image")));
            this.toolStripButton_getAndClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_getAndClose.Name = "toolStripButton_getAndClose";
            this.toolStripButton_getAndClose.Size = new System.Drawing.Size(78, 26);
            this.toolStripButton_getAndClose.Text = "获取图像";
            this.toolStripButton_getAndClose.ToolTipText = "获取图像，自动关闭对话框";
            this.toolStripButton_getAndClose.Click += new System.EventHandler(this.toolStripButton_getAndClose_Click);
            // 
            // toolStripButton_shoot
            // 
            this.toolStripButton_shoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_shoot.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_shoot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_shoot.Image")));
            this.toolStripButton_shoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_shoot.Name = "toolStripButton_shoot";
            this.toolStripButton_shoot.Size = new System.Drawing.Size(46, 26);
            this.toolStripButton_shoot.Text = "截图";
            this.toolStripButton_shoot.Click += new System.EventHandler(this.toolStripButton_shoot_Click);
            // 
            // toolStripButton_ratate
            // 
            this.toolStripButton_ratate.Enabled = false;
            this.toolStripButton_ratate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ratate.Image")));
            this.toolStripButton_ratate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ratate.Name = "toolStripButton_ratate";
            this.toolStripButton_ratate.Size = new System.Drawing.Size(52, 26);
            this.toolStripButton_ratate.Text = "旋转";
            this.toolStripButton_ratate.ToolTipText = "顺指针旋转 90 度 (冻结时可用)";
            this.toolStripButton_ratate.Click += new System.EventHandler(this.toolStripButton_ratate_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_preview);
            this.tabControl_main.Controls.Add(this.tabPage_clip);
            this.tabControl_main.Controls.Add(this.tabPage_result);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(549, 253);
            this.tabControl_main.TabIndex = 5;
            this.tabControl_main.SelectedIndexChanged += new System.EventHandler(this.tabControl_main_SelectedIndexChanged);
            // 
            // tabPage_preview
            // 
            this.tabPage_preview.Controls.Add(this.panel1);
            this.tabPage_preview.Location = new System.Drawing.Point(4, 22);
            this.tabPage_preview.Name = "tabPage_preview";
            this.tabPage_preview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_preview.Size = new System.Drawing.Size(541, 227);
            this.tabPage_preview.TabIndex = 0;
            this.tabPage_preview.Text = "预览";
            this.tabPage_preview.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 221);
            this.panel1.TabIndex = 1;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // tabPage_clip
            // 
            this.tabPage_clip.Controls.Add(this.pictureBox_clip);
            this.tabPage_clip.Location = new System.Drawing.Point(4, 22);
            this.tabPage_clip.Name = "tabPage_clip";
            this.tabPage_clip.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_clip.Size = new System.Drawing.Size(541, 227);
            this.tabPage_clip.TabIndex = 1;
            this.tabPage_clip.Text = "裁切";
            this.tabPage_clip.UseVisualStyleBackColor = true;
            // 
            // tabPage_result
            // 
            this.tabPage_result.Controls.Add(this.pictureBox_result);
            this.tabPage_result.Location = new System.Drawing.Point(4, 22);
            this.tabPage_result.Name = "tabPage_result";
            this.tabPage_result.Size = new System.Drawing.Size(541, 227);
            this.tabPage_result.TabIndex = 2;
            this.tabPage_result.Text = "结果";
            this.tabPage_result.UseVisualStyleBackColor = true;
            // 
            // toolStripButton_clip_output
            // 
            this.toolStripButton_clip_output.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_clip_output.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_clip_output.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_clip_output.Image")));
            this.toolStripButton_clip_output.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_clip_output.Name = "toolStripButton_clip_output";
            this.toolStripButton_clip_output.Size = new System.Drawing.Size(46, 26);
            this.toolStripButton_clip_output.Text = "输出";
            this.toolStripButton_clip_output.Click += new System.EventHandler(this.toolStripButton_clip_output_Click);
            // 
            // toolStripButton_clip_autoCorp
            // 
            this.toolStripButton_clip_autoCorp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_clip_autoCorp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_clip_autoCorp.Image")));
            this.toolStripButton_clip_autoCorp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_clip_autoCorp.Name = "toolStripButton_clip_autoCorp";
            this.toolStripButton_clip_autoCorp.Size = new System.Drawing.Size(36, 26);
            this.toolStripButton_clip_autoCorp.Text = "探边";
            this.toolStripButton_clip_autoCorp.Click += new System.EventHandler(this.toolStripButton_clip_autoCorp_Click);
            // 
            // pictureBox_result
            // 
            this.pictureBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_result.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_result.Name = "pictureBox_result";
            this.pictureBox_result.Size = new System.Drawing.Size(541, 227);
            this.pictureBox_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_result.TabIndex = 1;
            this.pictureBox_result.TabStop = false;
            // 
            // pictureBox_clip
            // 
            this.pictureBox_clip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_clip.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_clip.Name = "pictureBox_clip";
            this.pictureBox_clip.Size = new System.Drawing.Size(535, 221);
            this.pictureBox_clip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_clip.TabIndex = 1;
            this.pictureBox_clip.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_copy.Image")));
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(36, 26);
            this.toolStripButton_copy.Text = "复制";
            this.toolStripButton_copy.Click += new System.EventHandler(this.toolStripButton_copy_Click);
            // 
            // toolStripButton_paste
            // 
            this.toolStripButton_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_paste.Image")));
            this.toolStripButton_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_paste.Name = "toolStripButton_paste";
            this.toolStripButton_paste.Size = new System.Drawing.Size(36, 26);
            this.toolStripButton_paste.Text = "粘贴";
            this.toolStripButton_paste.Click += new System.EventHandler(this.toolStripButton_paste_Click);
            // 
            // CameraClipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 282);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CameraClipDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "从摄像头获取图像";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraClipDialog_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraClipDialog_FormClosed);
            this.Load += new System.EventHandler(this.CameraClipDialog_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_preview.ResumeLayout(false);
            this.tabPage_clip.ResumeLayout(false);
            this.tabPage_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_getAndClose;
        private System.Windows.Forms.ToolStripButton toolStripButton_shoot;
        private System.Windows.Forms.ToolStripButton toolStripButton_ratate;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_preview;
        private System.Windows.Forms.TabPage tabPage_clip;
        private System.Windows.Forms.TabPage tabPage_result;
        private System.Windows.Forms.Panel panel1;
        private ClipControl pictureBox_clip;
        private System.Windows.Forms.ToolStripButton toolStripButton_clip_output;
        private System.Windows.Forms.ToolStripButton toolStripButton_clip_autoCorp;
        private System.Windows.Forms.PictureBox pictureBox_result;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_paste;
    }
}