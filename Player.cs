using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Player
    {
        public int xpos = 0;
        public int ypos = 0;

       

        public int score { get; set; }



        public Player()
        {
            


        }



        public void MoveUp()
        {
            if(ypos + 50 > 350)
            {
                ypos += 0;
                xpos += 0;
            }
            else
            {
                ypos += 50;
                xpos += 0;
            }
        }

        public void MoveDown()
        {
            if(ypos - 50 < 0)
            {
                ypos -= 0;
                xpos += 0;
            }
            else
            {
                xpos += 0;
                ypos -= 50;
            }
            

        }

        public void MoveRight()
        {
            xpos += 50;
            ypos += 0;
        }

        public void MoveLeft()
        {
            xpos -= 50;
            ypos += 0;
        }


    }
}
