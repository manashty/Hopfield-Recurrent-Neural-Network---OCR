using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NNLetterRecognition
{
    public partial class NNLRForm : Form
    {
        HLR _HLR;
        public NNLRForm()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            selectedPoints = new ArrayList();
            previousPoints = new ArrayList();
            _HLR = new HLR();
        }
        Graphics g;
        Point selected;
        Point previous;
        Point s;
        private void btn_Draw_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            Bitmap b = new Bitmap(20, 20);
            Graphics g1 = Graphics.FromImage(b);
            g1.DrawString(dom_Letter.Text, new Font("Arial",18), new SolidBrush(Color.Black), -3, -4);
            s = new Point((pictureBox1.Width / 20), (pictureBox1.Height / 20));
            selectedPoints.Clear();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    //g.FillRectangle(new SolidBrush((b.GetPixel(i, j)==Color.White)?Color.White:Color.Blue), i * s.X, j * s.Y, s.X, s.Y);
                    if (HLR.CtoI(b.GetPixel(i, j)) > 0)
                        selectedPoints.Add(new Point(i, j));
                    //g.FillRectangle(new SolidBrush(b.GetPixel(i, j)), i * s.X, j * s.Y, s.X, s.Y);
                }
            }
            ReDraw();
        }
        private void ReDraw()
        {            
            s = new Point((pictureBox1.Width / 20), (pictureBox1.Height / 20));
            if (previous != selected)
                if (previous.X >= 0)
                    if (!rad_Large.Checked)
                        g.DrawRectangle(new Pen(pictureBox1.BackColor, 2), previous.X * s.X, previous.Y * s.Y, s.X, s.Y);
                    else
                        g.DrawRectangle(new Pen(pictureBox1.BackColor, 2), previous.X * s.X - s.X, previous.Y * s.Y - s.Y, s.X * 3, s.Y * 3);
            while (previousPoints.Count>0)
            {
                g.FillRectangle(new SolidBrush(pictureBox1.BackColor), ((Point)previousPoints[0]).X * s.X, ((Point)previousPoints[0]).Y * s.Y, s.X, s.Y);
                previousPoints.RemoveAt(0);
            }
            foreach (Point p in selectedPoints)
            {
                g.FillRectangle(new SolidBrush(Color.Blue), p.X*s.X, p.Y*s.Y, s.X, s.Y);
            }
            //for (int i = 0; i < 20; i++)
            //{
            //    g.DrawLine(new Pen(Color.Black), i * s.X, 0, i * s.X, pictureBox1.Height);
            //    g.DrawLine(new Pen(Color.Black), 0, i * s.Y, pictureBox1.Width, i * s.Y);
            //}
            if (selected.X >= 0)
                if (!rad_Large.Checked)
                    g.DrawRectangle(new Pen(Color.Red, 2), selected.X * s.X, selected.Y * s.Y, s.X, s.Y);
                else
                    g.DrawRectangle(new Pen(Color.Red, 2), selected.X * s.X - s.X, selected.Y * s.Y - s.Y, s.X * 3, s.Y * 3);
            if (chk_GhostDraw.Checked)
                ShowOriginal();
        }
        ArrayList selectedPoints;
        ArrayList previousPoints;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            previous = selected;
            selected.X = (e.X / (pictureBox1.Width / 20));
            selected.Y = (e.Y / (pictureBox1.Height / 20));
            if (e.Button == MouseButtons.Left)
            {
                if (!selectedPoints.Contains(selected))
                {
                    selectedPoints.Add(selected);
                    if (rad_Large.Checked)
                    {
                        selectedPoints.Add(new Point(selected.X+1, selected.Y));
                        selectedPoints.Add(new Point(selected.X-1, selected.Y));
                        selectedPoints.Add(new Point(selected.X, selected.Y+1));
                        selectedPoints.Add(new Point(selected.X, selected.Y-1));
                        selectedPoints.Add(new Point(selected.X + 1, selected.Y+1));
                        selectedPoints.Add(new Point(selected.X - 1, selected.Y-1));
                        selectedPoints.Add(new Point(selected.X-1, selected.Y + 1));
                        selectedPoints.Add(new Point(selected.X+1, selected.Y - 1));                        
                    }
                    for (int i = 0; i < selectedPoints.Count; i++)
                    {
                        if ((((Point)selectedPoints[i]).X > 19) || (((Point)selectedPoints[i]).Y > 19)
                            || (((Point)selectedPoints[i]).X < 0) || (((Point)selectedPoints[i]).Y < 0))
                            selectedPoints.RemoveAt(i--); //Do not skip the current i                                                       

                    }
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                selectedPoints.Remove(selected);
                if (rad_Large.Checked)
                {
                    selectedPoints.Remove(new Point(selected.X + 1, selected.Y));
                    selectedPoints.Remove(new Point(selected.X - 1, selected.Y));
                    selectedPoints.Remove(new Point(selected.X, selected.Y + 1));
                    selectedPoints.Remove(new Point(selected.X, selected.Y - 1));
                    selectedPoints.Remove(new Point(selected.X + 1, selected.Y + 1));
                    selectedPoints.Remove(new Point(selected.X - 1, selected.Y - 1));
                    selectedPoints.Remove(new Point(selected.X - 1, selected.Y + 1));
                    selectedPoints.Remove(new Point(selected.X + 1, selected.Y - 1));
                }
                if ((!previousPoints.Contains(selected)))// && selectedPoints.Contains(selected))
                {
                    previousPoints.Add(selected);
                    if (rad_Large.Checked)
                    {
                        previousPoints.Add(new Point(selected.X + 1, selected.Y));
                        previousPoints.Add(new Point(selected.X - 1, selected.Y));
                        previousPoints.Add(new Point(selected.X, selected.Y + 1));
                        previousPoints.Add(new Point(selected.X, selected.Y - 1));
                        previousPoints.Add(new Point(selected.X + 1, selected.Y + 1));
                        previousPoints.Add(new Point(selected.X - 1, selected.Y - 1));
                        previousPoints.Add(new Point(selected.X - 1, selected.Y + 1));
                        previousPoints.Add(new Point(selected.X + 1, selected.Y - 1));
                    }
                }
            }

            //selected = e.Location;     
            //if(e.Button!=MouseButtons.None)
                ReDraw();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1_MouseMove(sender, e);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            selectedPoints.Clear();
            g.Clear(pictureBox1.BackColor);
            ReDraw();
        }
        private void NNLRForm_Paint(object sender, PaintEventArgs e)
        {
            ReDraw();
        }
        private void btn_Classify_Click(object sender, EventArgs e)
        {
            original = new Bitmap(20, 20);
            foreach (Point p in selectedPoints)
                original.SetPixel(p.X, p.Y, Color.FromArgb(255, 0, 0, 0));            
            //_HLR.AddPattern(original);
            _HLR.SetCurrentPattern(original);
            timer_Classify.Enabled = true;
            chk_GhostDraw.Enabled = true;
        }
        private void timer_Classify_Tick(object sender, EventArgs e)
        {
            if (_HLR.Classify())
            {
                lbl_Energy.Text = _HLR.Energy.ToString();
                selectedPoints.Clear();
                for (int i = 0; i < _HLR.Neurons.Count; i++)
                {
                    if (_HLR.Neurons[i].State > 0)
                        selectedPoints.Add(new Point(i / 20, i % 20));
                }
                g.Clear(pictureBox1.BackColor);
                ReDraw();
            }
        }
        Bitmap original;
        private void btn_AddPattern_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(20, 20);
            foreach(Point p in selectedPoints)
                b.SetPixel(p.X, p.Y, Color.FromArgb(255, 0, 0, 0));
            //Graphics g2 = pictureBox1.CreateGraphics();
            //g2.DrawImage(original, 21, 21);
            _HLR.AddPattern(b);
        }
        public void ShowOriginal()
        {
            s = new Point((pictureBox1.Width / 20), (pictureBox1.Height / 20));
            Graphics g2 = pictureBox1.CreateGraphics();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (original.GetPixel(i, j).A == 255)
                    {
                        if(selectedPoints.Contains(new Point(i,j)))
                            g2.FillEllipse(new SolidBrush(Color.GreenYellow), s.X * i + s.X / 4, s.Y * j + s.Y / 4, s.X / 2, s.Y / 2);
                        else
                            g2.FillEllipse(new SolidBrush(Color.Crimson), s.X * i + s.X / 4, s.Y * j + s.Y / 4, s.X / 2, s.Y / 2);
                    }
                }
            }            
        }        
        private void chk_GhostDraw_CheckedChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void btn_AddAZ_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(20, 20);
            Bitmap p = new Bitmap(20, 20);
            Graphics g1 = Graphics.FromImage(b);
            //for (int k = 0; k < dom_Letter.Items.Count/6; k++)
            //{
            //    g1.DrawString(dom_Letter.Items[k].ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), -3, -4);
            //    _HLR.AddPattern(b);
            //}
            foreach(char c in txt_All.Text.ToCharArray())
            {                
                //g1.Clear(Color.FromArgb(0,0,0,0));
                b = new Bitmap(20, 20);
                p = new Bitmap(20, 20);
                g1 = Graphics.FromImage(b);
                g1.DrawString(c.ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), -3, -4);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        //g.FillRectangle(new SolidBrush((b.GetPixel(i, j)==Color.White)?Color.White:Color.Blue), i * s.X, j * s.Y, s.X, s.Y);
                        if (HLR.CtoI(b.GetPixel(i, j)) > 0)
                            p.SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
                        //g.FillRectangle(new SolidBrush(b.GetPixel(i, j)), i * s.X, j * s.Y, s.X, s.Y);
                    }
                }
                _HLR.AddPattern(p);
            }
        }

        private void NNLRForm_Load(object sender, EventArgs e)
        {
            _HLR = new HLR();            
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            _HLR = new HLR();
            chk_GhostDraw.Enabled = false;
        }
        private void btn_ClassifyStep_Click(object sender, EventArgs e)
        {
            _HLR.Classify();
            lbl_Energy.Text = _HLR.Energy.ToString();
            selectedPoints.Clear();
            for (int i = 0; i < _HLR.Neurons.Count; i++)
            {
                if (_HLR.Neurons[i].State > 0)
                    selectedPoints.Add(new Point(i / 20, i % 20));
            }
            g.Clear(pictureBox1.BackColor);
            ReDraw(); 
        }

        private void btn_MSB_Click(object sender, EventArgs e)
        {
            Bitmap answer = (Bitmap)_HLR.Patterns[_HLR.MatchMSB()].Clone();
            selectedPoints.Clear();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    //g.FillRectangle(new SolidBrush((b.GetPixel(i, j)==Color.White)?Color.White:Color.Blue), i * s.X, j * s.Y, s.X, s.Y);
                    if (HLR.CtoI(answer.GetPixel(i, j)) > 0)
                        selectedPoints.Add(new Point(i, j));
                    //g.FillRectangle(new SolidBrush(b.GetPixel(i, j)), i * s.X, j * s.Y, s.X, s.Y);
                }
            }
            g.Clear(pictureBox1.BackColor);
            ReDraw();
        }
    }
}
