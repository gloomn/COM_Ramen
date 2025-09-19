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
            this.setWaterHeightPanel_2 = new System.Windows.Forms.Panel();
            this.waterBoilingPanel_3 = new System.Windows.Forms.Panel();
            this.putNoodlePanel_4 = new System.Windows.Forms.Panel();
            this.putPowderPanel_5 = new System.Windows.Forms.Panel();
            this.boilingFinalRamenPanel_6 = new System.Windows.Forms.Panel();
            this.finishPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopWaterButton = new System.Windows.Forms.Button();
            this.setWaterHeightScene = new System.Windows.Forms.PictureBox();
            this.startScene = new System.Windows.Forms.PictureBox();
            this.startPanel_1.SuspendLayout();
            this.setWaterHeightPanel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setWaterHeightScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScene)).BeginInit();
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
            // setWaterHeightPanel_2
            // 
            this.setWaterHeightPanel_2.Controls.Add(this.stopWaterButton);
            this.setWaterHeightPanel_2.Controls.Add(this.setWaterHeightScene);
            this.setWaterHeightPanel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setWaterHeightPanel_2.Location = new System.Drawing.Point(0, 0);
            this.setWaterHeightPanel_2.Name = "setWaterHeightPanel_2";
            this.setWaterHeightPanel_2.Size = new System.Drawing.Size(1898, 1024);
            this.setWaterHeightPanel_2.TabIndex = 1;
            // 
            // waterBoilingPanel_3
            // 
            this.waterBoilingPanel_3.Location = new System.Drawing.Point(526, 124);
            this.waterBoilingPanel_3.Name = "waterBoilingPanel_3";
            this.waterBoilingPanel_3.Size = new System.Drawing.Size(200, 100);
            this.waterBoilingPanel_3.TabIndex = 2;
            // 
            // putNoodlePanel_4
            // 
            this.putNoodlePanel_4.Location = new System.Drawing.Point(762, 124);
            this.putNoodlePanel_4.Name = "putNoodlePanel_4";
            this.putNoodlePanel_4.Size = new System.Drawing.Size(200, 100);
            this.putNoodlePanel_4.TabIndex = 3;
            // 
            // putPowderPanel_5
            // 
            this.putPowderPanel_5.Location = new System.Drawing.Point(997, 124);
            this.putPowderPanel_5.Name = "putPowderPanel_5";
            this.putPowderPanel_5.Size = new System.Drawing.Size(200, 100);
            this.putPowderPanel_5.TabIndex = 3;
            // 
            // boilingFinalRamenPanel_6
            // 
            this.boilingFinalRamenPanel_6.Location = new System.Drawing.Point(1228, 124);
            this.boilingFinalRamenPanel_6.Name = "boilingFinalRamenPanel_6";
            this.boilingFinalRamenPanel_6.Size = new System.Drawing.Size(200, 100);
            this.boilingFinalRamenPanel_6.TabIndex = 3;
            // 
            // finishPanel
            // 
            this.finishPanel.Location = new System.Drawing.Point(1468, 124);
            this.finishPanel.Name = "finishPanel";
            this.finishPanel.Size = new System.Drawing.Size(200, 100);
            this.finishPanel.TabIndex = 3;
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
            this.setWaterHeightScene.Size = new System.Drawing.Size(1898, 1024);
            this.setWaterHeightScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setWaterHeightScene.TabIndex = 0;
            this.setWaterHeightScene.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.setWaterHeightPanel_2);
            this.Controls.Add(this.startPanel_1);
            this.Controls.Add(this.finishPanel);
            this.Controls.Add(this.boilingFinalRamenPanel_6);
            this.Controls.Add(this.putPowderPanel_5);
            this.Controls.Add(this.putNoodlePanel_4);
            this.Controls.Add(this.waterBoilingPanel_3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM:Ramen";
            this.startPanel_1.ResumeLayout(false);
            this.startPanel_1.PerformLayout();
            this.setWaterHeightPanel_2.ResumeLayout(false);
            this.setWaterHeightPanel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setWaterHeightScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel_1;
        private System.Windows.Forms.Panel setWaterHeightPanel_2;
        private System.Windows.Forms.Panel waterBoilingPanel_3;
        private System.Windows.Forms.Panel putNoodlePanel_4;
        private System.Windows.Forms.Panel putPowderPanel_5;
        private System.Windows.Forms.Panel boilingFinalRamenPanel_6;
        private System.Windows.Forms.Panel finishPanel;
        private System.Windows.Forms.PictureBox startScene;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox setWaterHeightScene;
        private System.Windows.Forms.Button stopWaterButton;
    }
}

