
namespace time
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
            this.lbl_servertime = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_servertime
            // 
            this.lbl_servertime.AutoSize = true;
            this.lbl_servertime.Location = new System.Drawing.Point(84, 58);
            this.lbl_servertime.Name = "lbl_servertime";
            this.lbl_servertime.Size = new System.Drawing.Size(46, 17);
            this.lbl_servertime.TabIndex = 0;
            this.lbl_servertime.Text = "label1";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(87, 117);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "button1";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.lbl_servertime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_servertime;
        private System.Windows.Forms.Button btnTime;
    }
}

