namespace stopWatch
{
    partial class stopWacth
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stopWacth));
            this.rapBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelLap = new System.Windows.Forms.Label();
            this.watch_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.watch_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rapBtn
            // 
            this.rapBtn.Location = new System.Drawing.Point(70, 290);
            this.rapBtn.Name = "rapBtn";
            this.rapBtn.Size = new System.Drawing.Size(90, 40);
            this.rapBtn.TabIndex = 1;
            this.rapBtn.Text = "LAP";
            this.rapBtn.UseVisualStyleBackColor = true;
            this.rapBtn.Click += new System.EventHandler(this.rapBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(220, 290);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(80, 40);
            this.startStopBtn.TabIndex = 2;
            this.startStopBtn.Text = "START";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(70, 60);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(123, 29);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelLap
            // 
            this.labelLap.AutoSize = true;
            this.labelLap.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLap.Location = new System.Drawing.Point(70, 370);
            this.labelLap.Name = "labelLap";
            this.labelLap.Size = new System.Drawing.Size(192, 48);
            this.labelLap.TabIndex = 4;
            this.labelLap.Text = "00:00:00";
            // 
            // watch_pictureBox
            // 
            this.watch_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("watch_pictureBox.Image")));
            this.watch_pictureBox.Location = new System.Drawing.Point(70, 90);
            this.watch_pictureBox.Name = "watch_pictureBox";
            this.watch_pictureBox.Size = new System.Drawing.Size(230, 180);
            this.watch_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.watch_pictureBox.TabIndex = 5;
            this.watch_pictureBox.TabStop = false;
            this.watch_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.watch_pictureBox_Paint);
            // 
            // stopWacth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 606);
            this.Controls.Add(this.watch_pictureBox);
            this.Controls.Add(this.labelLap);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.rapBtn);
            this.DoubleBuffered = true;
            this.Name = "stopWacth";
            this.Text = "stopWacth";
            ((System.ComponentModel.ISupportInitialize)(this.watch_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rapBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelLap;
        private System.Windows.Forms.PictureBox watch_pictureBox;
    }
}

