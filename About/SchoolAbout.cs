using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.About
{
    public partial class SchoolAbout : Form
    {
        public SchoolAbout()
        {
            InitializeComponent();
        }
        int index = 0;
        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_Ltime.BackgroundImageLayout = ImageLayout.Zoom;
            //pb_Ltime.BackgroundImageLayout = ImageLayout.Tile;
            if (index < li_AboutImg.Images.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            

            if (index == rand.Next(1,4))
            {
                pb_Ltime.BackgroundImageLayout = ImageLayout.Zoom;
            }
            this.pb_Ltime.BackgroundImage = li_AboutImg.Images[index];
        }

        private void pb_Ltime_Click(object sender, EventArgs e)
        {

        }
    }
}
