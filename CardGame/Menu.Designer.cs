namespace CardGame
{
    partial class Menu
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
            this.StartNewGameBtn = new System.Windows.Forms.Button();
            this.ContinueGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartNewGameBtn
            // 
            this.StartNewGameBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartNewGameBtn.Location = new System.Drawing.Point(43, 227);
            this.StartNewGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartNewGameBtn.Name = "StartNewGameBtn";
            this.StartNewGameBtn.Size = new System.Drawing.Size(248, 93);
            this.StartNewGameBtn.TabIndex = 0;
            this.StartNewGameBtn.Text = "Новая игра";
            this.StartNewGameBtn.UseVisualStyleBackColor = true;
            this.StartNewGameBtn.Click += new System.EventHandler(this.StartNewGameBtn_Click);
            // 
            // ContinueGameBtn
            // 
            this.ContinueGameBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueGameBtn.Location = new System.Drawing.Point(43, 125);
            this.ContinueGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContinueGameBtn.Name = "ContinueGameBtn";
            this.ContinueGameBtn.Size = new System.Drawing.Size(248, 93);
            this.ContinueGameBtn.TabIndex = 1;
            this.ContinueGameBtn.Text = "Продолжить";
            this.ContinueGameBtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 448);
            this.Controls.Add(this.ContinueGameBtn);
            this.Controls.Add(this.StartNewGameBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartNewGameBtn;
        private Button ContinueGameBtn;
    }
}