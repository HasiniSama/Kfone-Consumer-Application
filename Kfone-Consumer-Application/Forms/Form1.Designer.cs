
namespace Kfone_Consumer_Application
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.servicesButton = new Kfone_Consumer_Application.Component.CardButton();
            this.devicesButton = new Kfone_Consumer_Application.Component.CardButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(503, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "SignIn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(618, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button5.Location = new System.Drawing.Point(667, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(307, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "My KFONE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(312, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "PLATINUM";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button7.Location = new System.Drawing.Point(505, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "Hi Gastro!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.BackColor = System.Drawing.Color.White;
            this.servicesButton.BackgorundColor = System.Drawing.Color.White;
            this.servicesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.servicesButton.BorderRadius = 25F;
            this.servicesButton.BorderSize = 2;
            this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.servicesButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.servicesButton.Location = new System.Drawing.Point(186, 133);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(165, 50);
            this.servicesButton.TabIndex = 10;
            this.servicesButton.Text = "Services";
            this.servicesButton.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.servicesButton.UseVisualStyleBackColor = false;
            // 
            // devicesButton
            // 
            this.devicesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.devicesButton.BackgorundColor = System.Drawing.Color.WhiteSmoke;
            this.devicesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.devicesButton.BorderRadius = 25F;
            this.devicesButton.BorderSize = 2;
            this.devicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.devicesButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.devicesButton.Location = new System.Drawing.Point(15, 133);
            this.devicesButton.Name = "devicesButton";
            this.devicesButton.Size = new System.Drawing.Size(160, 50);
            this.devicesButton.TabIndex = 9;
            this.devicesButton.Text = "Devices";
            this.devicesButton.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.devicesButton.UseVisualStyleBackColor = false;
            this.devicesButton.Click += new System.EventHandler(this.cardButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.devicesButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private Component.CardButton devicesButton;
        private Component.CardButton servicesButton;
    }
}

