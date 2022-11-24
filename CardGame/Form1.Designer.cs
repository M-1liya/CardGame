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
            this.HeroesOnFieldP1 = new System.Windows.Forms.ComboBox();
            this.HandDeckButtonP1 = new System.Windows.Forms.Button();
            this.HandDeckButtonP2 = new System.Windows.Forms.Button();
            this.textOfManaP1 = new System.Windows.Forms.Label();
            this.amountManaP1 = new System.Windows.Forms.Label();
            this.HeroesOnFieldButtonP1 = new System.Windows.Forms.Button();
            this.HeroesOnFieldButtonP2 = new System.Windows.Forms.Button();
            this.amountHealtNexusP1 = new System.Windows.Forms.Label();
            this.textOfNexusP1 = new System.Windows.Forms.Label();
            this.amountHealtNexusP2 = new System.Windows.Forms.Label();
            this.textOfNexusP2 = new System.Windows.Forms.Label();
            this.amountManaP2 = new System.Windows.Forms.Label();
            this.textOfManaP2 = new System.Windows.Forms.Label();
            this.battlegroundP1 = new System.Windows.Forms.ComboBox();
            this.battlegroundP2 = new System.Windows.Forms.ComboBox();
            this.HeroesOnFieldP2 = new System.Windows.Forms.ComboBox();
            this.battlegroundButtonP1 = new System.Windows.Forms.Button();
            this.battlegroundButtonP2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HandDeckP1
            // 
            this.HandDeckP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HandDeckP1.FormattingEnabled = true;
            this.HandDeckP1.Location = new System.Drawing.Point(12, 198);
            this.HandDeckP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckP1.Name = "HandDeckP1";
            this.HandDeckP1.Size = new System.Drawing.Size(313, 228);
            this.HandDeckP1.TabIndex = 1;
            this.HandDeckP1.SelectedIndexChanged += new System.EventHandler(this.HandDeck_SelectedIndexChanged);
            // 
            // HandDeckP2
            // 
            this.HandDeckP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HandDeckP2.FormattingEnabled = true;
            this.HandDeckP2.Location = new System.Drawing.Point(1062, 197);
            this.HandDeckP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckP2.Name = "HandDeckP2";
            this.HandDeckP2.Size = new System.Drawing.Size(313, 228);
            this.HandDeckP2.TabIndex = 2;
            this.HandDeckP2.SelectedIndexChanged += new System.EventHandler(this.HandDeck_SelectedIndexChanged);
            // 
            // ImageP1
            // 
            this.ImageP1.Image = global::CardGame.Properties.Resources.p1;
            this.ImageP1.Location = new System.Drawing.Point(24, 68);
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
            this.pictureBox1.Location = new System.Drawing.Point(1061, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RoundСounter
            // 
            this.RoundСounter.AutoSize = true;
            this.RoundСounter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundСounter.Location = new System.Drawing.Point(659, 25);
            this.RoundСounter.Name = "RoundСounter";
            this.RoundСounter.Size = new System.Drawing.Size(73, 28);
            this.RoundСounter.TabIndex = 5;
            this.RoundСounter.Text = "Раунд ";
            // 
            // HeroesOnFieldP1
            // 
            this.HeroesOnFieldP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HeroesOnFieldP1.FormattingEnabled = true;
            this.HeroesOnFieldP1.Location = new System.Drawing.Point(360, 198);
            this.HeroesOnFieldP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnFieldP1.Name = "HeroesOnFieldP1";
            this.HeroesOnFieldP1.Size = new System.Drawing.Size(313, 213);
            this.HeroesOnFieldP1.TabIndex = 7;
            this.HeroesOnFieldP1.SelectedIndexChanged += new System.EventHandler(this.HeroesOnField_SelectedIndexChanged);
            // 
            // HandDeckButtonP1
            // 
            this.HandDeckButtonP1.Enabled = false;
            this.HandDeckButtonP1.Location = new System.Drawing.Point(14, 417);
            this.HandDeckButtonP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckButtonP1.Name = "HandDeckButtonP1";
            this.HandDeckButtonP1.Size = new System.Drawing.Size(311, 46);
            this.HandDeckButtonP1.TabIndex = 9;
            this.HandDeckButtonP1.Text = "Вывести на поле";
            this.HandDeckButtonP1.UseVisualStyleBackColor = true;
            this.HandDeckButtonP1.Click += new System.EventHandler(this.HandDeckButton_Click);
            // 
            // HandDeckButtonP2
            // 
            this.HandDeckButtonP2.Enabled = false;
            this.HandDeckButtonP2.Location = new System.Drawing.Point(1061, 417);
            this.HandDeckButtonP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandDeckButtonP2.Name = "HandDeckButtonP2";
            this.HandDeckButtonP2.Size = new System.Drawing.Size(315, 46);
            this.HandDeckButtonP2.TabIndex = 10;
            this.HandDeckButtonP2.Text = "Вывести на поле";
            this.HandDeckButtonP2.UseVisualStyleBackColor = true;
            this.HandDeckButtonP2.Click += new System.EventHandler(this.HandDeckButton_Click);
            // 
            // textOfManaP1
            // 
            this.textOfManaP1.AutoSize = true;
            this.textOfManaP1.Location = new System.Drawing.Point(142, 135);
            this.textOfManaP1.Name = "textOfManaP1";
            this.textOfManaP1.Size = new System.Drawing.Size(104, 20);
            this.textOfManaP1.TabIndex = 11;
            this.textOfManaP1.Text = "Кол-во маны:";
            // 
            // amountManaP1
            // 
            this.amountManaP1.AutoSize = true;
            this.amountManaP1.Location = new System.Drawing.Point(248, 135);
            this.amountManaP1.Name = "amountManaP1";
            this.amountManaP1.Size = new System.Drawing.Size(0, 20);
            this.amountManaP1.TabIndex = 12;
            // 
            // HeroesOnFieldButtonP1
            // 
            this.HeroesOnFieldButtonP1.Enabled = false;
            this.HeroesOnFieldButtonP1.Location = new System.Drawing.Point(360, 419);
            this.HeroesOnFieldButtonP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnFieldButtonP1.Name = "HeroesOnFieldButtonP1";
            this.HeroesOnFieldButtonP1.Size = new System.Drawing.Size(313, 46);
            this.HeroesOnFieldButtonP1.TabIndex = 15;
            this.HeroesOnFieldButtonP1.Text = "Отправить в битву";
            this.HeroesOnFieldButtonP1.UseVisualStyleBackColor = true;
            this.HeroesOnFieldButtonP1.Click += new System.EventHandler(this.HeroesOnFieldButton_Click);
            // 
            // HeroesOnFieldButtonP2
            // 
            this.HeroesOnFieldButtonP2.Enabled = false;
            this.HeroesOnFieldButtonP2.Location = new System.Drawing.Point(708, 417);
            this.HeroesOnFieldButtonP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnFieldButtonP2.Name = "HeroesOnFieldButtonP2";
            this.HeroesOnFieldButtonP2.Size = new System.Drawing.Size(313, 46);
            this.HeroesOnFieldButtonP2.TabIndex = 16;
            this.HeroesOnFieldButtonP2.Text = "Пропустить ход";
            this.HeroesOnFieldButtonP2.UseVisualStyleBackColor = true;
            this.HeroesOnFieldButtonP2.Click += new System.EventHandler(this.HeroesOnFieldButton_Click);
            // 
            // amountHealtNexusP1
            // 
            this.amountHealtNexusP1.AutoSize = true;
            this.amountHealtNexusP1.Location = new System.Drawing.Point(201, 94);
            this.amountHealtNexusP1.Name = "amountHealtNexusP1";
            this.amountHealtNexusP1.Size = new System.Drawing.Size(0, 20);
            this.amountHealtNexusP1.TabIndex = 18;
            // 
            // textOfNexusP1
            // 
            this.textOfNexusP1.AutoSize = true;
            this.textOfNexusP1.Location = new System.Drawing.Point(142, 94);
            this.textOfNexusP1.Name = "textOfNexusP1";
            this.textOfNexusP1.Size = new System.Drawing.Size(59, 20);
            this.textOfNexusP1.TabIndex = 17;
            this.textOfNexusP1.Text = "Нексус:";
            // 
            // amountHealtNexusP2
            // 
            this.amountHealtNexusP2.AutoSize = true;
            this.amountHealtNexusP2.Location = new System.Drawing.Point(1240, 94);
            this.amountHealtNexusP2.Name = "amountHealtNexusP2";
            this.amountHealtNexusP2.Size = new System.Drawing.Size(0, 20);
            this.amountHealtNexusP2.TabIndex = 24;
            // 
            // textOfNexusP2
            // 
            this.textOfNexusP2.AutoSize = true;
            this.textOfNexusP2.Location = new System.Drawing.Point(1181, 94);
            this.textOfNexusP2.Name = "textOfNexusP2";
            this.textOfNexusP2.Size = new System.Drawing.Size(59, 20);
            this.textOfNexusP2.TabIndex = 23;
            this.textOfNexusP2.Text = "Нексус:";
            // 
            // amountManaP2
            // 
            this.amountManaP2.AutoSize = true;
            this.amountManaP2.Location = new System.Drawing.Point(1287, 135);
            this.amountManaP2.Name = "amountManaP2";
            this.amountManaP2.Size = new System.Drawing.Size(0, 20);
            this.amountManaP2.TabIndex = 22;
            // 
            // textOfManaP2
            // 
            this.textOfManaP2.AutoSize = true;
            this.textOfManaP2.Location = new System.Drawing.Point(1181, 135);
            this.textOfManaP2.Name = "textOfManaP2";
            this.textOfManaP2.Size = new System.Drawing.Size(104, 20);
            this.textOfManaP2.TabIndex = 21;
            this.textOfManaP2.Text = "Кол-во маны:";
            // 
            // battlegroundP1
            // 
            this.battlegroundP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.battlegroundP1.FormattingEnabled = true;
            this.battlegroundP1.Location = new System.Drawing.Point(12, 489);
            this.battlegroundP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.battlegroundP1.Name = "battlegroundP1";
            this.battlegroundP1.Size = new System.Drawing.Size(661, 173);
            this.battlegroundP1.TabIndex = 25;
            // 
            // battlegroundP2
            // 
            this.battlegroundP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.battlegroundP2.FormattingEnabled = true;
            this.battlegroundP2.Location = new System.Drawing.Point(715, 489);
            this.battlegroundP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.battlegroundP2.Name = "battlegroundP2";
            this.battlegroundP2.Size = new System.Drawing.Size(661, 173);
            this.battlegroundP2.TabIndex = 26;
            // 
            // HeroesOnFieldP2
            // 
            this.HeroesOnFieldP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.HeroesOnFieldP2.FormattingEnabled = true;
            this.HeroesOnFieldP2.Location = new System.Drawing.Point(708, 196);
            this.HeroesOnFieldP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeroesOnFieldP2.Name = "HeroesOnFieldP2";
            this.HeroesOnFieldP2.Size = new System.Drawing.Size(313, 213);
            this.HeroesOnFieldP2.TabIndex = 27;
            this.HeroesOnFieldP2.SelectedIndexChanged += new System.EventHandler(this.HeroesOnField_SelectedIndexChanged);
            // 
            // battlegroundButtonP1
            // 
            this.battlegroundButtonP1.Location = new System.Drawing.Point(12, 672);
            this.battlegroundButtonP1.Name = "battlegroundButtonP1";
            this.battlegroundButtonP1.Size = new System.Drawing.Size(661, 42);
            this.battlegroundButtonP1.TabIndex = 28;
            this.battlegroundButtonP1.Text = "button1";
            this.battlegroundButtonP1.UseVisualStyleBackColor = true;
            this.battlegroundButtonP1.Click += new System.EventHandler(this.battlegroundButton_Click);
            // 
            // battlegroundButtonP2
            // 
            this.battlegroundButtonP2.Location = new System.Drawing.Point(715, 672);
            this.battlegroundButtonP2.Name = "battlegroundButtonP2";
            this.battlegroundButtonP2.Size = new System.Drawing.Size(661, 42);
            this.battlegroundButtonP2.TabIndex = 29;
            this.battlegroundButtonP2.Text = "button2";
            this.battlegroundButtonP2.UseVisualStyleBackColor = true;
            this.battlegroundButtonP2.Click += new System.EventHandler(this.battlegroundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 726);
            this.Controls.Add(this.battlegroundButtonP2);
            this.Controls.Add(this.battlegroundButtonP1);
            this.Controls.Add(this.HeroesOnFieldP2);
            this.Controls.Add(this.battlegroundP2);
            this.Controls.Add(this.battlegroundP1);
            this.Controls.Add(this.amountHealtNexusP2);
            this.Controls.Add(this.textOfNexusP2);
            this.Controls.Add(this.amountManaP2);
            this.Controls.Add(this.textOfManaP2);
            this.Controls.Add(this.amountHealtNexusP1);
            this.Controls.Add(this.textOfNexusP1);
            this.Controls.Add(this.HeroesOnFieldButtonP2);
            this.Controls.Add(this.HeroesOnFieldButtonP1);
            this.Controls.Add(this.amountManaP1);
            this.Controls.Add(this.textOfManaP1);
            this.Controls.Add(this.HandDeckButtonP2);
            this.Controls.Add(this.HandDeckButtonP1);
            this.Controls.Add(this.HeroesOnFieldP1);
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
        private ComboBox HeroesOnFieldP1;
        private Button HandDeckButtonP1;
        private Button HandDeckButtonP2;
        private Label textOfManaP1;
        private Label amountManaP1;
        private Button HeroesOnFieldButtonP1;
        private Button HeroesOnFieldButtonP2;
        private Label amountHealtNexusP1;
        private Label textOfNexusP1;
        private Label amountHealtNexusP2;
        private Label textOfNexusP2;
        private Label amountManaP2;
        private Label textOfManaP2;
        private ComboBox battlegroundP1;
        private ComboBox battlegroundP2;
        private ComboBox HeroesOnFieldP2;
        private Button battlegroundButtonP1;
        private Button battlegroundButtonP2;
    }
}