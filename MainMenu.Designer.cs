namespace CaveGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pStory = new System.Windows.Forms.Panel();
            this.pbStoryBeenden = new System.Windows.Forms.PictureBox();
            this.pbStory = new System.Windows.Forms.PictureBox();
            this.pbHighscore = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStoryBeenden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pStory
            // 
            this.pStory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pStory.BackgroundImage = global::CaveGame.Properties.Resources.storypanel;
            this.pStory.Controls.Add(this.pbStoryBeenden);
            this.pStory.Location = new System.Drawing.Point(38, 156);
            this.pStory.Name = "pStory";
            this.pStory.Size = new System.Drawing.Size(215, 340);
            this.pStory.TabIndex = 5;
            // 
            // pbStoryBeenden
            // 
            this.pbStoryBeenden.ErrorImage = null;
            this.pbStoryBeenden.Image = global::CaveGame.Properties.Resources.buttonschliessenn;
            this.pbStoryBeenden.InitialImage = null;
            this.pbStoryBeenden.Location = new System.Drawing.Point(26, 287);
            this.pbStoryBeenden.Name = "pbStoryBeenden";
            this.pbStoryBeenden.Size = new System.Drawing.Size(165, 53);
            this.pbStoryBeenden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStoryBeenden.TabIndex = 0;
            this.pbStoryBeenden.TabStop = false;
            this.pbStoryBeenden.Click += new System.EventHandler(this.pbStoryBeenden_Click);
            this.pbStoryBeenden.MouseLeave += new System.EventHandler(this.pbStoryBeenden_MouseLeave);
            this.pbStoryBeenden.MouseHover += new System.EventHandler(this.pbStoryBeenden_MouseHover);
            // 
            // pbStory
            // 
            this.pbStory.Image = global::CaveGame.Properties.Resources.buttonfragezeichenGIF;
            this.pbStory.Location = new System.Drawing.Point(1202, 12);
            this.pbStory.Name = "pbStory";
            this.pbStory.Size = new System.Drawing.Size(50, 50);
            this.pbStory.TabIndex = 4;
            this.pbStory.TabStop = false;
            this.pbStory.Click += new System.EventHandler(this.pbStory_Click);
            this.pbStory.MouseLeave += new System.EventHandler(this.pbStory_MouseLeave);
            this.pbStory.MouseHover += new System.EventHandler(this.pbStory_MouseHover);
            // 
            // pbHighscore
            // 
            this.pbHighscore.BackgroundImage = global::CaveGame.Properties.Resources.buttonhighscore;
            this.pbHighscore.Location = new System.Drawing.Point(38, 540);
            this.pbHighscore.Name = "pbHighscore";
            this.pbHighscore.Size = new System.Drawing.Size(324, 77);
            this.pbHighscore.TabIndex = 3;
            this.pbHighscore.TabStop = false;
            this.pbHighscore.Click += new System.EventHandler(this.pbHighscore_Click);
            this.pbHighscore.MouseLeave += new System.EventHandler(this.pbHighscore_MouseLeave);
            this.pbHighscore.MouseHover += new System.EventHandler(this.pbHighscore_MouseHover);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::CaveGame.Properties.Resources.buttonExitgross;
            this.pbExit.Location = new System.Drawing.Point(912, 540);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(324, 77);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 2;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // pbStart
            // 
            this.pbStart.Image = global::CaveGame.Properties.Resources.Start_animation;
            this.pbStart.Location = new System.Drawing.Point(517, 283);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(324, 77);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 1;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            this.pbStart.MouseLeave += new System.EventHandler(this.pbStartLeave);
            this.pbStart.MouseHover += new System.EventHandler(this.pbStartHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pStory);
            this.Controls.Add(this.pbStory);
            this.Controls.Add(this.pbHighscore);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuKeyDown);
            this.pStory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStoryBeenden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHighscore;
        private System.Windows.Forms.PictureBox pbStory;
        private System.Windows.Forms.Panel pStory;
        private System.Windows.Forms.PictureBox pbStoryBeenden;
    }
}