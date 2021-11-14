using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        public Cells c = new Cells();
        
        public List<Items> items = new List<Items>();



        public Form1()
        {
            InitializeComponent();
            c.cells();
            Paint += new PaintEventHandler(DrawCells);
            Paint += new PaintEventHandler(DrawPlayer);
            Paint += new PaintEventHandler(DrawItems);

            GenerateItems();





        }

        public void GenerateItems()
        {
            Random r = new Random();

            


            while (items.Count != 3)
            {
                var cell = c.cell[r.Next(0, c.cell.Count)];

                Items prize = new Items(cell[0], cell[1], r.Next(0, 100));
                items.Add(prize);
            }



        }


        public void UpdatePos()
        {
            label1.Text = p.xpos.ToString();
            label2.Text = p.ypos.ToString();
        }

        public void UpdateScore()
        {
            foreach (Items item in items)
            {
                if (item.xpoint == rect.X && item.ypoint == rect.Y)
                {
                    p.score += item.amount;
                    label3.Text = p.score.ToString();
                    item.amount = 0;

                }
                else
                {
                    p.score += 0;

                }


            }

        }

        public  void CheckGameState()
        {
            if (p.score == items.Sum(c => c.amount))
            {
                MessageBox.Show("You win!");
            }
        }



        private void DrawCells(Object sender, PaintEventArgs e)
        {

            foreach (int[] cell in c.cell)
            {
                

                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), cell[0], cell[1], 50, 50);


            }


        }

        public Player p = new Player();

        

        Rectangle rect = new Rectangle(0, 0, 50, 50);

        



        private void DrawPlayer(Object sender, PaintEventArgs e)
        {


            e.Graphics.DrawRectangle(new Pen(Color.Red, 3), rect);

        }





        private void DrawItems(Object sender, PaintEventArgs e)
        {
            foreach (Items item in items)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), item.xpoint, item.ypoint, 50, 50);

               

            }

            


        }


        private void MoveUp(Object sender, EventArgs e)
        {

            if(rect.Y -50 < 0)
            {
                rect.X += 0;
                rect.Y += 0;
            }
            else
            {
                rect.X += 0;
                rect.Y -= 50;
            }
            
            p.xpos = rect.X;
            p.ypos = rect.Y;

            UpdateScore();

            UpdatePos();

            Refresh();


        }

        private void MoveDown(Object sender, EventArgs e)
        {
            if(rect.Y + 50 > 350)
            {
                rect.X += 0;
                rect.Y += 0;
            }
            else
            {
                rect.X += 0;
                rect.Y += 50;
            }
            
            p.xpos = rect.X;
            p.ypos = rect.Y;
            UpdateScore();
            UpdatePos();

            Refresh();
        }

        private void MoveLeft(Object sender, EventArgs e)
        {
            if (rect.X - 50 < 0)
            {
                rect.X += 0;
                rect.Y += 0;
            }
            else
            {
                rect.X -= 50;
                rect.Y += 0;
            }

            
            p.xpos = rect.X;
            p.ypos = rect.Y;
            UpdateScore();
            UpdatePos();
            Refresh();
        }

        private void MoveRight(Object Sender, EventArgs e)
        {
            if (rect.X + 50 > 350)
            {
                rect.X += 0;
                rect.Y += 0;
            }
            else
            {
                rect.X += 50;
                rect.Y += 0;
            }

            
            p.xpos = rect.X;
            p.ypos = rect.Y;
            UpdateScore();
            UpdatePos();
            Refresh();
        }

    }


}
