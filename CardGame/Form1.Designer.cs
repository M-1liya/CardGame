namespace CardGame
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
            this.HandDeckP1 = new System.Windows.Forms.ComboBox();
            this.HandDeckP2 = new System.Windows.Forms.ComboBox();
            this.ImageP1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoundСounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HandDeckP1
            // 
            this.HandDeckP1.FormattingEnabled = true;
            this.HandDeckP1.Location = new System.Drawing.Point(12, 204);
            this.HandDeckP1.Name = "HandDeckP1";
            this.HandDeckP1.Size = new System.Drawing.Size(164, 23);
            this.HandDeckP1.TabIndex = 1;
            // 
            // HandDeckP2
            // 
            this.HandDeckP2.FormattingEnabled = true;
            this.HandDeckP2.Location = new System.Drawing.Point(572, 204);
            this.HandDeckP2.Name = "HandDeckP2";
            this.HandDeckP2.Size = new System.Drawing.Size(164, 23);
            this.HandDeckP2.TabIndex = 2;
            // 
            // ImageP1
            // 
            this.ImageP1.Image = global::CardGame.Properties.Resources.p1;
            this.ImageP1.Location = new System.Drawing.Point(12, 102);
            this.ImageP1.Name = "ImageP1";
            this.ImageP1.Size = new System.Drawing.Size(85, 84);
            this.ImageP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageP1.TabIndex = 3;
            this.ImageP1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CardGame.Properties.Resources.p2;
            this.pictureBox1.Location = new System.Drawing.Point(651, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RoundСounter
            // 
            this.RoundСounter.AutoSize = true;
            this.RoundСounter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundСounter.Location = new System.Drawing.Point(359, 21);
            this.RoundСounter.Name = "RoundСounter";
            this.RoundСounter.Size = new System.Drawing.Size(57, 21);
            this.RoundСounter.TabIndex = 5;
            this.RoundСounter.Text = "Раунд ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 395);
            this.Controls.Add(this.RoundСounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImageP1);
            this.Controls.Add(this.HandDeckP2);
            this.Controls.Add(this.HandDeckP1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImageP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox HandDeckP1;
        private ComboBox HandDeckP2;
        private PictureBox ImageP1;
        private PictureBox pictureBox1;
        private Label RoundСounter;
    }
}