
namespace final_08156111
{
    partial class GameForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.storyTimer = new System.Windows.Forms.Timer(this.components);
            this.foodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DialogeBox = new System.Windows.Forms.PictureBox();
            this.talkLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.LifePictureBox = new System.Windows.Forms.PictureBox();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.g8Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DialogeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storyTimer
            // 
            this.storyTimer.Enabled = true;
            this.storyTimer.Interval = 50;
            this.storyTimer.Tick += new System.EventHandler(this.LifeTimer_Tick);
            // 
            // foodButton
            // 
            this.foodButton.BackColor = System.Drawing.Color.Bisque;
            this.foodButton.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foodButton.Location = new System.Drawing.Point(22, 12);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(85, 42);
            this.foodButton.TabIndex = 1;
            this.foodButton.Text = "放飯";
            this.foodButton.UseVisualStyleBackColor = false;
            this.foodButton.Visible = false;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "吃再多都不會胖";
            this.label1.Visible = false;
            // 
            // DialogeBox
            // 
            this.DialogeBox.BackColor = System.Drawing.Color.Transparent;
            this.DialogeBox.Image = ((System.Drawing.Image)(resources.GetObject("DialogeBox.Image")));
            this.DialogeBox.Location = new System.Drawing.Point(41, 315);
            this.DialogeBox.Name = "DialogeBox";
            this.DialogeBox.Size = new System.Drawing.Size(400, 120);
            this.DialogeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DialogeBox.TabIndex = 6;
            this.DialogeBox.TabStop = false;
            this.DialogeBox.Visible = false;
            // 
            // talkLabel
            // 
            this.talkLabel.AutoSize = true;
            this.talkLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.talkLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.talkLabel.Location = new System.Drawing.Point(72, 328);
            this.talkLabel.Name = "talkLabel";
            this.talkLabel.Size = new System.Drawing.Size(46, 23);
            this.talkLabel.TabIndex = 7;
            this.talkLabel.Text = "安安";
            this.talkLabel.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Bisque;
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.continueButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.continueButton.Location = new System.Drawing.Point(307, 387);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(110, 31);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "continue...";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // LifePictureBox
            // 
            this.LifePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LifePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LifePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LifePictureBox.Image")));
            this.LifePictureBox.Location = new System.Drawing.Point(22, 60);
            this.LifePictureBox.Name = "LifePictureBox";
            this.LifePictureBox.Size = new System.Drawing.Size(44, 55);
            this.LifePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LifePictureBox.TabIndex = 9;
            this.LifePictureBox.TabStop = false;
            this.LifePictureBox.Visible = false;
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lifeLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lifeLabel.Location = new System.Drawing.Point(72, 76);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(127, 25);
            this.lifeLabel.TabIndex = 10;
            this.lifeLabel.Text = "12/24 (+12)";
            this.lifeLabel.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.returnButton.ForeColor = System.Drawing.Color.Red;
            this.returnButton.Location = new System.Drawing.Point(177, 277);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(113, 35);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "重新開始";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // lifeTimer
            // 
            this.lifeTimer.Interval = 1000;
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick_1);
            // 
            // g8Label
            // 
            this.g8Label.AutoSize = true;
            this.g8Label.BackColor = System.Drawing.Color.Red;
            this.g8Label.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.g8Label.ForeColor = System.Drawing.Color.White;
            this.g8Label.Location = new System.Drawing.Point(72, 328);
            this.g8Label.Name = "g8Label";
            this.g8Label.Size = new System.Drawing.Size(334, 23);
            this.g8Label.TabIndex = 12;
            this.g8Label.Text = "寵物的生命無法重來，就像這個遊戲一樣";
            this.g8Label.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::final_08156111.Properties.Resources.故事1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(468, 466);
            this.Controls.Add(this.g8Label);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.LifePictureBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.talkLabel);
            this.Controls.Add(this.DialogeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodButton);
            this.Name = "GameForm";
            this.Text = "電子貓";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.DialogeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer storyTimer;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DialogeBox;
        private System.Windows.Forms.Label talkLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.PictureBox LifePictureBox;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label g8Label;
    }
}

