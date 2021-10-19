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
        

        public stopWacth()
        {
            InitializeComponent();
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

        //10ms間隔で更新
        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = _sw.Elapsed.ToString();

            Graphics g = this.CreateGraphics();
            // penを作成
            Pen blackPen = new Pen(Color.Black, 2);

            //針の長さ
            const int needleLength = 30;
            const int start_x = 50;
            const int start_y = 40;

            const int angle_t = 360;
            const int minute = 60000;

            double angle_n = angle_t * _sw.ElapsedMilliseconds / minute;

            //動いてない時は90度
            if (_sw.IsRunning)
            {
                angle_n = 90;
            }

            // lineの始点と終点を設定
            Point Start_point = new Point(start_x, start_y);
            Point End_point
                = new Point(start_x + needleLength * (int)(Math.Sin(angle_n) * 100) / 100
                , start_y + needleLength * (int)(Math.Cos(angle_n) * 100) / 100);

            // lineを描画
            g.DrawLine(blackPen, Start_point, End_point);

            // penを解放する
            blackPen.Dispose();

            // Graphicsを解放する
            g.Dispose();
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
                labelLap.Text = "00:00:00";
            }
        }

        private void labelLap_Click(object sender, EventArgs e)
        {

        }

        private void stopWacth_Paint(object sender, PaintEventArgs e)
        {
            // Graphicsオブジェクトの作成
            //Graphics g = this.CreateGraphics();

            
        }
    }
}
