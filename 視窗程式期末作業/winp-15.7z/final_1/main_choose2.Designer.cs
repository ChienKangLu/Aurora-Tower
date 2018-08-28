namespace final_1
{
    partial class main_choose2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_choose2));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("超研澤海報體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l1.Location = new System.Drawing.Point(32, 147);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(342, 47);
            this.l1.TabIndex = 0;
            this.l1.Text = "label1";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("超研澤海報體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l2.Location = new System.Drawing.Point(32, 221);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(342, 47);
            this.l2.TabIndex = 0;
            this.l2.Text = "label1";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l2.Click += new System.EventHandler(this.l1_Click);
            // 
            // l11
            // 
            this.l11.BackColor = System.Drawing.Color.Transparent;
            this.l11.Font = new System.Drawing.Font("超研澤海報體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l11.Location = new System.Drawing.Point(32, 300);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(342, 47);
            this.l11.TabIndex = 0;
            this.l11.Text = "label1";
            this.l11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l11.Click += new System.EventHandler(this.l1_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(274, 396);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "回上一頁";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // main_choose2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 458);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.l11);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_choose2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_choose2";
            this.Load += new System.EventHandler(this.l3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Button b1;
    }
}