
namespace Tamagochi_v2._0
{
    partial class Tamagochi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tamagochi));
            this.Health = new System.Windows.Forms.ProgressBar();
            this.Hungry = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Energy = new System.Windows.Forms.ProgressBar();
            this.Hygiene = new System.Windows.Forms.ProgressBar();
            this.Fun = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sleep = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Eating = new System.Windows.Forms.Button();
            this.WashUp = new System.Windows.Forms.Button();
            this.Joke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Health
            // 
            this.Health.Location = new System.Drawing.Point(12, 72);
            this.Health.MarqueeAnimationSpeed = 1000;
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(418, 23);
            this.Health.Step = 5;
            this.Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Health.TabIndex = 0;
            this.Health.Value = 100;
            // 
            // Hungry
            // 
            this.Hungry.Location = new System.Drawing.Point(12, 43);
            this.Hungry.Name = "Hungry";
            this.Hungry.Size = new System.Drawing.Size(100, 23);
            this.Hungry.Step = 1;
            this.Hungry.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Hungry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fun";
            // 
            // Energy
            // 
            this.Energy.Location = new System.Drawing.Point(118, 43);
            this.Energy.Name = "Energy";
            this.Energy.Size = new System.Drawing.Size(100, 23);
            this.Energy.Step = 1;
            this.Energy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Energy.TabIndex = 0;
            this.Energy.Value = 100;
            // 
            // Hygiene
            // 
            this.Hygiene.Location = new System.Drawing.Point(224, 43);
            this.Hygiene.Name = "Hygiene";
            this.Hygiene.Size = new System.Drawing.Size(100, 23);
            this.Hygiene.Step = 1;
            this.Hygiene.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Hygiene.TabIndex = 0;
            this.Hygiene.Value = 100;
            // 
            // Fun
            // 
            this.Fun.Location = new System.Drawing.Point(330, 43);
            this.Fun.Name = "Fun";
            this.Fun.Size = new System.Drawing.Size(100, 23);
            this.Fun.Step = 1;
            this.Fun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Fun.TabIndex = 0;
            this.Fun.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Energy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hygiene";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hungry";
            // 
            // Sleep
            // 
            this.Sleep.Location = new System.Drawing.Point(135, 395);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(62, 23);
            this.Sleep.TabIndex = 2;
            this.Sleep.Text = "Sleep";
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.Click += new System.EventHandler(this.Sleep_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 424);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(418, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.InitialImage = null;
            this.Picture.Location = new System.Drawing.Point(12, 116);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(418, 273);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picture.TabIndex = 4;
            this.Picture.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.RoyalBlue;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            this.imageList1.Images.SetKeyName(7, "8.png");
            this.imageList1.Images.SetKeyName(8, "9.png");
            this.imageList1.Images.SetKeyName(9, "10.png");
            this.imageList1.Images.SetKeyName(10, "11.png");
            this.imageList1.Images.SetKeyName(11, "Kirby_Circle.gif");
            this.imageList1.Images.SetKeyName(12, "Kirby_Eating.gif");
            this.imageList1.Images.SetKeyName(13, "Kirby_Go_Attack.gif");
            this.imageList1.Images.SetKeyName(14, "Kirby_Run.gif");
            this.imageList1.Images.SetKeyName(15, "Kirby_Waiting.gif");
            this.imageList1.Images.SetKeyName(16, "KirbyAll_GameOver.gif");
            this.imageList1.Images.SetKeyName(17, "KirbyAll_GameOver1.gif");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Eating
            // 
            this.Eating.Location = new System.Drawing.Point(12, 395);
            this.Eating.Name = "Eating";
            this.Eating.Size = new System.Drawing.Size(62, 23);
            this.Eating.TabIndex = 5;
            this.Eating.Text = "Eat";
            this.Eating.UseVisualStyleBackColor = true;
            this.Eating.Click += new System.EventHandler(this.Eating_Click);
            // 
            // WashUp
            // 
            this.WashUp.Location = new System.Drawing.Point(235, 395);
            this.WashUp.Name = "WashUp";
            this.WashUp.Size = new System.Drawing.Size(62, 23);
            this.WashUp.TabIndex = 6;
            this.WashUp.Text = "Wash Up";
            this.WashUp.UseVisualStyleBackColor = true;
            this.WashUp.Click += new System.EventHandler(this.WashUp_Click);
            // 
            // Joke
            // 
            this.Joke.Location = new System.Drawing.Point(368, 395);
            this.Joke.Name = "Joke";
            this.Joke.Size = new System.Drawing.Size(62, 23);
            this.Joke.TabIndex = 7;
            this.Joke.Text = "Joke";
            this.Joke.UseVisualStyleBackColor = true;
            this.Joke.Click += new System.EventHandler(this.Joke_Click);
            // 
            // Tamagochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 458);
            this.Controls.Add(this.Joke);
            this.Controls.Add(this.WashUp);
            this.Controls.Add(this.Eating);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fun);
            this.Controls.Add(this.Hygiene);
            this.Controls.Add(this.Energy);
            this.Controls.Add(this.Hungry);
            this.Controls.Add(this.Health);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tamagochi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagochi";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Health;
        private System.Windows.Forms.ProgressBar Hungry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Energy;
        private System.Windows.Forms.ProgressBar Hygiene;
        private System.Windows.Forms.ProgressBar Fun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sleep;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Eating;
        private System.Windows.Forms.Button WashUp;
        private System.Windows.Forms.Button Joke;
    }
}

