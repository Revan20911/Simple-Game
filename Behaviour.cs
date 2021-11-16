using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Behaviour
    {
        public AI_Player ai = new AI_Player();


        private int[] origin;


        public int[] Origin
        {
            get { return origin; }
            set { this.origin = value; }
        }



        public void Move(int[] prizes)
        {

            var ppoint = prizes;

            if (ppoint[0] != ai.xpoint && ppoint[0] > ai.xpoint && ai.xpoint + 50 != 400)
            {
                ai.xpoint += 50;


            }
            else if (ppoint[0] < ai.xpoint && ai.xpoint - 50 != -50)
            {
                ai.xpoint -= 50;

            }


        }

        public void MoveDown()
        {
            ai.xpoint += 0;
            ai.ypoint += 50;
        }

        public void MoveUp()
        {
            ai.xpoint += 0;
            ai.ypoint -= 50;
        }



    }
}
