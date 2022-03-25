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
        public Player p = new Player();
        public AI_Player ai = new AI_Player();
        public Behaviour bb = new Behaviour();

        Rectangle rect = new Rectangle(0, 0, 50, 50);
        Rectangle rect2 = new Rectangle(0, 0, 50, 50);



        public Form1()
        {
            InitializeComponent();
            c.cells();
            Paint += new PaintEventHandler(DrawCells);
            Paint += new PaintEventHandler(DrawPlayer);
            Paint += new PaintEventHandler(DrawItems);
            Paint += new PaintEventHandler(DrawAI_Player);

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
            label3.Text = "0";
            

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
                CheckGameState();

            }
            

        }

        public  void CheckGameState()
        {
            if (p.score == items.Sum(c => c.amount) || p.score > ai.score && items.Sum(c => c.amount) == 0)
            {
                MessageBox.Show("You win!");
            }
            else if (ai.score == items.Sum(c => c.amount) || ai.score > p.score && items.Sum(c => c.amount) ==0)
            {
                MessageBox.Show("AI wins!");
               
            }
        }



        private void DrawCells(Object sender, PaintEventArgs e)
        {

            foreach (int[] cell in c.cell)
            {
                

                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), cell[0], cell[1], 50, 50);


            }


        }

        private void DrawPlayer(Object sender, PaintEventArgs e)
        {


            e.Graphics.DrawRectangle(new Pen(Color.Red, 3), rect);

        }

        private void DrawAI_Player(Object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Green, 3), rect2);
        }

        private void DrawItems(Object sender, PaintEventArgs e)
        {
            foreach (Items item in items)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), item.xpoint, item.ypoint, 50, 50);

            }

        }

        public  void AIMove()
        {
            bool PlayerMove = HasMoved(rect.X, rect.Y);

            items.Sort((a, b) => b.amount.CompareTo(a.amount));
            var distance = Math.Sqrt((Math.Pow(item.xpoint - Rect.X, 2) + Math.Pow(item.ypoint - Rect.Y, 2)));
            double[] averages = new double[]{};

            foreach(Items object in items){
                for(int i = 0; i < items.count; i++){
                averages[i] = object.amount*1 - object.Distance()*1.5;
                i++;
             }
                Array.Sort(averages);
               
            }
            
            //Sorts the randomized prize value list to determine the most valuable prize. 

            int g = 0;
            int t = 0;

            var prime = items.ElementAt(items.FindIndexOf(c => c.amount*1 - c.Distance()*1.5 == averages.Max()));

            //Checks which item is at the top of the stack in terms of amount and goes towards that item.
            

            

            if (PlayerMove == true)
            {
                t++;
            }
            // Checks if the human player has moved yet, if not AI does not move.



            while (t == 1 && g < items.Count){
                
                    if (rect2.X < prime.xpoint && rect2.X + 50 != 400)
                    {
                        rect2.X += 50;
                        t--;

                    }
                    if (rect2.X > prime.xpoint && rect2.X - 50 >= 0)
                    {
                        rect2.X -= 50;
                        t--;
                    }
                    if (rect2.Y < prime.ypoint && rect2.Y + 50 != 400)
                    {
                        rect2.Y += 50;
                        t--;
                    }
                    if (rect2.Y > prime.ypoint && rect2.Y - 50 >= 0)
                    {
                        rect2.Y -= 50;
                        t--;
                    }

                    if (rect2.X == prime.xpoint && rect2.Y == prime.ypoint)
                    {
                    ai.score += prime.amount;
                    prime.amount = 0;
                    label4.Text = ai.score.ToString();
                    g += 1;
              // When the AI score equals the amount of item g g is incremented by one to begin moving towards the next item in the stack.
                    }

            }


        }

        public bool HasMoved(int x, int y) 
        {
            if(x != 0 || y != 0)
            {
                return true;
            }
            return false; 
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

            p.MoveUp();

            UpdateScore();

            UpdatePos();

            AIMove();

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

            p.MoveDown();
            
            UpdateScore();
            UpdatePos();
            AIMove();
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


            p.MoveLeft();

            AIMove();
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

            p.MoveRight();
            AIMove();
            UpdateScore();
            UpdatePos();
            Refresh();
        }

    }


}
