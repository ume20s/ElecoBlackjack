
namespace EreBla
{
    partial class CharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            this.PictMuiBig = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictMuiSmall = new System.Windows.Forms.PictureBox();
            this.PictEreBig = new System.Windows.Forms.PictureBox();
            this.PictEreSmall = new System.Windows.Forms.PictureBox();
            this.sliderVolume = new System.Windows.Forms.TrackBar();
            this.LabelVolumeCtrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictMuiBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMuiSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEreBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEreSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // PictMuiBig
            // 
            this.PictMuiBig.Image = global::EreBla.Properties.Resources.mui_waiting;
            this.PictMuiBig.Location = new System.Drawing.Point(265, 98);
            this.PictMuiBig.Name = "PictMuiBig";
            this.PictMuiBig.Size = new System.Drawing.Size(210, 280);
            this.PictMuiBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictMuiBig.TabIndex = 0;
            this.PictMuiBig.TabStop = false;
            this.PictMuiBig.Visible = false;
            this.PictMuiBig.Click += new System.EventHandler(this.PictMuiBig_Click);
            this.PictMuiBig.MouseEnter += new System.EventHandler(this.PictEleBig_MouseEnter);
            this.PictMuiBig.MouseLeave += new System.EventHandler(this.PictEleBig_MouseLeave);
            this.PictMuiBig.MouseHover += new System.EventHandler(this.PictEleBig_MouseHover);
            this.PictMuiBig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictEleBig_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EreBla.Properties.Resources.docchi;
            this.pictureBox2.Location = new System.Drawing.Point(35, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PictMuiSmall
            // 
            this.PictMuiSmall.Image = global::EreBla.Properties.Resources.mui_waiting;
            this.PictMuiSmall.Location = new System.Drawing.Point(275, 108);
            this.PictMuiSmall.Name = "PictMuiSmall";
            this.PictMuiSmall.Size = new System.Drawing.Size(190, 260);
            this.PictMuiSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictMuiSmall.TabIndex = 2;
            this.PictMuiSmall.TabStop = false;
            this.PictMuiSmall.MouseEnter += new System.EventHandler(this.PictEleSmall_MouseEnter);
            // 
            // PictEreBig
            // 
            this.PictEreBig.Image = global::EreBla.Properties.Resources.ere_waiting;
            this.PictEreBig.Location = new System.Drawing.Point(35, 98);
            this.PictEreBig.Name = "PictEreBig";
            this.PictEreBig.Size = new System.Drawing.Size(210, 280);
            this.PictEreBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictEreBig.TabIndex = 3;
            this.PictEreBig.TabStop = false;
            this.PictEreBig.Visible = false;
            this.PictEreBig.Click += new System.EventHandler(this.PictEreBig_Click);
            this.PictEreBig.MouseEnter += new System.EventHandler(this.PictEreBig_MouseEnter);
            this.PictEreBig.MouseLeave += new System.EventHandler(this.PictEreBig_MouseLeave);
            this.PictEreBig.MouseHover += new System.EventHandler(this.PictEreBig_MouseHover);
            this.PictEreBig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictEreBig_MouseMove);
            // 
            // PictEreSmall
            // 
            this.PictEreSmall.Image = global::EreBla.Properties.Resources.ere_waiting;
            this.PictEreSmall.Location = new System.Drawing.Point(45, 108);
            this.PictEreSmall.Name = "PictEreSmall";
            this.PictEreSmall.Size = new System.Drawing.Size(190, 260);
            this.PictEreSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictEreSmall.TabIndex = 4;
            this.PictEreSmall.TabStop = false;
            this.PictEreSmall.MouseEnter += new System.EventHandler(this.PictEreSmall_MouseEnter);
            // 
            // sliderVolume
            // 
            this.sliderVolume.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.sliderVolume.Location = new System.Drawing.Point(35, 388);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(263, 45);
            this.sliderVolume.TabIndex = 5;
            this.sliderVolume.TickFrequency = 10;
            this.sliderVolume.Value = 60;
            this.sliderVolume.Visible = false;
            this.sliderVolume.MouseLeave += new System.EventHandler(this.sliderVolume_MouseLeave);
            this.sliderVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderVolume_MouseUp);
            // 
            // LabelVolumeCtrl
            // 
            this.LabelVolumeCtrl.AutoSize = true;
            this.LabelVolumeCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelVolumeCtrl.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelVolumeCtrl.ForeColor = System.Drawing.Color.Green;
            this.LabelVolumeCtrl.Location = new System.Drawing.Point(35, 396);
            this.LabelVolumeCtrl.Name = "LabelVolumeCtrl";
            this.LabelVolumeCtrl.Size = new System.Drawing.Size(98, 22);
            this.LabelVolumeCtrl.TabIndex = 6;
            this.LabelVolumeCtrl.Text = "音量調節";
            this.LabelVolumeCtrl.MouseEnter += new System.EventHandler(this.LabelVolumeCtrl_MouseEnter);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(512, 439);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.PictEreBig);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictMuiBig);
            this.Controls.Add(this.PictMuiSmall);
            this.Controls.Add(this.PictEreSmall);
            this.Controls.Add(this.LabelVolumeCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterSelect";
            this.Text = "えれこのぶらっくじゃっく";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictMuiBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMuiSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEreBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEreSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictMuiBig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PictMuiSmall;
        private System.Windows.Forms.PictureBox PictEreBig;
        private System.Windows.Forms.PictureBox PictEreSmall;
        private System.Windows.Forms.TrackBar sliderVolume;
        private System.Windows.Forms.Label LabelVolumeCtrl;
    }
}

