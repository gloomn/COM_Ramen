using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM_Ramen
{
    public partial class MainForm : Form
    {
        private Timer frameTimer;
        private Image[] waterImages;
        private int currentFrame = 0;
        private int repeatCount = 0;
        private const int totalFrames = 5;
        private const int maxRepeats = 3; // 총 3번 반복
        private const int frameInterval = 1000; // 1초

        public MainForm()
        {
            InitializeComponent();
            startPanel_1.Dock = DockStyle.Fill;
            startPanel_1.BringToFront();
            frameTimer_Init();

            // Resource에서 PNG 불러오기
            waterImages = new Image[]
            {
            Properties.Resources.setWaterHeight1,
            Properties.Resources.setWaterHeight2,
            Properties.Resources.setWaterHeight3,
            Properties.Resources.setWaterHeight4,
            Properties.Resources.setWaterHeight5
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            setWaterHeightPanel_2.BringToFront();
            currentFrame = 0;
            repeatCount = 0;
            setWaterHeightScene.Image = waterImages[currentFrame];
            frameTimer.Interval = frameInterval;
            frameTimer.Start();
        }

        private void frameTimer_Tick(object sender, EventArgs e)
        {
            currentFrame++;

            if (currentFrame >= totalFrames)
            {
                currentFrame = 0;
                repeatCount++;

                if (repeatCount >= maxRepeats)
                {
                    // 마지막 프레임 유지
                    currentFrame = totalFrames - 1;
                    setWaterHeightScene.Image = waterImages[currentFrame];
                    frameTimer.Stop();
                    return;
                }
            }

            setWaterHeightScene.Image = waterImages[currentFrame];
        }

        private void frameTimer_Init()
        {
            frameTimer = new Timer();
            frameTimer.Tick += frameTimer_Tick;
        }

        private void stopWaterButton_Click(object sender, EventArgs e)
        {
            frameTimer.Stop();
        }
    }

}
