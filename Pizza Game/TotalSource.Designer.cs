namespace Pizza_Game
{
    partial class TotalSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalSource));
            this.CountTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.Label();
            this.Life = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.NextBtn = new Pizza_Game.RoundButton();
            this.BackBtn = new Pizza_Game.RoundButton();
            this.SuspendLayout();
            // 
            // CountTime
            // 
            this.CountTime.Font = new System.Drawing.Font("SkogenSpelFont", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTime.ForeColor = System.Drawing.Color.Yellow;
            this.CountTime.Location = new System.Drawing.Point(240, 176);
            this.CountTime.Name = "CountTime";
            this.CountTime.Size = new System.Drawing.Size(93, 54);
            this.CountTime.TabIndex = 0;
            this.CountTime.Text = "Час:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SkogenSpelFont", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(80, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість очок:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SkogenSpelFont", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість життів:";
            // 
            // Head
            // 
            this.Head.Font = new System.Drawing.Font("SkogenSpelFont", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.ForeColor = System.Drawing.Color.Yellow;
            this.Head.Location = new System.Drawing.Point(34, 18);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(491, 46);
            this.Head.TabIndex = 5;
            this.Head.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Life
            // 
            this.Life.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Life.Font = new System.Drawing.Font("SkogenSpelFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Life.ForeColor = System.Drawing.Color.Yellow;
            this.Life.Location = new System.Drawing.Point(365, 81);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(173, 30);
            this.Life.TabIndex = 6;
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Point.Font = new System.Drawing.Font("SkogenSpelFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.ForeColor = System.Drawing.Color.Yellow;
            this.Point.Location = new System.Drawing.Point(367, 133);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(171, 30);
            this.Point.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time.Font = new System.Drawing.Font("SkogenSpelFont", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Yellow;
            this.Time.Location = new System.Drawing.Point(367, 186);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(171, 30);
            this.Time.TabIndex = 8;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextBtn.BackgroundImage")));
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.NextBtn.Location = new System.Drawing.Point(171, 243);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(109, 98);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Location = new System.Drawing.Point(339, 243);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 98);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TotalSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Life);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TotalSource";
            this.Text = "TotalSource";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CountTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundButton BackBtn;
        private RoundButton NextBtn;
        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label Life;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Label Time;
    }
}