﻿namespace DevCapture
{
    partial class CaptureToolbar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ok = new DevCapture.CaptureToolButton();
            this.btn_close = new DevCapture.CaptureToolButton();
            this.btn_save = new DevCapture.CaptureToolButton();
            this.btn_out = new DevCapture.CaptureToolButton();
            this.btn_cancel = new DevCapture.CaptureToolButton();
            this.btn_text = new DevCapture.CaptureToolButton();
            this.btn_brush = new DevCapture.CaptureToolButton();
            this.btn_arrow = new DevCapture.CaptureToolButton();
            this.btn_elips = new DevCapture.CaptureToolButton();
            this.btn_rect = new DevCapture.CaptureToolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DevCapture.Properties.Resources.separator;
            this.pictureBox2.Location = new System.Drawing.Point(339, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevCapture.Properties.Resources.separator;
            this.pictureBox1.Location = new System.Drawing.Point(199, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = global::DevCapture.Properties.Resources.btn_ok;
            this.btn_ok.IsCheckButton = false;
            this.btn_ok.IsRadioButton = false;
            this.btn_ok.IsSelected = false;
            this.btn_ok.Location = new System.Drawing.Point(416, 30);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(64, 35);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "完成";
            this.toolTip1.SetToolTip(this.btn_ok, "完成");
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::DevCapture.Properties.Resources.btn_close;
            this.btn_close.IsCheckButton = false;
            this.btn_close.IsRadioButton = false;
            this.btn_close.IsSelected = false;
            this.btn_close.Location = new System.Drawing.Point(346, 30);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 35);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "退出";
            this.toolTip1.SetToolTip(this.btn_close, "退出");
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Image = global::DevCapture.Properties.Resources.btn_save;
            this.btn_save.IsCheckButton = false;
            this.btn_save.IsRadioButton = false;
            this.btn_save.IsSelected = false;
            this.btn_save.Location = new System.Drawing.Point(286, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(35, 35);
            this.btn_save.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_save, "保存");
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.Transparent;
            this.btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_out.Image = global::DevCapture.Properties.Resources.btn_out;
            this.btn_out.IsCheckButton = false;
            this.btn_out.IsRadioButton = false;
            this.btn_out.IsSelected = false;
            this.btn_out.Location = new System.Drawing.Point(245, 30);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(35, 35);
            this.btn_out.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_out, "弹出");
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::DevCapture.Properties.Resources.btn_cancel;
            this.btn_cancel.IsCheckButton = false;
            this.btn_cancel.IsRadioButton = false;
            this.btn_cancel.IsSelected = false;
            this.btn_cancel.Location = new System.Drawing.Point(206, 30);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(35, 35);
            this.btn_cancel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_cancel, "撤销");
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Transparent;
            this.btn_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_text.Image = global::DevCapture.Properties.Resources.btn_text;
            this.btn_text.IsCheckButton = true;
            this.btn_text.IsRadioButton = false;
            this.btn_text.IsSelected = false;
            this.btn_text.Location = new System.Drawing.Point(158, 30);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(35, 35);
            this.btn_text.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_text, "文本");
            // 
            // btn_brush
            // 
            this.btn_brush.BackColor = System.Drawing.Color.Transparent;
            this.btn_brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brush.Image = global::DevCapture.Properties.Resources.btn_brush;
            this.btn_brush.IsCheckButton = true;
            this.btn_brush.IsRadioButton = false;
            this.btn_brush.IsSelected = false;
            this.btn_brush.Location = new System.Drawing.Point(117, 30);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(35, 35);
            this.btn_brush.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_brush, "画刷");
            // 
            // btn_arrow
            // 
            this.btn_arrow.BackColor = System.Drawing.Color.Transparent;
            this.btn_arrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arrow.Image = global::DevCapture.Properties.Resources.btn_arrow;
            this.btn_arrow.IsCheckButton = true;
            this.btn_arrow.IsRadioButton = false;
            this.btn_arrow.IsSelected = false;
            this.btn_arrow.Location = new System.Drawing.Point(77, 30);
            this.btn_arrow.Name = "btn_arrow";
            this.btn_arrow.Size = new System.Drawing.Size(35, 35);
            this.btn_arrow.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_arrow, "箭头");
            // 
            // btn_elips
            // 
            this.btn_elips.BackColor = System.Drawing.Color.Transparent;
            this.btn_elips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elips.Image = global::DevCapture.Properties.Resources.btn_ellips;
            this.btn_elips.IsCheckButton = true;
            this.btn_elips.IsRadioButton = false;
            this.btn_elips.IsSelected = false;
            this.btn_elips.Location = new System.Drawing.Point(41, 30);
            this.btn_elips.Name = "btn_elips";
            this.btn_elips.Size = new System.Drawing.Size(35, 35);
            this.btn_elips.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_elips, "圆形");
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.Transparent;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.Image = global::DevCapture.Properties.Resources.btn_rect;
            this.btn_rect.IsCheckButton = true;
            this.btn_rect.IsRadioButton = false;
            this.btn_rect.IsSelected = false;
            this.btn_rect.Location = new System.Drawing.Point(3, 30);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(15);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(35, 35);
            this.btn_rect.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_rect, "矩形");
            // 
            // CaptureToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.btn_brush);
            this.Controls.Add(this.btn_arrow);
            this.Controls.Add(this.btn_elips);
            this.Controls.Add(this.btn_rect);
            this.Name = "CaptureToolbar";
            this.Size = new System.Drawing.Size(507, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CaptureToolButton btn_rect;
        private CaptureToolButton btn_elips;
        private CaptureToolButton btn_arrow;
        private CaptureToolButton btn_brush;
        private CaptureToolButton btn_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CaptureToolButton btn_cancel;
        private CaptureToolButton btn_out;
        private CaptureToolButton btn_save;
        private CaptureToolButton btn_close;
        private CaptureToolButton btn_ok;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
