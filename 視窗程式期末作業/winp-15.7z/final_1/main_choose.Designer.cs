namespace final_1
{
    partial class main_choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_choose));
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
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選單ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.ms1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(407, 24);
            this.ms1.TabIndex = 22;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 458);
            this.Controls.Add(this.ms1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "極光塔";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem 選單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回主畫面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 簡介ToolStripMenuItem;




    }
}