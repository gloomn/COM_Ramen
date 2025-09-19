//Copyright (C) 2025 Lee Ki Joon
using System;
using System.Drawing;
using System.Windows.Forms;

namespace COM_Ramen
{
    public partial class MainForm : Form
    {
        private Timer frameTimer;
        private Image[] waterImages;

        // Set water height definition
        private int currentFrame = 0;
        private int repeatCount = 0;
        private const int totalFrames = 5;
        private const int maxRepeats = 3; // Repeat 3 cycles
        private const int frameInterval = 1000; // Frame interval 1 second

        // Noodle definition
        private Timer noodleTimer;
        private int noodleSpeed = 20;
        private int noodleDirection = 1;

        private Timer noodleFallTimer;
        private DateTime noodleStartTime;

        // noodle이 떨어질 때 체크할 영역
        private Rectangle targetArea = new Rectangle(668, 556, 570, 285); // x, y, width, height
        private Rectangle powderTargetArea = new Rectangle(668, 0, 570, 1080);

        private Point startPoint;
        private bool dragging;
        private int yPos;
        private int xPos;



        public MainForm()
        {
            InitializeComponent();

            // 패널 초기화
            startPanel_1.Dock = DockStyle.Fill;
            setWaterHeightPanel_2.Dock = DockStyle.Fill;
            waterBoilingPanel_3.Dock = DockStyle.Fill;
            putNoodlePanel_4.Dock = DockStyle.Fill;
            noodleInWaterPanel_5.Dock = DockStyle.Fill;
            startPanel_1.BringToFront();

            // Timer 초기화
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

            // KeyPreview 활성화 → Form에서 키 입력 먼저 처리
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            // 예: form 초기화나 designer에서
            powder.MouseDown += powder_MouseDown;
            powder.MouseMove += powder_MouseMove;
            powder.MouseUp += powder_MouseUp;
        }

        // Start game button
        private void startButton_Click(object sender, EventArgs e)
        {
            setWaterHeightPanel_2.BringToFront();
            currentFrame = 0;
            repeatCount = 0;
            setWaterHeightScene.Image = waterImages[currentFrame];
            frameTimer.Interval = frameInterval;
            frameTimer.Start();
        }

        // Frame timer tick
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

        // Stop button
        private void stopWaterButton_Click(object sender, EventArgs e)
        {
            ShowBoilingSceneBasedOnFrame();
        }

        private void ShowBoilingSceneBasedOnFrame()
        {
            Image selectedImage;

            if (currentFrame == 0 || currentFrame == 1)
                selectedImage = Properties.Resources.lowWater;
            else if (currentFrame == 2)
                selectedImage = Properties.Resources.properWater;
            else // 3,4
                selectedImage = Properties.Resources.fullWater;

            boilingScene.Image = selectedImage;

            // Stop timer & bring water boiling panel
            frameTimer.Stop();
            waterBoilingPanel_3.BringToFront();

            // 5초 뒤 putNoodlePanel_4와 면 애니메이션 시작
            Timer delayTimer = new Timer();
            delayTimer.Interval = 5000;
            delayTimer.Tick += (s, args) =>
            {
                putNoodlePanel_4.BringToFront();
                delayTimer.Stop();
                delayTimer.Dispose();
                StartNoodleAnimation();
            };
            delayTimer.Start();
        }

        // Noodle movement start
        private void StartNoodleAnimation()
        {
            if (noodleTimer == null)
            {
                noodleTimer = new Timer();
                noodleTimer.Interval = 50;
                noodleTimer.Tick += NoodleTimer_Tick;
            }

            noodle.Left = 0;
            noodleDirection = 1;
            noodleStartTime = DateTime.Now; // 시작 시간 기록
            noodleTimer.Start();
        }

        // 1️⃣ Noodle 좌우 이동 Timer
        private void NoodleTimer_Tick(object sender, EventArgs e)
        {
            // 좌우 이동
            noodle.Left += noodleSpeed * noodleDirection;
            if (noodle.Left <= 0 || noodle.Right >= putNoodlePanel_4.Width)
                noodleDirection *= -1;

            // 10초 경과 시
            if ((DateTime.Now - noodleStartTime).TotalSeconds >= 10)
            {
                noodleTimer.Stop();       // 좌우 이동 멈춤
                StartNoodleFall();        // 아래로 떨어뜨리는 Timer 시작
            }
        }

        // 2️⃣ 아래로 떨어뜨리는 Timer 시작
        private void StartNoodleFall()
        {
            if (noodleFallTimer == null)
            {
                noodleFallTimer = new Timer();
                noodleFallTimer.Interval = 50;
                noodleFallTimer.Tick += NoodleFallTimer_Tick;
            }

            noodleFallTimer.Start();
        }

        // 3️⃣ 아래로 떨어지면서 영역 체크
        private void NoodleFallTimer_Tick(object sender, EventArgs e)
        {
            noodle.Top += 10; // 떨어지는 속도

            if (noodle.Bottom >= putNoodlePanel_4.Height - 175)
            {
                noodleFallTimer.Stop();

                // ← 여기서 왼쪽 꼭짓점 기준 체크
                if (targetArea.Contains(noodle.Left, noodle.Top))
                {
                    noodleInWaterScene.Image = Properties.Resources.noodleInWater; // 영역 안
                    putPowderScene.Image = Properties.Resources.putPowderYesNoodle;
                    putPowderScene.Tag = "putPowderYesNoodle";
                }
                else
                {
                    noodleInWaterScene.Image = Properties.Resources.noodleNotInWater; // 영역 밖
                    putPowderScene.Image = Properties.Resources.putPowderNoNoodle;
                    putPowderScene.Tag = "putPowderNoNoodle";
                }
                noodleInWaterPanel_5.BringToFront(); // 다음 패널로 전환

                Timer delayTimer = new Timer();
                delayTimer.Interval = 5000;
                delayTimer.Tick += (s, args) =>
                {
                    putPowderPanel_6.BringToFront();
                    delayTimer.Stop();
                    delayTimer.Dispose();
                };
                delayTimer.Start();
            }
        }

        // KeyDown event → block space key
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void inNoodle_Click(object sender, EventArgs e)
        {
            noodleTimer.Stop();
            StartNoodleFall();
        }

        private void powder_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Control c = sender as Control;
                if (c != null)
                {
                    c.Left += e.X - xPos;
                    c.Top += e.Y - yPos;

                    c.Parent.Invalidate();
                    c.Parent.Update();

                    // 영역 체크
                    if (powderTargetArea.IntersectsWith(c.Bounds))
                    {
                        // 영역 안 → GIF 재생
                        if (putPowderScene.Tag?.ToString() == "putPowderNoNoodle")
                        {
                            putPowderScene.Image = Properties.Resources.boilingNoNoodle;
                            ImageAnimator.Animate(putPowderScene.Image, OnFrameChanged);
                        }
                        else if (putPowderScene.Tag?.ToString() == "putPowderYesNoodle")
                        {
                            putPowderScene.Image = Properties.Resources.boilingYesNoodle;
                            ImageAnimator.Animate(putPowderScene.Image, OnFrameChanged);
                        }
                    }
                    else
                    {
                        // 영역 밖 → GIF 정지
                        ImageAnimator.StopAnimate(putPowderScene.Image, OnFrameChanged);

                        if (putPowderScene.Tag?.ToString() == "putPowderNoNoodle")
                            putPowderScene.Image = Properties.Resources.putPowderNoNoodle;
                        else if (putPowderScene.Tag?.ToString() == "putPowderYesNoodle")
                            putPowderScene.Image = Properties.Resources.putPowderYesNoodle;
                    }
                }
            }
        }

        // GIF 프레임 갱신 이벤트
        private void OnFrameChanged(object sender, EventArgs e)
        {
            putPowderScene.Invalidate();
        }


        private void powder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
                powder.BringToFront();
                Cursor = Cursors.Hand;
            }
        }

        private void powder_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
                Cursor = Cursors.Default;
            }
        }
    }

    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            // 더블 버퍼링 활성화
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}
