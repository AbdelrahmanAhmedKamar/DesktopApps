using Memory_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        Image[] images = new Image[16];

        bool isFirstClick = true;

        Button PrevPicture;
        Button CurrentPicture;

        byte PrevTag, NumberOfIdenticalClicks = 0,
            CountDurationGame = 30;

        void FillArrayImages() 
        {
            images[0] = Resources.Cat;
            images[1] = Resources.Dog;
            images[2] = Resources.Lion;
            images[3] = Resources.Trutle;
            images[4] = Resources.Panda;
            images[5] = Resources.Penguin;
            images[6] = Resources.Checken;
            images[7] = Resources.Monkey;

            images[8] = Resources.Cat;
            images[9] = Resources.Dog;
            images[10] = Resources.Lion;
            images[11] = Resources.Trutle;
            images[12] = Resources.Panda;
            images[13] = Resources.Penguin;
            images[14] = Resources.Checken;
            images[15] = Resources.Monkey;

        }

        byte RandomNumber(byte From, byte To)
        {
            return Convert.ToByte(rnd.Next(From, To));
        }

        void SwappingArrayImages(Image[] Images,byte index1,byte index2 ) 
        {
            Image temp = images[index1];
            images[index1] = Images[index2];
            images[index2] = temp;

        }


        void EnabledPictures()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;
        }

        void DisabledPictures()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btn16.Enabled = false;
        }

        void FillCardsToImages() 
        {
            btn1.BackgroundImage = images[0];
            btn2.BackgroundImage = images[1];
            btn3.BackgroundImage = images[2];
            btn4.BackgroundImage = images[3];
            btn5.BackgroundImage = images[4];
            btn6.BackgroundImage = images[5];
            btn7.BackgroundImage = images[6];
            btn8.BackgroundImage = images[7];
            btn9.BackgroundImage = images[8];
            btn10.BackgroundImage = images[9];
            btn11.BackgroundImage = images[10];
            btn12.BackgroundImage = images[11];
            btn13.BackgroundImage = images[12];
            btn14.BackgroundImage = images[13];
            btn15.BackgroundImage = images[14];
            btn16.BackgroundImage = images[15];
        }

        void ChangePicturesRandomly() 
        {
            FillArrayImages();

            for(byte i = 0;i<16;i++) 
            {
                SwappingArrayImages(images, RandomNumber(0, 16),
                                            RandomNumber(0, 16));
            }

            FillCardsToImages();
        }

        void FillPicturesBoxToQuestionImage() 
        {
            btn1.BackgroundImage = Resources.Question;
            btn2.BackgroundImage = Resources.Question;
            btn3.BackgroundImage = Resources.Question;
            btn4.BackgroundImage = Resources.Question;
            btn5.BackgroundImage = Resources.Question;
            btn6.BackgroundImage = Resources.Question;
            btn7.BackgroundImage = Resources.Question;
            btn8.BackgroundImage = Resources.Question;
            btn9.BackgroundImage = Resources.Question;
            btn10.BackgroundImage = Resources.Question;
            btn11.BackgroundImage = Resources.Question;
            btn12.BackgroundImage = Resources.Question;
            btn13.BackgroundImage = Resources.Question;
            btn14.BackgroundImage = Resources.Question;
            btn15.BackgroundImage = Resources.Question;
            btn16.BackgroundImage = Resources.Question;

        }

        bool AreImagesEqual(Image img1,Image img2) 
        {
            Bitmap bitmap1 = new Bitmap(img1);
            Bitmap bitmap2 = new Bitmap(img2);

            if(bitmap1.Width!=bitmap2.Width || bitmap1.Height!=bitmap2.Height) 
                return false;

            for (int x = 0; x < bitmap1.Width; x++) 
            {
                for(int y = 0; y < bitmap2.Height; y++) 
                {
                    if (bitmap1.GetPixel(x, y) != bitmap2.GetPixel(x, y)) 
                    {
                        return false;
                    }
                }
            }

            return true;
            
        }

        void Win() 
        {
            NumberOfIdenticalClicks = 0;
            tmDurationGame.Stop();
            MessageBox.Show("Congratulations, you win! \n" + "The duration it took was " + (30 - CountDurationGame - 1) + " seconds ", "Win",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CountDurationGame = 30;
            btnStart.Enabled = true;
        }

        void Play (Button btn)
        {
            if (isFirstClick) 
            {
                // The first click

                byte tag = Convert.ToByte(btn.Tag);

                btn.BackgroundImage = images[tag];
                
                PrevPicture=btn;
                PrevTag = tag;

                btn.Enabled = false;

                isFirstClick = false;
            }
            else
            {
                // The second click

                Image img = images[Convert.ToByte(btn.Tag)];
                btn.BackgroundImage = img;


                btn.Enabled = false;

                CurrentPicture = btn;

                if (AreImagesEqual(images[PrevTag], img))  
                {
                    // The two pictures are identical

                    btn.BackgroundImage=img;
                    PrevPicture.BackgroundImage = images[PrevTag];

                    PrevPicture.Enabled = false;
                    NumberOfIdenticalClicks++;

                    if (NumberOfIdenticalClicks == 8)
                    {
                        // If all pictures match he wins

                        Win();
                    }
                }
                else 
                {
                    tmShowImageForMoment.Start();   
                }

                isFirstClick = true;

            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ChangePicturesRandomly();
            tmStartGame.Start();
        }

        private void btnQuestionImg(object sender, EventArgs e)
        {
            Play((Button)sender);
        }

        void DurationExpired() 
        {
            CountDurationGame = 31;
            tmDurationGame.Stop();
            NumberOfIdenticalClicks = 0;
            DisabledPictures();
            MessageBox.Show("Game Over", "Game Over",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnStart.Enabled = true;
        }
        private void tmDurationGame_Tick(object sender, EventArgs e)
        {
            lblGameDuration.Text = CountDurationGame.ToString() + " s";

            if (CountDurationGame == 0)
            {
                DurationExpired();
            }
            CountDurationGame--;
        }

        private void tmShowImageForMoment_Tick(object sender, EventArgs e)
        {
            PrevPicture.BackgroundImage = Resources.Question;
            CurrentPicture.BackgroundImage = Resources.Question; 
            
            PrevPicture.Enabled=true;
            CurrentPicture.Enabled = true;

            tmShowImageForMoment.Stop();    

        }

        private void tmStartGame_Tick(object sender, EventArgs e)
        {
            FillPicturesBoxToQuestionImage();
            EnabledPictures();
            tmDurationGame.Start();
            btnStart.Enabled = false;
            tmStartGame.Stop();
        }
    }
}
