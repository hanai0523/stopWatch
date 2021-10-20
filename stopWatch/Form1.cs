using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopWatch
{
    public partial class stopWacth : Form
    {
        
        private Stopwatch _sw = new Stopwatch();

        //ちらつき防止
        Bitmap memoryImage;

        bool visibleMemoryImage = false;

        public stopWacth()
        {

            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            timer.Enabled = true;
        }

        //gittest
        private void startStopBtn_Click(object sender, EventArgs e)
        {
            //計測中かそうでないかでボタンの表示を変えるｓ
            if (_sw.IsRunning)
            {
                _sw.Stop();
                ((Button)sender).Text = "START";
                rapBtn.Text = "RESET";
            }
            else
            {
                _sw.Start();
                ((Button)sender).Text = "STOP";
                rapBtn.Text = "LAP";
                rapBtn.Text = "LAP";
            }
            
        }

        //1ms間隔で更新
        private void timer_Tick(object sender, EventArgs e)
        {
            //時間描画
            timeLabel.Text = _sw.Elapsed.ToString(@"hh\:mm\:ss\:fff");
            CaptureScreen();
            this.watch_pictureBox.Invalidate();
        }

        private void rapBtn_Click(object sender, EventArgs e)
        {
            //計測中ならラップを取る
            if (_sw.IsRunning)
            {
                labelLap.Text = _sw.Elapsed.ToString();
            }
            //タイマーが止まっていればリセットする
            else
            {
                _sw.Reset();
                labelLap.Text = "00:00:00:00";
            }
        }


        private void CaptureScreen()
        {
            Graphics g = this.watch_pictureBox.CreateGraphics();

            // penを作成
            Pen redPen = new Pen(Color.Red, 2);


            //針の長さ
            float needleLength = this.watch_pictureBox.Height / 2 - 10;
            float start_x = this.watch_pictureBox.Width / 2;
            float start_y = this.watch_pictureBox.Height / 2;
            const float angle_t = 360;
            const float minute = 60000;

            //動いてない時は90度
            float angle_n = 90 - angle_t * _sw.ElapsedMilliseconds / minute;

            // lineの始点と終点を設定
            PointF Start_point = new PointF(start_x, start_y);
            float goal_x = start_x + needleLength * (float)Math.Cos(angle_n * Math.PI / 180);
            float goal_y = start_y - needleLength * (float)Math.Sin(angle_n * Math.PI / 180);
            PointF End_point
            = new PointF(goal_x, goal_y);

            // lineを描画
            g.DrawLine(redPen, Start_point, End_point);

            // penを解放する
            redPen.Dispose();



            //ピクセルをコピー
            Graphics myGraphics = this.watch_pictureBox.CreateGraphics();
            Size s = this.watch_pictureBox.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.watch_pictureBox.Location.X, this.watch_pictureBox.Location.Y, 0, 0, s);
            

            // Graphicsを解放する
            g.Dispose();
            visibleMemoryImage = true;
        }


        private void watch_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            //画像描画
            //if(visibleMemoryImage)e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}
