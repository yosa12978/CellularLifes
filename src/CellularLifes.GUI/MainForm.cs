using CellularLifes.Core.Domain;
using CellularLifes.Core.Impl;
using CellularLifes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellularLifes.GUI
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private BSRule rule;
        private Field f;
        private int res;
        private int gen = 0;
        private Color bg = Color.White;
        private Brush fg = Brushes.Gray;

        public MainForm()
        {
            InitializeComponent();
            res = (int)resol.Value;
            f = new Field(FieldPanel.Width / res, FieldPanel.Height / res);

        }

        private void Draw()
        {
            g.Clear(bg);
            for(int i = 0; i < f.Width; i++)
                for(int j = 0; j < f.Height; j++)
                    if (f.GameField[i, j] == 1)
                        g.FillRectangle(fg, i*res, j*res, res, res);
            FieldPanel.Refresh();
        }
        private void Cycle()
        {
            Field new_field = new Field(f.Width, f.Height);
            for (int i = 0; i < f.Width; i++)
                for (int j = 0; j < f.Height; j++)
                {
                    Cell c = new Cell(i, j);
                    new_field.GameField[i, j] = rule.Check(f, c) ? 1 : 0;
                }
            f = new_field;
            Draw();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Cycle();
            gen++;
            GenText.Text = "Generation: "+gen.ToString();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Timer.Enabled)
                return;
            resol.Enabled = false;
            StartBtn.Enabled = false;
            ClearBtn.Enabled = false;
            PauseBtn.Enabled = true;
            Timer.Enabled = true;
            New.Enabled = true;

            INeighbourhood n = new MooreNeighbourhood();
            if (MooreBtn.Checked)
                n = new MooreNeighbourhood();
            else if (VonNeumannBtn.Checked)
                n = new VonNeumannNeighbourhood();

            string[] bornt = textBox1.Text.Trim().Split(" ");
            string[] survt = textBox2.Text.Trim().Split(" ");

            if (textBox1.Text.Trim() == "")
                bornt = Array.Empty<string>();
            if (textBox2.Text.Trim() == "")
                survt = Array.Empty<string>();

            rule = new BSRule
            {
                Born = bornt.Length != 0 ? bornt.Select(x => Convert.ToInt32(x)).ToArray() : Array.Empty<int>(),
                Surv = survt.Length != 0 ? survt.Select(x => Convert.ToInt32(x)).ToArray() : Array.Empty<int>(),
                Neighbourhood = n
            };

            FieldPanel.Image = new Bitmap(FieldPanel.Width, FieldPanel.Height);
            g = Graphics.FromImage(FieldPanel.Image);
            
            //if (f == null)
            //    New_Click(sender, e);

            Timer.Start();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (!Timer.Enabled)
                return;
            resol.Enabled = true;
            StartBtn.Enabled = true;
            ClearBtn.Enabled = true;
            PauseBtn.Enabled = false;
            Timer.Enabled = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            g.Clear(bg);
            gen = 0;
            GenText.Text = "Generation: " + gen.ToString();
            f = new Field(FieldPanel.Width / res, FieldPanel.Height/res);
            FieldPanel.Refresh();
        }

        private void New_Click(object sender, EventArgs e)
        {
            StartBtn_Click(sender, e);

            gen = 0;
            GenText.Text = "Generation: " + gen.ToString();

            res = (int)resol.Value;

            f = new Field(FieldPanel.Width / res, FieldPanel.Height / res);

            Random random = new Random();
            for (int i = 0; i < f.Width; i++)
                for (int j = 0; j < f.Height; j++)
                    f.GameField[i, j] = random.Next(2) == 1 ? 1 : 0;

            Draw();
        }

        private void FieldPanel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if(e.Button == MouseButtons.Left)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    f.GameField[(int)x, (int)y] = 1;
                    Draw();
                }
                else if(e.Button == MouseButtons.Right)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    f.GameField[(int)x, (int)y] = 0;
                    Draw();
                }
                
            }
            catch { }
        }

        private void FieldPanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    f.GameField[(int)x, (int)y] = 1;
                    Draw();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    int x = e.Location.X / res;
                    int y = e.Location.Y / res;
                    f.GameField[(int)x, (int)y] = 0;
                    Draw();
                }

            }
            catch { }
        }

        private void resol_ValueChanged(object sender, EventArgs e)
        {
            f = new Field(FieldPanel.Width / res, FieldPanel.Height/res);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Timer.Interval = (int)numericUpDown1.Value;
        }
    }
}
