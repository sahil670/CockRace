using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockRace
{
    public class CockGreyhound
    {
        //Global variables
        public int SPos;
        public int RTLen;
        public PictureBox MPBox = null;
        public int Lo = 0;
        public Random MRan;

        public bool Run()//Run funtion for running the car pictures
        {
            MRan = new Random();//make a random variable
            int distance = MRan.Next(1, 5);//set the value of distance vaiable

            MoveMPBox(distance);//calling the movepicturebox funtion

            Lo += distance;//increasing the value of distance is assigned in Lo it means Lo is changed
            if (Lo >= (RTLen - SPos))
            {
                return true;
            }
            return false;
        }

        public void TakeSPos()//this is for aetting the starting position
        {
            MoveMPBox(-Lo);
            Lo = 0;
        }

        public void MoveMPBox(int distance)//this function for moving the picture boxes
        {
            Point p = MPBox.Location;
            p.X += distance;
            MPBox.Location = p;
        }
    }
}
