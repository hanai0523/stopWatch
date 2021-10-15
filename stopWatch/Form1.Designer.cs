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
            this.rapBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelLap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rapBtn
            // 
            this.rapBtn.Location = new System.Drawing.Point(50, 110);
            this.rapBtn.Name = "rapBtn";
            this.rapBtn.Size = new System.Drawing.Size(90, 40);
            this.rapBtn.TabIndex = 1;
            this.rapBtn.Text = "LAP";
            this.rapBtn.UseVisualStyleBackColor = true;
            this.rapBtn.Click += new System.EventHandler(this.rapBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(160, 110);
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
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(50, 40);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(192, 48);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelLap
            // 
            this.labelLap.AutoSize = true;
            this.labelLap.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLap.Location = new System.Drawing.Point(320, 100);
            this.labelLap.Name = "labelLap";
            this.labelLap.Size = new System.Drawing.Size(192, 48);
            this.labelLap.TabIndex = 4;
            this.labelLap.Text = "00:00:00";
            this.labelLap.Click += new System.EventHandler(this.labelLap_Click);
            // 
            // stopWacth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 184);
            this.Controls.Add(this.labelLap);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.rapBtn);
            this.Name = "stopWacth";
            this.Text = "stopWacth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rapBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelLap;
    }
}

