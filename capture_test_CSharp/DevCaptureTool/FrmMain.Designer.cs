namespace DevCaptureTool
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.labelEx1 = new IPlugins.LabelEx();
            this.sbox_ctrl_normal = new IPlugins.SwitchBox();
            this.sbox_alt_normal = new IPlugins.SwitchBox();
            this.sbox_shift_normal = new IPlugins.SwitchBox();
            this.tbx_normal = new IPlugins.TextBoxCu();
            this.btn_settiong = new IPlugins.ButtonEx();
            this.ckbox_autorun = new IPlugins.CheckBoxEx();
            this.ckbox_capcursor = new IPlugins.CheckBoxEx();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEx1
            // 
            this.labelEx1.BackColor = System.Drawing.Color.Transparent;
            this.labelEx1.ForeColor = System.Drawing.Color.Gray;
            this.labelEx1.Location = new System.Drawing.Point(37, 41);
            this.labelEx1.Name = "labelEx1";
            this.labelEx1.Size = new System.Drawing.Size(336, 17);
            this.labelEx1.TabIndex = 0;
            this.labelEx1.Text = "快捷键";
            // 
            // sbox_ctrl_normal
            // 
            this.sbox_ctrl_normal.BackColor = System.Drawing.Color.Transparent;
            this.sbox_ctrl_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbox_ctrl_normal.ForeColor = System.Drawing.Color.White;
            this.sbox_ctrl_normal.IsNO = false;
            this.sbox_ctrl_normal.Location = new System.Drawing.Point(40, 65);
            this.sbox_ctrl_normal.Name = "sbox_ctrl_normal";
            this.sbox_ctrl_normal.NOColor = System.Drawing.Color.DodgerBlue;
            this.sbox_ctrl_normal.NOText = "Ctrl";
            this.sbox_ctrl_normal.OFFColor = System.Drawing.Color.Gray;
            this.sbox_ctrl_normal.OFFText = "Ctrl";
            this.sbox_ctrl_normal.Size = new System.Drawing.Size(80, 21);
            this.sbox_ctrl_normal.TabIndex = 1;
            this.sbox_ctrl_normal.Text = "switchBox1";
            // 
            // sbox_alt_normal
            // 
            this.sbox_alt_normal.BackColor = System.Drawing.Color.Transparent;
            this.sbox_alt_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbox_alt_normal.ForeColor = System.Drawing.Color.White;
            this.sbox_alt_normal.IsNO = false;
            this.sbox_alt_normal.Location = new System.Drawing.Point(126, 65);
            this.sbox_alt_normal.Name = "sbox_alt_normal";
            this.sbox_alt_normal.NOColor = System.Drawing.Color.DodgerBlue;
            this.sbox_alt_normal.NOText = "Alt";
            this.sbox_alt_normal.OFFColor = System.Drawing.Color.Gray;
            this.sbox_alt_normal.OFFText = "Alt";
            this.sbox_alt_normal.Size = new System.Drawing.Size(80, 21);
            this.sbox_alt_normal.TabIndex = 2;
            this.sbox_alt_normal.Text = "switchBox2";
            // 
            // sbox_shift_normal
            // 
            this.sbox_shift_normal.BackColor = System.Drawing.Color.Transparent;
            this.sbox_shift_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbox_shift_normal.ForeColor = System.Drawing.Color.White;
            this.sbox_shift_normal.IsNO = false;
            this.sbox_shift_normal.Location = new System.Drawing.Point(212, 65);
            this.sbox_shift_normal.Name = "sbox_shift_normal";
            this.sbox_shift_normal.NOColor = System.Drawing.Color.DodgerBlue;
            this.sbox_shift_normal.NOText = "Shift";
            this.sbox_shift_normal.OFFColor = System.Drawing.Color.Gray;
            this.sbox_shift_normal.OFFText = "Shift";
            this.sbox_shift_normal.Size = new System.Drawing.Size(80, 21);
            this.sbox_shift_normal.TabIndex = 3;
            this.sbox_shift_normal.Text = "switchBox3";
            // 
            // tbx_normal
            // 
            this.tbx_normal.ForeColor = System.Drawing.Color.DimGray;
            this.tbx_normal.Location = new System.Drawing.Point(298, 65);
            this.tbx_normal.Name = "tbx_normal";
            this.tbx_normal.ReadOnly = true;
            this.tbx_normal.Size = new System.Drawing.Size(75, 21);
            this.tbx_normal.TabIndex = 4;
            this.tbx_normal.Text = "NULL";
            this.tbx_normal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // btn_settiong
            // 
            this.btn_settiong.BackColor = System.Drawing.Color.Transparent;
            this.btn_settiong.FlatAppearance.BorderSize = 0;
            this.btn_settiong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_settiong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_settiong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settiong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn_settiong.Location = new System.Drawing.Point(212, 110);
            this.btn_settiong.Name = "btn_settiong";
            this.btn_settiong.Size = new System.Drawing.Size(161, 42);
            this.btn_settiong.TabIndex = 20;
            this.btn_settiong.Text = "设置";
            this.btn_settiong.UseVisualStyleBackColor = false;
            this.btn_settiong.Click += new System.EventHandler(this.btn_settiing_Click);
            // 
            // ckbox_autorun
            // 
            this.ckbox_autorun.AutoSize = true;
            this.ckbox_autorun.BackColor = System.Drawing.Color.Transparent;
            this.ckbox_autorun.ForeColor = System.Drawing.Color.Gray;
            this.ckbox_autorun.Location = new System.Drawing.Point(40, 137);
            this.ckbox_autorun.Name = "ckbox_autorun";
            this.ckbox_autorun.Size = new System.Drawing.Size(72, 16);
            this.ckbox_autorun.TabIndex = 21;
            this.ckbox_autorun.Text = "开机启动";
            this.ckbox_autorun.UseVisualStyleBackColor = true;
            // 
            // ckbox_capcursor
            // 
            this.ckbox_capcursor.AutoSize = true;
            this.ckbox_capcursor.BackColor = System.Drawing.Color.Transparent;
            this.ckbox_capcursor.ForeColor = System.Drawing.Color.Gray;
            this.ckbox_capcursor.Location = new System.Drawing.Point(126, 137);
            this.ckbox_capcursor.Name = "ckbox_capcursor";
            this.ckbox_capcursor.Size = new System.Drawing.Size(72, 16);
            this.ckbox_capcursor.TabIndex = 22;
            this.ckbox_capcursor.Text = "捕获鼠标";
            this.ckbox_capcursor.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ScreenCapture";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 54);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 167);
            this.Controls.Add(this.ckbox_capcursor);
            this.Controls.Add(this.ckbox_autorun);
            this.Controls.Add(this.btn_settiong);
            this.Controls.Add(this.tbx_normal);
            this.Controls.Add(this.sbox_shift_normal);
            this.Controls.Add(this.sbox_alt_normal);
            this.Controls.Add(this.sbox_ctrl_normal);
            this.Controls.Add(this.labelEx1);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(2, 32, 2, 2);
            this.Text = "截图工具 by 李旭";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPlugins.LabelEx labelEx1;
        private IPlugins.SwitchBox sbox_ctrl_normal;
        private IPlugins.SwitchBox sbox_alt_normal;
        private IPlugins.SwitchBox sbox_shift_normal;
        private IPlugins.TextBoxCu tbx_normal;
        private IPlugins.ButtonEx btn_settiong;
        private IPlugins.CheckBoxEx ckbox_autorun;
        private IPlugins.CheckBoxEx ckbox_capcursor;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;



    }
}