using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class AI_Player
    {
        public int xpoint { get; set; }
        public int ypoint { get; set; }

        public List<Items> a { get; set; } 
        public int score { get; set; }

        public int[] Prizes(List<Items> items)
        {
            

            items.Sort((a, b) => b.amount.CompareTo(a.amount));

            var best = items.First();
            int[] i = { best.xpoint, best.ypoint };

            return i;
        }

        public void Move()
        {

            Behaviour log = new Behaviour();

            

            log.MoveDown();

        }



   


    }

    
}
