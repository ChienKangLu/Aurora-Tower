namespace final_1
{
    partial class main_round
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_round));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("超研澤海報體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l1.Location = new System.Drawing.Point(3, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(200, 23);
            this.l1.TabIndex = 0;
            this.l1.Text = "活火山的歷險";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l2.Location = new System.Drawing.Point(3, 44);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(200, 12);
            this.l2.TabIndex = 0;
            this.l2.Text = "炙熱岩漿的逆襲";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l3.Location = new System.Drawing.Point(3, 65);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(200, 12);
            this.l3.TabIndex = 0;
            this.l3.Text = "3/10";
            this.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l4
            // 
            this.l4.BackColor = System.Drawing.Color.Transparent;
            this.l4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l4.Location = new System.Drawing.Point(3, 86);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(200, 12);
            this.l4.TabIndex = 0;
            this.l4.Text = "150";
            this.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l4.Click += new System.EventHandler(this.l4_Click);
            // 
            // main_round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(204, 108);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_round";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "關卡資訊";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
    }
}