namespace final_1
{
    partial class main_partner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_partner));
            this.title = new System.Windows.Forms.Label();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.選單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回主畫面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.簡介ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("超研澤海報體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(19, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 41);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選單ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.ms1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(274, 24);
            this.ms1.TabIndex = 23;
            this.ms1.Text = "menuStrip1";
            // 
            // 選單ToolStripMenuItem
            // 
            this.選單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主畫面ToolStripMenuItem});
            this.選單ToolStripMenuItem.Name = "選單ToolStripMenuItem";
            this.選單ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.選單ToolStripMenuItem.Text = "選單";
            // 
            // 返回主畫面ToolStripMenuItem
            // 
            this.返回主畫面ToolStripMenuItem.Name = "返回主畫面ToolStripMenuItem";
            this.返回主畫面ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.返回主畫面ToolStripMenuItem.Text = "返回主畫面";
            this.返回主畫面ToolStripMenuItem.Click += new System.EventHandler(this.返回主畫面ToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem,
            this.玩法ToolStripMenuItem,
            this.簡介ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.作者ToolStripMenuItem.Text = "作者";
            this.作者ToolStripMenuItem.Click += new System.EventHandler(this.作者ToolStripMenuItem_Click);
            // 
            // 玩法ToolStripMenuItem
            // 
            this.玩法ToolStripMenuItem.Name = "玩法ToolStripMenuItem";
            this.玩法ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.玩法ToolStripMenuItem.Text = "玩法";
            this.玩法ToolStripMenuItem.Click += new System.EventHandler(this.玩法ToolStripMenuItem_Click);
            // 
            // 簡介ToolStripMenuItem
            // 
            this.簡介ToolStripMenuItem.Name = "簡介ToolStripMenuItem";
            this.簡介ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.簡介ToolStripMenuItem.Text = "簡介";
            this.簡介ToolStripMenuItem.Click += new System.EventHandler(this.簡介ToolStripMenuItem_Click);
            // 
            // main_partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.ms1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_partner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "極光塔";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem 選單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回主畫面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 簡介ToolStripMenuItem;

    }
}