namespace COM_Ramen
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startPanel_1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.startScene = new System.Windows.Forms.PictureBox();
            this.setWaterHeightPanel_2 = new System.Windows.Forms.Panel();
            this.stopWaterButton = new System.Windows.Forms.Button();
            this.setWaterHeightScene = new System.Windows.Forms.PictureBox();
            this.waterBoilingPanel_3 = new System.Windows.Forms.Panel();
            this.boilingScene = new System.Windows.Forms.PictureBox();
            this.putNoodlePanel_4 = new System.Windows.Forms.Panel();
            this.inNoodle = new System.Windows.Forms.Button();
            this.noodle = new System.Windows.Forms.PictureBox();
            this.putNoodleScene = new System.Windows.Forms.PictureBox();
            this.putPowderPanel_6 = new System.Windows.Forms.Panel();
            this.powder = new System.Windows.Forms.PictureBox();
            this.putPowderScene = new System.Windows.Forms.PictureBox();
            this.boilingFinalRamenPanel_7 = new System.Windows.Forms.Panel();
            this.boilingFinalRamenScene = new System.Windows.Forms.PictureBox();
            this.finishPanel_8 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.finalScene = new System.Windows.Forms.PictureBox();
            this.noodleInWaterPanel_5 = new System.Windows.Forms.Panel();
            this.noodleInWaterScene = new System.Windows.Forms.PictureBox();
            this.startPanel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startScene)).BeginInit();
            this.setWaterHeightPanel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setWaterHeightScene)).BeginInit();
            this.waterBoilingPanel_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boilingScene)).BeginInit();
            this.putNoodlePanel_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noodle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putNoodleScene)).BeginInit();
            this.putPowderPanel_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putPowderScene)).BeginInit();
            this.boilingFinalRamenPanel_7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boilingFinalRamenScene)).BeginInit();
            this.finishPanel_8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalScene)).BeginInit();
            this.noodleInWaterPanel_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noodleInWaterScene)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel_1
            // 
            this.startPanel_1.Controls.Add(this.startButton);
            this.startPanel_1.Controls.Add(this.startScene);
            this.startPanel_1.Location = new System.Drawing.Point(57, 124);
            this.startPanel_1.Name = "startPanel_1";
            this.startPanel_1.Size = new System.Drawing.Size(200, 100);
            this.startPanel_1.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Ivory;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(740, 894);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(360, 84);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startScene
            // 
            this.startScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startScene.Image = global::COM_Ramen.Properties.Resources.startScene;
            this.startScene.Location = new System.Drawing.Point(0, 0);
            this.startScene.Name = "startScene";
            this.startScene.Size = new System.Drawing.Size(200, 100);
            this.startScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startScene.TabIndex = 0;
            this.startScene.TabStop = false;
            // 
            // setWaterHeightPanel_2
            // 
            this.setWaterHeightPanel_2.Controls.Add(this.stopWaterButton);
            this.setWaterHeightPanel_2.Controls.Add(this.setWaterHeightScene);
            this.setWaterHeightPanel_2.Location = new System.Drawing.Point(285, 104);
            this.setWaterHeightPanel_2.Name = "setWaterHeightPanel_2";
            this.setWaterHeightPanel_2.Size = new System.Drawing.Size(235, 143);
            this.setWaterHeightPanel_2.TabIndex = 1;
            // 
            // stopWaterButton
            // 
            this.stopWaterButton.AutoSize = true;
            this.stopWaterButton.BackColor = System.Drawing.Color.Ivory;
            this.stopWaterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopWaterButton.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.stopWaterButton.FlatAppearance.BorderSize = 3;
            this.stopWaterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopWaterButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWaterButton.Location = new System.Drawing.Point(1260, 800);
            this.stopWaterButton.Name = "stopWaterButton";
            this.stopWaterButton.Size = new System.Drawing.Size(360, 84);
            this.stopWaterButton.TabIndex = 2;
            this.stopWaterButton.Text = "Stop";
            this.stopWaterButton.UseVisualStyleBackColor = false;
            this.stopWaterButton.Click += new System.EventHandler(this.stopWaterButton_Click);
            // 
            // setWaterHeightScene
            // 
            this.setWaterHeightScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setWaterHeightScene.Image = global::COM_Ramen.Properties.Resources.setWaterHeight1;
            this.setWaterHeightScene.Location = new System.Drawing.Point(0, 0);
            this.setWaterHeightScene.Name = "setWaterHeightScene";
            this.setWaterHeightScene.Size = new System.Drawing.Size(235, 143);
            this.setWaterHeightScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setWaterHeightScene.TabIndex = 0;
            this.setWaterHeightScene.TabStop = false;
            // 
            // waterBoilingPanel_3
            // 
            this.waterBoilingPanel_3.Controls.Add(this.boilingScene);
            this.waterBoilingPanel_3.Location = new System.Drawing.Point(526, 124);
            this.waterBoilingPanel_3.Name = "waterBoilingPanel_3";
            this.waterBoilingPanel_3.Size = new System.Drawing.Size(221, 123);
            this.waterBoilingPanel_3.TabIndex = 2;
            // 
            // boilingScene
            // 
            this.boilingScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boilingScene.Location = new System.Drawing.Point(0, 0);
            this.boilingScene.Name = "boilingScene";
            this.boilingScene.Size = new System.Drawing.Size(221, 123);
            this.boilingScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boilingScene.TabIndex = 0;
            this.boilingScene.TabStop = false;
            // 
            // putNoodlePanel_4
            // 
            this.putNoodlePanel_4.Controls.Add(this.inNoodle);
            this.putNoodlePanel_4.Controls.Add(this.noodle);
            this.putNoodlePanel_4.Controls.Add(this.putNoodleScene);
            this.putNoodlePanel_4.Location = new System.Drawing.Point(414, 495);
            this.putNoodlePanel_4.Name = "putNoodlePanel_4";
            this.putNoodlePanel_4.Size = new System.Drawing.Size(658, 383);
            this.putNoodlePanel_4.TabIndex = 3;
            // 
            // inNoodle
            // 
            this.inNoodle.BackColor = System.Drawing.Color.Ivory;
            this.inNoodle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inNoodle.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.inNoodle.FlatAppearance.BorderSize = 3;
            this.inNoodle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inNoodle.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNoodle.Location = new System.Drawing.Point(1378, 826);
            this.inNoodle.Name = "inNoodle";
            this.inNoodle.Size = new System.Drawing.Size(326, 110);
            this.inNoodle.TabIndex = 2;
            this.inNoodle.Text = "In!";
            this.inNoodle.UseVisualStyleBackColor = false;
            this.inNoodle.Click += new System.EventHandler(this.inNoodle_Click);
            // 
            // noodle
            // 
            this.noodle.BackColor = System.Drawing.Color.Transparent;
            this.noodle.Image = global::COM_Ramen.Properties.Resources.noodleStraight;
            this.noodle.Location = new System.Drawing.Point(260, 323);
            this.noodle.Name = "noodle";
            this.noodle.Size = new System.Drawing.Size(293, 282);
            this.noodle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noodle.TabIndex = 1;
            this.noodle.TabStop = false;
            // 
            // putNoodleScene
            // 
            this.putNoodleScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.putNoodleScene.Image = global::COM_Ramen.Properties.Resources.putNoodle;
            this.putNoodleScene.Location = new System.Drawing.Point(0, 0);
            this.putNoodleScene.Name = "putNoodleScene";
            this.putNoodleScene.Size = new System.Drawing.Size(658, 383);
            this.putNoodleScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.putNoodleScene.TabIndex = 0;
            this.putNoodleScene.TabStop = false;
            // 
            // putPowderPanel_6
            // 
            this.putPowderPanel_6.Controls.Add(this.powder);
            this.putPowderPanel_6.Controls.Add(this.putPowderScene);
            this.putPowderPanel_6.Location = new System.Drawing.Point(769, 78);
            this.putPowderPanel_6.Name = "putPowderPanel_6";
            this.putPowderPanel_6.Size = new System.Drawing.Size(425, 343);
            this.putPowderPanel_6.TabIndex = 3;
            // 
            // powder
            // 
            this.powder.BackColor = System.Drawing.Color.Transparent;
            this.powder.Image = global::COM_Ramen.Properties.Resources.powder;
            this.powder.Location = new System.Drawing.Point(101, 302);
            this.powder.Name = "powder";
            this.powder.Size = new System.Drawing.Size(345, 336);
            this.powder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.powder.TabIndex = 1;
            this.powder.TabStop = false;
            // 
            // putPowderScene
            // 
            this.putPowderScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.putPowderScene.Image = global::COM_Ramen.Properties.Resources.putPowderYesNoodle;
            this.putPowderScene.Location = new System.Drawing.Point(0, 0);
            this.putPowderScene.Name = "putPowderScene";
            this.putPowderScene.Size = new System.Drawing.Size(425, 343);
            this.putPowderScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.putPowderScene.TabIndex = 0;
            this.putPowderScene.TabStop = false;
            // 
            // boilingFinalRamenPanel_7
            // 
            this.boilingFinalRamenPanel_7.Controls.Add(this.boilingFinalRamenScene);
            this.boilingFinalRamenPanel_7.Location = new System.Drawing.Point(1228, 124);
            this.boilingFinalRamenPanel_7.Name = "boilingFinalRamenPanel_7";
            this.boilingFinalRamenPanel_7.Size = new System.Drawing.Size(200, 100);
            this.boilingFinalRamenPanel_7.TabIndex = 3;
            // 
            // boilingFinalRamenScene
            // 
            this.boilingFinalRamenScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boilingFinalRamenScene.Location = new System.Drawing.Point(0, 0);
            this.boilingFinalRamenScene.Name = "boilingFinalRamenScene";
            this.boilingFinalRamenScene.Size = new System.Drawing.Size(200, 100);
            this.boilingFinalRamenScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boilingFinalRamenScene.TabIndex = 0;
            this.boilingFinalRamenScene.TabStop = false;
            // 
            // finishPanel_8
            // 
            this.finishPanel_8.Controls.Add(this.resetButton);
            this.finishPanel_8.Controls.Add(this.finalScene);
            this.finishPanel_8.Location = new System.Drawing.Point(1324, 293);
            this.finishPanel_8.Name = "finishPanel_8";
            this.finishPanel_8.Size = new System.Drawing.Size(200, 100);
            this.finishPanel_8.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Ivory;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(1445, 841);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(234, 80);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // finalScene
            // 
            this.finalScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalScene.Image = global::COM_Ramen.Properties.Resources.finalSceneNoRamen;
            this.finalScene.Location = new System.Drawing.Point(0, 0);
            this.finalScene.Name = "finalScene";
            this.finalScene.Size = new System.Drawing.Size(200, 100);
            this.finalScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalScene.TabIndex = 0;
            this.finalScene.TabStop = false;
            // 
            // noodleInWaterPanel_5
            // 
            this.noodleInWaterPanel_5.Controls.Add(this.noodleInWaterScene);
            this.noodleInWaterPanel_5.Location = new System.Drawing.Point(184, 321);
            this.noodleInWaterPanel_5.Name = "noodleInWaterPanel_5";
            this.noodleInWaterPanel_5.Size = new System.Drawing.Size(200, 100);
            this.noodleInWaterPanel_5.TabIndex = 4;
            // 
            // noodleInWaterScene
            // 
            this.noodleInWaterScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noodleInWaterScene.Location = new System.Drawing.Point(0, 0);
            this.noodleInWaterScene.Name = "noodleInWaterScene";
            this.noodleInWaterScene.Size = new System.Drawing.Size(200, 100);
            this.noodleInWaterScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noodleInWaterScene.TabIndex = 0;
            this.noodleInWaterScene.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.finishPanel_8);
            this.Controls.Add(this.putPowderPanel_6);
            this.Controls.Add(this.noodleInWaterPanel_5);
            this.Controls.Add(this.putNoodlePanel_4);
            this.Controls.Add(this.waterBoilingPanel_3);
            this.Controls.Add(this.setWaterHeightPanel_2);
            this.Controls.Add(this.startPanel_1);
            this.Controls.Add(this.boilingFinalRamenPanel_7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM:Ramen (Version: 1.0.0)";
            this.startPanel_1.ResumeLayout(false);
            this.startPanel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startScene)).EndInit();
            this.setWaterHeightPanel_2.ResumeLayout(false);
            this.setWaterHeightPanel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setWaterHeightScene)).EndInit();
            this.waterBoilingPanel_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boilingScene)).EndInit();
            this.putNoodlePanel_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noodle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putNoodleScene)).EndInit();
            this.putPowderPanel_6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.powder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putPowderScene)).EndInit();
            this.boilingFinalRamenPanel_7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boilingFinalRamenScene)).EndInit();
            this.finishPanel_8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalScene)).EndInit();
            this.noodleInWaterPanel_5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noodleInWaterScene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel_1;
        private System.Windows.Forms.Panel setWaterHeightPanel_2;
        private System.Windows.Forms.Panel waterBoilingPanel_3;
        private System.Windows.Forms.Panel putNoodlePanel_4;
        private System.Windows.Forms.Panel putPowderPanel_6;
        private System.Windows.Forms.Panel boilingFinalRamenPanel_7;
        private System.Windows.Forms.Panel finishPanel_8;
        private System.Windows.Forms.PictureBox startScene;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox setWaterHeightScene;
        private System.Windows.Forms.Button stopWaterButton;
        private System.Windows.Forms.PictureBox boilingScene;
        private System.Windows.Forms.PictureBox putNoodleScene;
        private System.Windows.Forms.PictureBox noodle;
        private System.Windows.Forms.Button inNoodle;
        private System.Windows.Forms.Panel noodleInWaterPanel_5;
        private System.Windows.Forms.PictureBox noodleInWaterScene;
        private System.Windows.Forms.PictureBox putPowderScene;
        private System.Windows.Forms.PictureBox powder;
        private System.Windows.Forms.PictureBox boilingFinalRamenScene;
        private System.Windows.Forms.PictureBox finalScene;
        private System.Windows.Forms.Button resetButton;
    }
}

