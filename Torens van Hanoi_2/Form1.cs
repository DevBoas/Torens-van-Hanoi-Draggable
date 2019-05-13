using System;
using System.Drawing;
using System.Windows.Forms;

namespace Torens_van_Hanoi_2
{
    public partial class Form1 : Form
    {
        private int[][] jaggedArray3 =
        {
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 1
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 2
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 3
        };

        private Control dragging;
        private Point BackPoint;

        public Form1()
        {
            InitializeComponent();
            SetupRings();
        }
        
        private void SetupRings()
        {
            PictureBox[] rings = { Ring_8, Ring_7, Ring_6, Ring_5, Ring_4, Ring_3, Ring_2, Ring_1 };
            for (int i = 0; i < rings.Length; i++)
                AddRing(Pole_1, rings[i]);
        }

        private int getOffset(PictureBox pole, PictureBox ring)
        {
            int c = 0;
            int PoleNum = System.Convert.ToInt32(pole.Name.Substring(pole.Name.Length-1));
            int RingNum = System.Convert.ToInt32(ring.Name.Substring(ring.Name.Length-1));
            for (int i = 0; i < jaggedArray3[PoleNum - 1].Length; i++)
            {
                //MessageBox.Show(RingNum.ToString() + " < " + jaggedArray3[PoleNum - 1][i].ToString());
                if (RingNum < jaggedArray3[PoleNum - 1][i] || jaggedArray3[PoleNum - 1][i] == 0)
                {
                    if (jaggedArray3[PoleNum - 1][i] > 0)
                        c++;
                    else
                    {
                        jaggedArray3[PoleNum - 1][i] = RingNum;
                        break;
                    }
                }
                else
                {
                    ///MessageBox.Show("No can do");
                    return -1;
                }
            }
            return c * ring.Height;
        }

        private Boolean CanPickUp(Control con)
        {
            PictureBox ring = con as PictureBox;
            int RingNum = System.Convert.ToInt32(ring.Name.Substring(ring.Name.Length - 1));
            //MessageBox.Show("Attempting to pickup ring" + RingNum.ToString());
            int found = -1;
            for (int i = 0; i < jaggedArray3.Length; i++)
            {
                for (int y = 0; y < jaggedArray3[i].Length; y++)
                {
                    if ((found == i) && (jaggedArray3[i][y] > 0))
                        return false;
                    if (jaggedArray3[i][y] == RingNum)
                        found = i;
                }
            }
            return true;
        }  

        private PictureBox matchPole(int num)
        {
            PictureBox pole = null;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox) && c.Name.Substring(0, 5) == "Pole_")
                {
                    int PoleNum = System.Convert.ToInt32(c.Name.Substring(c.Name.Length - 1));
                    if (PoleNum == num)
                        pole = c as PictureBox;
                }
            }
            return pole;
        }
        
        private void addMove()
        {
            int CurrentMoves = System.Convert.ToInt32(Counter.Text.Substring(6));
            CurrentMoves++;
            Counter.Text = "Moves: " + CurrentMoves.ToString();
        }

        //new
        private PictureBox WhichPole2(PictureBox CurrentPole, PictureBox ring, int index)
        {
            PictureBox[] poles = { Pole_1, Pole_2, Pole_3 };
            Point a = ring.Location;
            int HitBox = 125;
            int p_x_l_top = poles[index].Location.X - HitBox - (ring.Size.Width / 2);
            int p_x_r_top = poles[index].Location.X + HitBox + (ring.Size.Width / 2);
            int p_y_top = poles[index].Location.Y - 50;
            int p_y_bot = poles[index].Location.Y + Pole_1.Size.Height;
            if ((a.X >= p_x_l_top) && (a.X <= p_x_r_top) && (a.Y >= p_y_top) && a.Y <= p_y_bot)
                return poles[index];
            if (index == 2)
                return CurrentPole;
            index++;
            return WhichPole2(CurrentPole, ring, index);
        }

        //old
        private PictureBox WhichPole(PictureBox CurrentPole, PictureBox ring)
        {
            Point a = ring.Location;

            int HitBox = 125;

            int p1_x_l_top = Pole_1.Location.X - HitBox - (ring.Size.Width / 2);
            int p1_x_r_top = Pole_1.Location.X + HitBox + (ring.Size.Width / 2);
            int p1_y_top = Pole_1.Location.Y - 50;
            int p1_y_bot = Pole_1.Location.Y + Pole_1.Size.Height;

            int p2_x_l_top = Pole_2.Location.X - HitBox - (ring.Size.Width / 2);
            int p2_x_r_top = Pole_2.Location.X + HitBox + (ring.Size.Width / 2);
            int p2_y_top = Pole_2.Location.Y - 50;
            int p2_y_bot = Pole_2.Location.Y + Pole_2.Size.Height;

            int p3_x_l_top = Pole_3.Location.X - HitBox - (ring.Size.Width / 2);
            int p3_x_r_top = Pole_3.Location.X + HitBox + (ring.Size.Width / 2);
            int p3_y_top = Pole_3.Location.Y - 50;
            int p3_y_bot = Pole_3.Location.Y + Pole_3.Size.Height;

            if ((a.X >= p1_x_l_top) && (a.X <= p1_x_r_top) && (a.Y >= p1_y_top) && a.Y <= p1_y_bot)
                CurrentPole = Pole_1;
            else if ((a.X >= p2_x_l_top) && (a.X <= p2_x_r_top) && (a.Y >= p2_y_top) && a.Y <= p2_y_bot)
                CurrentPole = Pole_2;
            else if ((a.X >= p3_x_l_top) && (a.X <= p3_x_r_top) && (a.Y >= p3_y_top) && a.Y <= p3_y_bot)

                CurrentPole = Pole_3;
            return CurrentPole;
        }

        private Boolean checkInSquare(Control activeControl)
        {
            Point a = activeControl.Location;
            Boolean possible;
            PictureBox ring = activeControl as PictureBox;
            PictureBox current_pole;
            PictureBox targ_pole;

            int poleInt = RemoveRing(ring);
            PictureBox CurrentPole = matchPole(poleInt);
            current_pole = matchPole(poleInt);
            targ_pole = WhichPole2(CurrentPole, ring, 0);
            possible = AddRing(targ_pole, ring);

            if (!possible)
                AddRing(current_pole, ring);
            else if (current_pole != targ_pole)
                addMove();

            return possible;
        }

        void Ring_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = (sender as Control);
            if (!CanPickUp(c))
                return;
            c.BringToFront();
            BackPoint = c.Location;
            dragging = c;
        }

        void Ring_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging != null && !checkInSquare(dragging))
                dragging.Location = BackPoint;
            dragging = null;
        }

        void Ring_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging == null || dragging != sender)
                return;

            int halfX = (dragging.Size.Width / 2);
            int xOffset = (halfX - e.Location.X);
            int halfY = (dragging.Size.Height / 2);
            int yOffset = (halfY - e.Location.Y);

            dragging.Location = new Point(dragging.Location.X - xOffset, dragging.Location.Y - yOffset);
        }

        private int RemoveRing(PictureBox ring)
        {
            int RingNum = System.Convert.ToInt32(ring.Name.Substring(ring.Name.Length - 1));
            for (int i = 0; i < jaggedArray3.Length; i++)
            {
                for (int y = 0; y < jaggedArray3[i].Length; y++)
                {
                    if (jaggedArray3[i][y] == RingNum)
                    {
                        jaggedArray3[i][y] = 0;
                        return i + 1;
                    }
                }
            }
            return -1;
        }

        private Boolean AddRing(PictureBox pole, PictureBox ring)
        {
            int offset = getOffset(pole, ring);
            if (offset == -1)
                return false;
            int y_position = pole.Location.Y - offset;
            int y_size = pole.Size.Height - ring.Size.Height;
            int x_position = pole.Location.X;
            int x_size = (ring.Size.Width / 2) - (pole.Size.Width / 2);
            ring.Location = new Point((x_position - x_size) , y_position + y_size);
            return true;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Counter.Text = "Moves: 0";
            for (int i = 0; i < jaggedArray3.Length; i++)
                for (int y = 0; y < jaggedArray3[i].Length; y++)
                    jaggedArray3[i][y] = 0;
            SetupRings();
        }

    }
}
