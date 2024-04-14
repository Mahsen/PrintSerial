namespace PrintSerial
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
            this.Close = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(6, 131);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(113, 131);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 3;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.UseWaitCursor = true;
            this.Print.Click += new System.EventHandler(this.button2_Click);
            // 
            // Box
            // 
            this.Box.Image = global::PrintSerial.Properties.Resources.lable;
            this.Box.Location = new System.Drawing.Point(17, 19);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(132, 100);
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            this.Box.Click += new System.EventHandler(this.Box_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box);
            this.groupBox1.Controls.Add(this.Close);
            this.groupBox1.Controls.Add(this.Print);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 202);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PrintSerial";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

