using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Torens_van_Hanoi_2
{
    public partial class Form1 : Form
    {
        int[][] jaggedArray3 =
        {
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},  // tower 1
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 2
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 3
        };

        private Control activeControl;
        private Point previousLocation;
        private Point PickupPoint;

        public Form1()
        {
            InitializeComponent();
            AddRing(Pole_1, Ring_8);
            AddRing(Pole_1, Ring_7);
            AddRing(Pole_1, Ring_6);
            AddRing(Pole_1, Ring_5);
            AddRing(Pole_1, Ring_4);
            AddRing(Pole_1, Ring_3);
            AddRing(Pole_1, Ring_2);
            AddRing(Pole_1, Ring_1);
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

        void Ring_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CanPickUp(sender as Control))
                return;
            activeControl = sender as Control;
            PickupPoint = activeControl.Location;
            previousLocation = e.Location;
            //Cursor = Cursors.Hand;
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

        private Boolean checkInSquare(Control activeControl)
        {
            Point a = activeControl.Location;
            PictureBox ring = activeControl as PictureBox;
            PictureBox pole = null;
            PictureBox m_pole = null;
            int HitBox = 125;

            int p1_x_l_top = Pole_1.Location.X - HitBox - (activeControl.Size.Width / 2);
            int p1_x_r_top = Pole_1.Location.X + HitBox + (activeControl.Size.Width / 2); 
            int p1_y_top = Pole_1.Location.Y - 50;
            int p1_y_bot = Pole_1.Location.Y + Pole_1.Size.Height;

            int p2_x_l_top = Pole_2.Location.X - HitBox - (activeControl.Size.Width / 2);
            int p2_x_r_top = Pole_2.Location.X + HitBox + (activeControl.Size.Width / 2);
            int p2_y_top = Pole_2.Location.Y - 50;
            int p2_y_bot = Pole_2.Location.Y + Pole_1.Size.Height;

            int p3_x_l_top = Pole_3.Location.X - HitBox - (activeControl.Size.Width / 2);
            int p3_x_r_top = Pole_3.Location.X + HitBox + (activeControl.Size.Width / 2);
            int p3_y_top = Pole_3.Location.Y - 50;
            int p3_y_bot = Pole_2.Location.Y + Pole_1.Size.Height;

            Boolean inSquare = false;
            //MessageBox.Show(a.X.ToString() + " > " + x_l_top.ToString());
            //MessageBox.Show(a.X.ToString() + " < " + x_r_top.ToString());
            //MessageBox.Show(a.Y.ToString() + " < " + y_top.ToString());
            
            // Pole 1 square
            if ((a.X >= p1_x_l_top) && (a.X <= p1_x_r_top) && (a.Y >= p1_y_top) && a.Y <= p1_y_bot)
            {
                ///MessageBox.Show("Drag is in dropbox of pole_1");
                int poleInt = RemoveRing(ring);
                pole = matchPole(poleInt);
                m_pole = Pole_1;
                Boolean possible = AddRing(Pole_1, ring);
                if (possible)
                    inSquare = true;
                else
                    AddRing(pole, ring);
            }

            // Pole 2 square
            if ((a.X >= p2_x_l_top) && (a.X <= p2_x_r_top) && (a.Y >= p2_y_top) && a.Y <= p2_y_bot)
            {
                ///MessageBox.Show("Drag is in dropbox of pole_2");
                //RemoveRing(ring);
                int poleInt = RemoveRing(ring);
                pole = matchPole(poleInt);
                m_pole = Pole_2;
                Boolean possible = AddRing(Pole_2, ring);
                if (possible)
                    inSquare = true;
                else
                    AddRing(pole, ring);
            }

            // Pole 3 square
            if ((a.X >= p3_x_l_top) && (a.X <= p3_x_r_top) && (a.Y >= p3_y_top) && a.Y <= p3_y_bot)
            {
                ///MessageBox.Show("Drag is in dropbox of pole_3");
                int poleInt = RemoveRing(ring);
                pole = matchPole(poleInt);
                m_pole = Pole_3;
                Boolean possible = AddRing(Pole_3, ring);
                if (possible)
                    inSquare = true;
                else
                    AddRing(pole, ring);
            }

            if ((pole != null) && (m_pole != null) &&(pole != m_pole) && inSquare)
                addMove();

            return inSquare;
        }

        void Ring_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeControl != null && !checkInSquare(activeControl))
                activeControl.Location = PickupPoint;
            activeControl = null;
            //Cursor = Cursors.Default;
            //MessageBox.Show("Check in region");
        }

        void Ring_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
                return;
            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
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

            AddRing(Pole_1, Ring_8);
            AddRing(Pole_1, Ring_7);
            AddRing(Pole_1, Ring_6);
            AddRing(Pole_1, Ring_5);
            AddRing(Pole_1, Ring_4);
            AddRing(Pole_1, Ring_3);
            AddRing(Pole_1, Ring_2);
            AddRing(Pole_1, Ring_1);
        }

    }
}
