namespace Pizza_Game
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.InfoBtn = new Pizza_Game.RoundButton();
            this.PlayBtn = new Pizza_Game.RoundButton();
            this.BeastMusic = new Pizza_Game.RoundButton();
            this.SuspendLayout();
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoBtn.BackgroundImage")));
            this.InfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoBtn.Location = new System.Drawing.Point(546, 345);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(132, 120);
            this.InfoBtn.TabIndex = 1;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click_1);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Black;
            this.PlayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayBtn.BackgroundImage")));
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBtn.ForeColor = System.Drawing.Color.Black;
            this.PlayBtn.Location = new System.Drawing.Point(367, 296);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(173, 154);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // BeastMusic
            // 
            this.BeastMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BeastMusic.BackgroundImage")));
            this.BeastMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BeastMusic.Location = new System.Drawing.Point(229, 330);
            this.BeastMusic.Name = "BeastMusic";
            this.BeastMusic.Size = new System.Drawing.Size(132, 120);
            this.BeastMusic.TabIndex = 2;
            this.BeastMusic.UseVisualStyleBackColor = true;
            this.BeastMusic.Click += new System.EventHandler(this.BeastMusic_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 477);
            this.Controls.Add(this.BeastMusic);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.PlayBtn);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton PlayBtn;
        private RoundButton InfoBtn;
        private RoundButton BeastMusic;
    }
}

