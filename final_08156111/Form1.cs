using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_08156111
{
    public partial class GameForm : System.Windows.Forms.Form
    {
        int count = 0;
        int life = 0;
        int lifeSituation = 12;
        public GameForm()
        {
            InitializeComponent();
            
        }
        private void LifeTimer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 30)
            {
                storyTimer.Enabled = false;
                DialogeBox.Visible = true;
                talkLabel.Visible = true;
                talkLabel.Text = "遭遺棄的貓咪，被放在雨天的屋簷下";
                continueButton.Visible = true;
            }
            else if (count > 50 && count < 60)
            {
                continueButton.Visible = false;
                talkLabel.Visible = false;
                DialogeBox.Visible = false;
            }
            else if (count == 60)
            {
                talkLabel.Visible = true;
                DialogeBox.Visible = true;
                talkLabel.Text = "你肯定餓了";
                storyTimer.Enabled = false;
                continueButton.Visible = true;
            }
           
            else if (count > 60) 
            {
                lifeTimer.Enabled = true;
            }
        }

        private void lifeTimer_Tick_1(object sender, EventArgs e)
        {
            storyTimer.Enabled = false;
            //飽食度控制
            life++;
            lifeLabel.Text = (lifeSituation - life).ToString() + "/24";
            if ((lifeSituation - life)>12)
            {
                LifePictureBox.Image = Properties.Resources.生命狀態;
            }
            if ((lifeSituation - life) <= 12 && (lifeSituation - life) >= 10)
            {
                DialogeBox.Visible = true;
                talkLabel.Visible = true;
                talkLabel.Text = "他有點餓了，該餵飯囉";
            }
            else if ((lifeSituation - life) <= 6 && (lifeSituation - life)>0)
            {
                talkLabel.Text = "他很餓了，該餵飯囉";
            }
            else if ((lifeSituation - life) < 0 && (lifeSituation - life)>-20)
            {
                talkLabel.Text = "他餓爆了，該餵飯囉";
                LifePictureBox.Image = Properties.Resources.生命狀態_中毒;
            }
            if((lifeSituation - life) == -20)
            {
                LifePictureBox.Image = Properties.Resources.生命狀態_死掉;
                this.BackgroundImage = Properties.Resources.故事4;
                lifeLabel.Visible = false;
                DialogeBox.Visible = true;
                talkLabel.Visible = true;
                continueButton.Visible = true;
                foodButton.Visible = false;
                label1.Visible = false;
                storyTimer.Enabled = true; 
                talkLabel.Text = "他死了，你是個糟糕的飼主";
                lifeTimer.Enabled = false;
            }
            if((lifeSituation - life) <= -30)
            {
                gameover();
            }
            
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //劇情的進行
            if (talkLabel.Text.Equals("遭遺棄的貓咪，被放在雨天的屋簷下"))
            {
                talkLabel.Text = "帶回家吧";
            }
            if (talkLabel.Text.Equals("帶回家吧"))
            {
                this.BackgroundImage = Properties.Resources.故事2;
                storyTimer.Enabled = true;
            }
            if (talkLabel.Text.Equals("你肯定餓了"))
            {
                talkLabel.Text = "吃點東西吧";
                foodButton.Visible = true;
                label1.Visible = true;
                label1.Text = "<- 請點擊";
                foodButton.Visible = true;
                continueButton.Visible = false;
            }
            if (talkLabel.Text.Equals("他死了，你是個糟糕的飼主"))
            {
                lifeTimer.Enabled = false;
                this.BackgroundImage = Properties.Resources.故事5;
                talkLabel.Text = "..."; 
                continueButton.Text = "對不起";
                lifeTimer.Enabled = true;
            }
        }
        void gameover()
        {
            //壞結局
            DialogeBox.Visible = false;
            talkLabel.Visible = false;
            foodButton.Visible = false;
            label1.Visible = false;
            //DialogeButton.Visible = false;
            continueButton.Visible = false;
            LifePictureBox.Visible = false;
            lifeLabel.Visible = false;
            this.BackgroundImage = Properties.Resources.壞結局1;
            returnButton.Visible = true;
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            //放飯囉
            if (foodButton.Text=="放飯")
            {
                //東西先關掉
                talkLabel.Visible = false;
                continueButton.Visible = false;
                DialogeBox.Visible = false;
                //第一次需要顯示但後面都不用再一次
                label1.Text = "一天要餵兩餐";
                LifePictureBox.Visible = true;
                lifeLabel.Visible = true;
                //重點：計算
                if (24 - (lifeSituation - life) < 12)
                {
                    lifeLabel.Text = (lifeSituation-life).ToString() + "/24+" + (24 - (lifeSituation - life)).ToString();
                }
                else
                {
                    lifeLabel.Text = (lifeSituation-life).ToString() + "/24+12";
                }
                this.BackgroundImage = Properties.Resources.故事3;
                foodButton.Text = "吃飽";
                lifeTimer.Enabled = false;

            }
            else
            {
                //重點：計算
                if ((lifeSituation - life) >= 12)
                {
                    lifeSituation += 24 - (lifeSituation - life)+1;
                }
                else
                {
                    lifeSituation += 12 + 1;
                }
                foodButton.Text = "放飯";
                this.BackgroundImage = Properties.Resources.故事2;
                lifeTimer.Enabled = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            g8Label.Visible = true;
        }
    }
}
