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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HandDeckP1 = new System.Windows.Forms.ComboBox();
            this.HandDeckP2 = new System.Windows.Forms.ComboBox();
            this.ImageP1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoundСounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeroesOnTheFieldP1 = new System.Windows.Forms.ComboBox();
            this.HeroesOnTheFieldP2 = new System.Windows.Forms.ComboBox();
            this.DropOnTheFieldButtonP1 = new System.Windows.Forms.Button();
            this.DropOnTheFieldButtonP2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HandDeckP1
            // 
            this.HandDeckP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HandDeckP1.FormattingEnabled = true;
            this.HandDeckP1.Location = new System.Drawing.Point(14, 204);
            this.HandDeckP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckP1.Name = "HandDeckP1";
            this.HandDeckP1.Size = new System.Drawing.Size(205, 228);
            this.HandDeckP1.TabIndex = 1;
            this.HandDeckP1.TextChanged += new System.EventHandler(this.HandDeck_TextChanged);
            // 
            // HandDeckP2
            // 
            this.HandDeckP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HandDeckP2.FormattingEnabled = true;
            this.HandDeckP2.Location = new System.Drawing.Point(734, 204);
            this.HandDeckP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckP2.Name = "HandDeckP2";
            this.HandDeckP2.Size = new System.Drawing.Size(187, 228);
            this.HandDeckP2.TabIndex = 2;
            this.HandDeckP2.TextChanged += new System.EventHandler(this.HandDeck_TextChanged);
            // 
            // ImageP1
            // 
            this.ImageP1.Image = global::CardGame.Properties.Resources.p1;
            this.ImageP1.Location = new System.Drawing.Point(14, 68);
            this.ImageP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageP1.Name = "ImageP1";
            this.ImageP1.Size = new System.Drawing.Size(97, 112);
            this.ImageP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageP1.TabIndex = 3;
            this.ImageP1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CardGame.Properties.Resources.p2;
            this.pictureBox1.Location = new System.Drawing.Point(824, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RoundСounter
            // 
            this.RoundСounter.AutoSize = true;
            this.RoundСounter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundСounter.Location = new System.Drawing.Point(450, 25);
            this.RoundСounter.Name = "RoundСounter";
            this.RoundСounter.Size = new System.Drawing.Size(73, 28);
            this.RoundСounter.TabIndex = 5;
            this.RoundСounter.Text = "Раунд ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 440);
            this.label1.TabIndex = 6;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // HeroesOnTheFieldP1
            // 
            this.HeroesOnTheFieldP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HeroesOnTheFieldP1.FormattingEnabled = true;
            this.HeroesOnTheFieldP1.Location = new System.Drawing.Point(297, 204);
            this.HeroesOnTheFieldP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnTheFieldP1.Name = "HeroesOnTheFieldP1";
            this.HeroesOnTheFieldP1.Size = new System.Drawing.Size(187, 228);
            this.HeroesOnTheFieldP1.TabIndex = 7;
            // 
            // HeroesOnTheFieldP2
            // 
            this.HeroesOnTheFieldP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HeroesOnTheFieldP2.FormattingEnabled = true;
            this.HeroesOnTheFieldP2.Location = new System.Drawing.Point(499, 204);
            this.HeroesOnTheFieldP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnTheFieldP2.Name = "HeroesOnTheFieldP2";
            this.HeroesOnTheFieldP2.Size = new System.Drawing.Size(187, 228);
            this.HeroesOnTheFieldP2.TabIndex = 8;
            // 
            // DropOnTheFieldButtonP1
            // 
            this.DropOnTheFieldButtonP1.Enabled = false;
            this.DropOnTheFieldButtonP1.Location = new System.Drawing.Point(14, 423);
            this.DropOnTheFieldButtonP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DropOnTheFieldButtonP1.Name = "DropOnTheFieldButtonP1";
            this.DropOnTheFieldButtonP1.Size = new System.Drawing.Size(205, 46);
            this.DropOnTheFieldButtonP1.TabIndex = 9;
            this.DropOnTheFieldButtonP1.Text = "Вывести на поле";
            this.DropOnTheFieldButtonP1.UseVisualStyleBackColor = true;
            this.DropOnTheFieldButtonP1.Click += new System.EventHandler(this.DropOnTheFieldButton_Click);
            // 
            // DropOnTheFieldButtonP2
            // 
            this.DropOnTheFieldButtonP2.Enabled = false;
            this.DropOnTheFieldButtonP2.Location = new System.Drawing.Point(734, 423);
            this.DropOnTheFieldButtonP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DropOnTheFieldButtonP2.Name = "DropOnTheFieldButtonP2";
            this.DropOnTheFieldButtonP2.Size = new System.Drawing.Size(187, 46);
            this.DropOnTheFieldButtonP2.TabIndex = 10;
            this.DropOnTheFieldButtonP2.Text = "Вывести на поле";
            this.DropOnTheFieldButtonP2.UseVisualStyleBackColor = true;
            this.DropOnTheFieldButtonP2.Click += new System.EventHandler(this.DropOnTheFieldButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 527);
            this.Controls.Add(this.DropOnTheFieldButtonP2);
            this.Controls.Add(this.DropOnTheFieldButtonP1);
            this.Controls.Add(this.HeroesOnTheFieldP2);
            this.Controls.Add(this.HeroesOnTheFieldP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoundСounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImageP1);
            this.Controls.Add(this.HandDeckP2);
            this.Controls.Add(this.HandDeckP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Shrek : Card game";
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
        private Label label1;
        private ComboBox HeroesOnTheFieldP1;
        private ComboBox HeroesOnTheFieldP2;
        private Button DropOnTheFieldButtonP1;
        private Button DropOnTheFieldButtonP2;
    }
}