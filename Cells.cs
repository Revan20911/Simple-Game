using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Cells
    {
        public int[] BoardPos { get; set; }
        public bool IsOccupied { get; set; }

        public List<int[]> cell = new List<int[]>();

       

     
        public void cells()
        {
            SetCells();
        }
        private void SetCells()
        {
            cell.Add(new int[] { 0, 0 });
            cell.Add(new int[] { 0, 50 });
            cell.Add(new int[] { 0, 100 });
            cell.Add(new int[] { 0, 150 });
            cell.Add(new int[] { 0, 200 });
            cell.Add(new int[] { 0, 250 });
            cell.Add(new int[] { 0, 300 });
            cell.Add(new int[] { 0, 350 });

            cell.Add(new int[] { 50, 0 });
            cell.Add(new int[] { 100, 0 });
            cell.Add(new int[] { 150, 0 });
            cell.Add(new int[] { 200, 0 });
            cell.Add(new int[] { 250, 0 });
            cell.Add(new int[] { 300, 0 });
            cell.Add(new int[] { 350, 0 });

            cell.Add(new int[] { 50, 50 });
            cell.Add(new int[] { 100, 50 });
            cell.Add(new int[] { 150, 50 });
            cell.Add(new int[] { 200, 50 });
            cell.Add(new int[] { 250, 50 });
            cell.Add(new int[] { 300, 50 });
            cell.Add(new int[] { 350, 50});

            cell.Add(new int[] { 50, 100 });
            cell.Add(new int[] { 100, 100 });
            cell.Add(new int[] { 150, 100 });
            cell.Add(new int[] { 200, 100 });
            cell.Add(new int[] { 250, 100 });
            cell.Add(new int[] { 300, 100 });
            cell.Add(new int[] { 350, 100 });

            cell.Add(new int[] { 50, 150 });
            cell.Add(new int[] { 100, 150 });
            cell.Add(new int[] { 150, 150 });
            cell.Add(new int[] { 200, 150 });
            cell.Add(new int[] { 250, 150 });
            cell.Add(new int[] { 300, 150 });
            cell.Add(new int[] { 350, 150 });

            cell.Add(new int[] { 50, 200 });
            cell.Add(new int[] { 100, 200 });
            cell.Add(new int[] { 150, 200 });
            cell.Add(new int[] { 200, 200 });
            cell.Add(new int[] { 250, 200 });
            cell.Add(new int[] { 300, 200 });
            cell.Add(new int[] { 350, 200 });

            cell.Add(new int[] { 50, 250 });
            cell.Add(new int[] { 100, 250 });
            cell.Add(new int[] { 150, 250 });
            cell.Add(new int[] { 200, 250 });
            cell.Add(new int[] { 250, 250 });
            cell.Add(new int[] { 300, 250 });
            cell.Add(new int[] { 350, 250 });

            cell.Add(new int[] { 50, 300 });
            cell.Add(new int[] { 100, 300 });
            cell.Add(new int[] { 150, 300 });
            cell.Add(new int[] { 200, 300 });
            cell.Add(new int[] { 250, 300 });
            cell.Add(new int[] { 300, 300 });
            cell.Add(new int[] { 350, 300 });

            cell.Add(new int[] { 50, 350 });
            cell.Add(new int[] { 100, 350 });
            cell.Add(new int[] { 150, 350 });
            cell.Add(new int[] { 200, 350 });
            cell.Add(new int[] { 250, 350 });
            cell.Add(new int[] { 300, 350 });
            cell.Add(new int[] { 350, 350 });
        }



    }
}
