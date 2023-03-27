
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
            this.cardButton1 = new Kfone_Consumer_Application.Component.CardButton();
            this.cardPanel1 = new Kfone_Consumer_Application.Component.CardPanel();
            this.cardPanel2 = new Kfone_Consumer_Application.Component.CardPanel();
            this.cardPanel1.SuspendLayout();
            this.cardPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardButton1
            // 
            this.cardButton1.BackColor = System.Drawing.Color.White;
            this.cardButton1.BackgorundColor = System.Drawing.Color.White;
            this.cardButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.cardButton1.BorderRadius = 50F;
            this.cardButton1.BorderSize = 2;
            this.cardButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardButton1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cardButton1.Location = new System.Drawing.Point(38, 301);
            this.cardButton1.Name = "cardButton1";
            this.cardButton1.Size = new System.Drawing.Size(200, 50);
            this.cardButton1.TabIndex = 0;
            this.cardButton1.Text = "View";
            this.cardButton1.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.cardButton1.UseVisualStyleBackColor = false;
            this.cardButton1.Click += new System.EventHandler(this.cardButton1_Click);
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
            // Product_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.cardPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Product_Card";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(300, 400);
            this.Load += new System.EventHandler(this.Product_Card_Load);
            this.cardPanel1.ResumeLayout(false);
            this.cardPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Component.CardPanel cardPanel1;
        private Component.CardButton cardButton1;
        private Component.CardPanel cardPanel2;
    }
}
