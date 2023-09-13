namespace IdentifyVowelAndConsonant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            enterB = new Button();
            finderTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // enterB
            // 
            enterB.BackColor = SystemColors.ActiveCaption;
            enterB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enterB.Location = new Point(90, 208);
            enterB.Name = "enterB";
            enterB.Size = new Size(175, 35);
            enterB.TabIndex = 1;
            enterB.Text = "Enter";
            enterB.UseVisualStyleBackColor = false;
            enterB.Click += enterB_Click;
            // 
            // finderTB
            // 
            finderTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            finderTB.Location = new Point(112, 147);
            finderTB.MaxLength = 1;
            finderTB.Name = "finderTB";
            finderTB.Size = new Size(175, 33);
            finderTB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 505);
            Controls.Add(finderTB);
            Controls.Add(enterB);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button enterB;
        private TextBox finderTB;
    }
}