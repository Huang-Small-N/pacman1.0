namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            Picman = new PictureBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            coin1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Picman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            SuspendLayout();
            // 
            // Picman
            // 
            Picman.BackColor = SystemColors.ActiveCaptionText;
            Picman.Image = Properties.Resources.pacmanup;
            Picman.Location = new Point(194, 202);
            Picman.Name = "Picman";
            Picman.Size = new Size(48, 35);
            Picman.SizeMode = PictureBoxSizeMode.Zoom;
            Picman.TabIndex = 0;
            Picman.TabStop = false;
            Picman.Click += Picman_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(10, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 350);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 11);
            label1.Name = "label1";
            label1.Size = new Size(122, 44);
            label1.TabIndex = 2;
            label1.Text = "Score:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(658, 34);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // coin1
            // 
            coin1.BackColor = SystemColors.ActiveCaptionText;
            coin1.BackgroundImageLayout = ImageLayout.Zoom;
            coin1.Image = Properties.Resources.dollar;
            coin1.Location = new Point(181, 124);
            coin1.Name = "coin1";
            coin1.Size = new Size(25, 22);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 4;
            coin1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(coin1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Picman);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Picman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Picman;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private PictureBox coin1;
    }
}