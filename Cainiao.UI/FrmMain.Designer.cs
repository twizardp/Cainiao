using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cainiao.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站点信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnStation = new System.Windows.Forms.ToolStripButton();
            this.toolBtnShelves = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnEmp = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExpress = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnDistribute = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSelfPick = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 75);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("霞鹜文楷 GB Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(1377, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "admin，早上好！";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("霞鹜文楷 GB Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜鸟驿站管理系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1538, 47);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.站点信息ToolStripMenuItem});
            this.基础信息维护ToolStripMenuItem.Font = new System.Drawing.Font("霞鹜文楷 GB Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础信息维护ToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(215, 43);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护(&B)";
            // 
            // 站点信息ToolStripMenuItem
            // 
            this.站点信息ToolStripMenuItem.Font = new System.Drawing.Font("霞鹜文楷 GB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.站点信息ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.站点信息ToolStripMenuItem.Name = "站点信息ToolStripMenuItem";
            this.站点信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.站点信息ToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.站点信息ToolStripMenuItem.Text = "站点信息";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnStation,
            this.toolBtnShelves,
            this.toolStripSeparator1,
            this.toolBtnEmp,
            this.toolBtnExpress,
            this.toolStripSeparator2,
            this.toolBtnDistribute,
            this.toolBtnSelfPick});
            this.toolStrip1.Location = new System.Drawing.Point(0, 122);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1538, 36);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnStation
            // 
            this.toolBtnStation.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnStation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnStation.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnStation.Image")));
            this.toolBtnStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnStation.Name = "toolBtnStation";
            this.toolBtnStation.Size = new System.Drawing.Size(124, 31);
            this.toolBtnStation.Text = "站点信息";
            this.toolBtnStation.ToolTipText = "站点信息";
            // 
            // toolBtnShelves
            // 
            this.toolBtnShelves.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnShelves.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnShelves.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShelves.Image")));
            this.toolBtnShelves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnShelves.Name = "toolBtnShelves";
            this.toolBtnShelves.Size = new System.Drawing.Size(124, 31);
            this.toolBtnShelves.Text = "货架信息";
            this.toolBtnShelves.ToolTipText = "站点信息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolBtnEmp
            // 
            this.toolBtnEmp.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnEmp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnEmp.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnEmp.Image")));
            this.toolBtnEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEmp.Margin = new System.Windows.Forms.Padding(5, 2, 0, 3);
            this.toolBtnEmp.Name = "toolBtnEmp";
            this.toolBtnEmp.Size = new System.Drawing.Size(124, 31);
            this.toolBtnEmp.Text = "员工信息";
            this.toolBtnEmp.ToolTipText = "站点信息";
            // 
            // toolBtnExpress
            // 
            this.toolBtnExpress.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnExpress.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnExpress.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnExpress.Image")));
            this.toolBtnExpress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExpress.Name = "toolBtnExpress";
            this.toolBtnExpress.Size = new System.Drawing.Size(124, 31);
            this.toolBtnExpress.Text = "快递信息";
            this.toolBtnExpress.ToolTipText = "站点信息";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolBtnDistribute
            // 
            this.toolBtnDistribute.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnDistribute.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnDistribute.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDistribute.Image")));
            this.toolBtnDistribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDistribute.Margin = new System.Windows.Forms.Padding(5, 2, 0, 3);
            this.toolBtnDistribute.Name = "toolBtnDistribute";
            this.toolBtnDistribute.Size = new System.Drawing.Size(124, 31);
            this.toolBtnDistribute.Text = "派送管理";
            this.toolBtnDistribute.ToolTipText = "站点信息";
            // 
            // toolBtnSelfPick
            // 
            this.toolBtnSelfPick.Font = new System.Drawing.Font("霞鹜文楷 GB", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnSelfPick.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolBtnSelfPick.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSelfPick.Image")));
            this.toolBtnSelfPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSelfPick.Name = "toolBtnSelfPick";
            this.toolBtnSelfPick.Size = new System.Drawing.Size(124, 31);
            this.toolBtnSelfPick.Text = "快递自提";
            this.toolBtnSelfPick.ToolTipText = "站点信息";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 858);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1538, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 25);
            this.toolStripStatusLabel1.Text = "当前时间";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(198, 25);
            this.toolStripStatusLabel2.Text = "2024-11-11 20:10:34";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(10, 4, 0, 3);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(88, 25);
            this.toolStripStatusLabel3.Text = "当前操作";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(50, 25);
            this.toolStripStatusLabel4.Text = "首页";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(1001, 25);
            this.toolStripStatusLabel5.Spring = true;
            this.toolStripStatusLabel5.Text = "     ";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(88, 25);
            this.toolStripStatusLabel6.Text = "版权所有";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1538, 694);
            this.tabControl1.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 890);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "菜鸟驿站管理系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;

        private System.Windows.Forms.ToolStripMenuItem 站点信息ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnStation;
        private ToolStripButton toolBtnShelves;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolBtnEmp;
        private ToolStripButton toolBtnExpress;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolBtnDistribute;
        private ToolStripButton toolBtnSelfPick;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private TabControl tabControl1;
    }
}