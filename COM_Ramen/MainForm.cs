//Copyright (C) 2025 Lee Ki Joon
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace COM_Ramen
{
    public partial class MainForm : Form
    {
        // Water frame definition
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

        // Noodle fall boundary
        private Rectangle targetArea = new Rectangle(668, 556, 400, 285); // x, y, width, height

        // Powder fall boundary
        private Rectangle powderTargetArea = new Rectangle(668, 0, 570, 500);

        // Powder drag definition
        private bool dragging;
        private int yPos;
        private int xPos;
        private bool mouseIsLocked = false;

        // Boiling water selected image definition
        Image selectedImage;

        public MainForm()
        {
            InitializeComponent();

            // Panels reset
            startPanel_1.Dock = DockStyle.Fill;
            setWaterHeightPanel_2.Dock = DockStyle.Fill;
            waterBoilingPanel_3.Dock = DockStyle.Fill;
            putNoodlePanel_4.Dock = DockStyle.Fill;
            noodleInWaterPanel_5.Dock = DockStyle.Fill;
            putPowderPanel_6.Dock = DockStyle.Fill;
            boilingFinalRamenPanel_7.Dock = DockStyle.Fill;
            finishPanel_8.Dock = DockStyle.Fill;
            startPanel_1.BringToFront();

            // Timer reset
            frameTimer_Init();

            // Call water height images from resources
            waterImages = new Image[]
            {
                Properties.Resources.setWaterHeight1,
                Properties.Resources.setWaterHeight2,
                Properties.Resources.setWaterHeight3,
                Properties.Resources.setWaterHeight4,
                Properties.Resources.setWaterHeight5
            };

            // Activate KeyPreview
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            // Powder drag event handler regist
            powder.MouseDown += powder_MouseDown;
            powder.MouseMove += powder_MouseMove;
            powder.MouseUp += powder_MouseUp;

            // For transparent background(noodle, powder)
            powder.Parent = putPowderScene;
            noodle.Parent = putNoodleScene;
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
                    // Maintain last frame
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

        // Boiling water scene -> based on frame(GIF X)
        private void ShowBoilingSceneBasedOnFrame()
        {
            // Current frame 0, 1 : low water
            if (currentFrame == 0 || currentFrame == 1)
            {
                selectedImage = Properties.Resources.lowWater;
                selectedImage.Tag = "lowWater";
            }
            // Current frame 2 : proper water
            else if (currentFrame == 2)
            {
                selectedImage = Properties.Resources.properWater;
                selectedImage.Tag = "properWater";
            }
            // Current frame 4, 5 : full water
            else
            {
                selectedImage = Properties.Resources.fullWater;
                selectedImage.Tag = "fullWater";
            }

            boilingScene.Image = selectedImage;

            // Stop timer & bring water boiling panel
            frameTimer.Stop();
            waterBoilingPanel_3.BringToFront();

            // After 5 seconds, bring putNoodlePanel_4 to front and StartNoodleAnimation()
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
            noodleStartTime = DateTime.Now; // Noodle moving start time
            noodleTimer.Start();
        }

        // Noodle movement timer
        private void NoodleTimer_Tick(object sender, EventArgs e)
        {
            // Move left and right
            noodle.Left += noodleSpeed * noodleDirection;
            if (noodle.Left <= 0 || noodle.Right >= putNoodlePanel_4.Width)
                noodleDirection *= -1;

            // After 10 seconds
            if ((DateTime.Now - noodleStartTime).TotalSeconds >= 10)
            {
                noodleTimer.Stop();       // Left right movement stop
                StartNoodleFall();        // Noodle falling timer start
            }
        }

        // Noodle falling timer start
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

        // When noodle falls, boundary check
        private void NoodleFallTimer_Tick(object sender, EventArgs e)
        {
            noodle.Top += 10; // Noodle falling speed

            if (noodle.Bottom >= putNoodlePanel_4.Height - 175)
            {
                noodleFallTimer.Stop();

                // Noodle left top corner boundary
                if (targetArea.Contains(noodle.Left, noodle.Top))
                {
                    noodleInWaterScene.Image = Properties.Resources.noodleInWater; // Target in
                    putPowderScene.Image = Properties.Resources.putPowderYesNoodle;
                    putPowderScene.Tag = "putPowderYesNoodle";
                }
                else
                {
                    noodleInWaterScene.Image = Properties.Resources.noodleNotInWater; // Target out
                    putPowderScene.Image = Properties.Resources.putPowderNoNoodle;
                    putPowderScene.Tag = "putPowderNoNoodle";
                }
                noodleInWaterPanel_5.BringToFront(); // Convert to next panel

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

        // When pressed "In" button -> Start noodle falling
        private void inNoodle_Click(object sender, EventArgs e)
        {
            noodleTimer.Stop();
            StartNoodleFall();
        }

        // When powder mouse move event
        private void powder_MouseMove(object sender, MouseEventArgs e)
        {
            Timer delayTimerFinal = new Timer();
            delayTimerFinal.Interval = 5000;
            if (dragging && !mouseIsLocked)
            {
                Control c = sender as Control;
                if (c != null)
                {
                    c.Left += e.X - xPos;
                    c.Top += e.Y - yPos;

                    c.Parent.Invalidate();
                    c.Parent.Update();


                    // Check powder boundary
                    Point topLeft = new Point(c.Left, c.Top);

                    if (powderTargetArea.Contains(topLeft))
                    {
                        dragging = false; // Target in -> drag blocked
                        mouseIsLocked = true;

                        // GIF 재생
                        if (putPowderScene.Tag?.ToString() == "putPowderNoNoodle")
                        {
                            putPowderScene.Image = Properties.Resources.boilingNoNoodle;
                            Timer delayTimer = new Timer();
                            delayTimer.Interval = 13000;
                            ImageAnimator.Animate(putPowderScene.Image, OnFrameChanged);
                            delayTimer.Tick += (s, args) =>
                            {
                                boilingFinalRamenScene.Image = Properties.Resources.noRamen;
                                boilingFinalRamenPanel_7.BringToFront();
                                delayTimer.Stop();
                                delayTimer.Dispose();
                                delayTimerFinal.Tick += (s2, args2) =>
                                {
                                    finalScene.Image = Properties.Resources.finalSceneNoRamen;
                                    finishPanel_8.BringToFront();
                                    delayTimerFinal.Stop();
                                    delayTimerFinal.Dispose();
                                };
                                delayTimerFinal.Start();
                            };
                            delayTimer.Start();

                        }
                        else if (putPowderScene.Tag?.ToString() == "putPowderYesNoodle")
                        {
                            putPowderScene.Image = Properties.Resources.boilingYesNoodle;
                            ImageAnimator.Animate(putPowderScene.Image, OnFrameChanged);
                            Timer delayTimer = new Timer();
                            delayTimer.Interval = 8000;
                            delayTimer.Tick += (s, args) =>
                            {
                                if (selectedImage.Tag?.ToString() == "lowWater")
                                {
                                    boilingFinalRamenScene.Image = Properties.Resources.lowRamen;
                                }
                                else if (selectedImage.Tag?.ToString() == "properWater")
                                {
                                    boilingFinalRamenScene.Image = Properties.Resources.properRamen;
                                }
                                else if (selectedImage.Tag?.ToString() == "fullWater")
                                {
                                    boilingFinalRamenScene.Image = Properties.Resources.fullRamen;
                                }
                                else
                                {
                                    boilingFinalRamenScene.Image = Properties.Resources.noRamen;
                                }
                                boilingFinalRamenPanel_7.BringToFront();
                                delayTimer.Stop();
                                delayTimer.Dispose();
                                delayTimerFinal.Tick += (s2, args2) =>
                                {
                                    finalScene.Image = Properties.Resources.finalSceneYesRamen;
                                    finishPanel_8.BringToFront();
                                    delayTimerFinal.Stop();
                                    delayTimerFinal.Dispose();
                                };
                                delayTimerFinal.Start();
                            };
                            delayTimer.Start();
                        }
                    }
                    else
                    {
                        // Target out -> GIF animation stops
                        ImageAnimator.StopAnimate(putPowderScene.Image, OnFrameChanged);

                        if (putPowderScene.Tag?.ToString() == "putPowderNoNoodle")
                            putPowderScene.Image = Properties.Resources.putPowderNoNoodle;
                        else if (putPowderScene.Tag?.ToString() == "putPowderYesNoodle")
                            putPowderScene.Image = Properties.Resources.putPowderYesNoodle;
                    }
                }
            }
        }

        // GIF frame renewal event
        private void OnFrameChanged(object sender, EventArgs e)
        {
            putPowderScene.Invalidate();
        }

        //When powder mouse down event
        private void powder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !mouseIsLocked)
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

        // When reset button pressed
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Stop all timers
            frameTimer?.Stop();
            noodleTimer?.Stop();
            noodleFallTimer?.Stop();

            // Reset startus variable
            currentFrame = 0;
            repeatCount = 0;
            selectedImage = null;
            dragging = false;
            mouseIsLocked = false;

            // Reset panel
            startPanel_1.BringToFront();

            // Reset images
            setWaterHeightScene.Image = waterImages[0];
            boilingScene.Image = null;
            noodleInWaterScene.Image = null;
            putPowderScene.Image = Properties.Resources.putPowderNoNoodle; // Default image
            putPowderScene.Tag = "putPowderNoNoodle";
            boilingFinalRamenScene.Image = null;
            finalScene.Image = null;

            // Reset noodle location
            noodle.Left = 260;
            noodle.Top = 323;

            // Reset powder location
            powder.Left = 101;
            powder.Top = 302;
        }

    }
}