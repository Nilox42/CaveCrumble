namespace CaveGame
{
    partial class Highscore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscore));
            this.rtbHighscores = new System.Windows.Forms.RichTextBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbSpeichern = new System.Windows.Forms.PictureBox();
            this.pbLaden = new System.Windows.Forms.PictureBox();
            this.pbClear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeichern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPunktzahl
            // 
            this.rtbHighscores.BackColor = System.Drawing.SystemColors.Control;
            this.rtbHighscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHighscores.Location = new System.Drawing.Point(377, 167);
            this.rtbHighscores.Name = "rtbPunktzahl";
            this.rtbHighscores.ReadOnly = true;
            this.rtbHighscores.Size = new System.Drawing.Size(444, 266);
            this.rtbHighscores.TabIndex = 9;
            this.rtbHighscores.Text = "";
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.Image = global::CaveGame.Properties.Resources.buttonmain;
            this.pbMain.Location = new System.Drawing.Point(900, 540);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(324, 77);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.btMain);
            this.pbMain.MouseLeave += new System.EventHandler(this.BtMainLeave);
            this.pbMain.MouseHover += new System.EventHandler(this.BtMainHover);
            // 
            // pbSpeichern
            // 
            this.pbSpeichern.Image = global::CaveGame.Properties.Resources.buttonspeichern;
            this.pbSpeichern.Location = new System.Drawing.Point(515, 455);
            this.pbSpeichern.Name = "pbSpeichern";
            this.pbSpeichern.Size = new System.Drawing.Size(168, 48);
            this.pbSpeichern.TabIndex = 14;
            this.pbSpeichern.TabStop = false;
            this.pbSpeichern.Click += new System.EventHandler(this.pbSpeichern_Click);
            this.pbSpeichern.MouseLeave += new System.EventHandler(this.pbSpeichern_MouseLeave);
            this.pbSpeichern.MouseHover += new System.EventHandler(this.pbSpeichern_MouseHover);
            // 
            // pbLaden
            // 
            this.pbLaden.Image = global::CaveGame.Properties.Resources.buttonladen;
            this.pbLaden.Location = new System.Drawing.Point(377, 455);
            this.pbLaden.Name = "pbLaden";
            this.pbLaden.Size = new System.Drawing.Size(132, 48);
            this.pbLaden.TabIndex = 15;
            this.pbLaden.TabStop = false;
            this.pbLaden.Click += new System.EventHandler(this.pbLaden_Click);
            this.pbLaden.MouseLeave += new System.EventHandler(this.pbLaden_MouseLeave);
            this.pbLaden.MouseHover += new System.EventHandler(this.pbLaden_MouseHover);
            // 
            // pbClear
            // 
            this.pbClear.Image = global::CaveGame.Properties.Resources.buttonclear;
            this.pbClear.Location = new System.Drawing.Point(689, 455);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(132, 48);
            this.pbClear.TabIndex = 16;
            this.pbClear.TabStop = false;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            this.pbClear.MouseLeave += new System.EventHandler(this.pbClear_MouseLeave);
            this.pbClear.MouseHover += new System.EventHandler(this.pbClear_MouseHover);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.pbLaden);
            this.Controls.Add(this.pbSpeichern);
            this.Controls.Add(this.rtbHighscores);
            this.Controls.Add(this.pbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "highscore";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeichern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.RichTextBox rtbHighscores;
        private System.Windows.Forms.PictureBox pbSpeichern;
        private System.Windows.Forms.PictureBox pbLaden;
        private System.Windows.Forms.PictureBox pbClear;
    }
}