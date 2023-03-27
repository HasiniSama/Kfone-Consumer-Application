
namespace Kfone_Consumer_Application.Controls
{
    partial class Product_Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Card));
            this.cardPanel1 = new Kfone_Consumer_Application.Component.CardPanel();
            this.cardPanel2 = new Kfone_Consumer_Application.Component.CardPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardButton1 = new Kfone_Consumer_Application.Component.CardButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardPanel1.SuspendLayout();
            this.cardPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPanel1
            // 
            this.cardPanel1.BackColor = System.Drawing.Color.White;
            this.cardPanel1.BorderRadius = 40;
            this.cardPanel1.Controls.Add(this.cardPanel2);
            this.cardPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel1.ForeColor = System.Drawing.Color.Black;
            this.cardPanel1.GradientAngle = 90F;
            this.cardPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.cardPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.cardPanel1.Location = new System.Drawing.Point(5, 5);
            this.cardPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.cardPanel1.Name = "cardPanel1";
            this.cardPanel1.Size = new System.Drawing.Size(290, 390);
            this.cardPanel1.TabIndex = 0;
            this.cardPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.cardPanel1_Paint);
            // 
            // cardPanel2
            // 
            this.cardPanel2.BackColor = System.Drawing.Color.White;
            this.cardPanel2.BorderRadius = 30;
            this.cardPanel2.Controls.Add(this.pictureBox2);
            this.cardPanel2.Controls.Add(this.pictureBox1);
            this.cardPanel2.Controls.Add(this.label2);
            this.cardPanel2.Controls.Add(this.label1);
            this.cardPanel2.Controls.Add(this.cardButton1);
            this.cardPanel2.ForeColor = System.Drawing.Color.Black;
            this.cardPanel2.GradientAngle = 90F;
            this.cardPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.cardPanel2.GradientTopColor = System.Drawing.Color.White;
            this.cardPanel2.Location = new System.Drawing.Point(8, 9);
            this.cardPanel2.Name = "cardPanel2";
            this.cardPanel2.Size = new System.Drawing.Size(274, 373);
            this.cardPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(38, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10F);
            this.label2.Location = new System.Drawing.Point(33, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "$799";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apple iPhone 13";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardButton1
            // 
            this.cardButton1.BackColor = System.Drawing.Color.White;
            this.cardButton1.BackgorundColor = System.Drawing.Color.White;
            this.cardButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.cardButton1.BorderRadius = 45F;
            this.cardButton1.BorderSize = 2;
            this.cardButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardButton1.Font = new System.Drawing.Font("Gadugi", 10F);
            this.cardButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.cardButton1.Location = new System.Drawing.Point(36, 300);
            this.cardButton1.Name = "cardButton1";
            this.cardButton1.Size = new System.Drawing.Size(200, 50);
            this.cardButton1.TabIndex = 0;
            this.cardButton1.Text = "Add to Cart";
            this.cardButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.cardButton1.UseVisualStyleBackColor = false;
            this.cardButton1.Click += new System.EventHandler(this.cardButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(211, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Product_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Product_Card";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(300, 400);
            this.Load += new System.EventHandler(this.Product_Card_Load);
            this.cardPanel1.ResumeLayout(false);
            this.cardPanel2.ResumeLayout(false);
            this.cardPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.CardPanel cardPanel1;
        private Component.CardPanel cardPanel2;
        private Component.CardButton cardButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
