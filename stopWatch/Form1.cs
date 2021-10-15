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
    }
}
