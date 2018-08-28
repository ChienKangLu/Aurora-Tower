namespace final_1
{
    partial class bag
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bag));
            this.im1 = new System.Windows.Forms.ImageList(this.components);
            this.card_panel = new System.Windows.Forms.Panel();
            this.l1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // im1
            // 
            this.im1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("im1.ImageStream")));
            this.im1.TransparentColor = System.Drawing.Color.Transparent;
            this.im1.Images.SetKeyName(0, "m1.png");
            this.im1.Images.SetKeyName(1, "image106.gif");
            this.im1.Images.SetKeyName(2, "p1.png");
            this.im1.Images.SetKeyName(3, "p2.png");
            this.im1.Images.SetKeyName(4, "p3.gif");
            this.im1.Images.SetKeyName(5, "p4.gif");
            this.im1.Images.SetKeyName(6, "p5.gif");
            this.im1.Images.SetKeyName(7, "p6.png");
            this.im1.Images.SetKeyName(8, "p7.png");
            this.im1.Images.SetKeyName(9, "p8.png");
            this.im1.Images.SetKeyName(10, "p9.gif");
            this.im1.Images.SetKeyName(11, "p10.gif");
            // 
            // card_panel
            // 
            this.card_panel.AutoScroll = true;
            this.card_panel.BackColor = System.Drawing.Color.Transparent;
            this.card_panel.Location = new System.Drawing.Point(18, 68);
            this.card_panel.Name = "card_panel";
            this.card_panel.Size = new System.Drawing.Size(298, 207);
            this.card_panel.TabIndex = 0;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("超研澤海報體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(108, 12);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(118, 48);
            this.l1.TabIndex = 2;
            this.l1.Text = "背包";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回主畫面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.card_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "極光塔";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList im1;
        private System.Windows.Forms.Panel card_panel;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button1;
    }
}