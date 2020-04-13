using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloodFill
{
    public partial class Form1 : Form
    {
        public struct Position { public int X; public int Y;
            public Position(int X, int Y) { this.X = X; this.Y = Y; }
            public Position(DIRECTION direction) {
                X = 0;Y = 0;
                switch (direction)
                {
                    case DIRECTION.LEFT:X = -1;Y = 0;break;
                    case DIRECTION.RIGHT:X = 1;Y = 0;break;
                    case DIRECTION.UP:X = 0;Y = -1;break;
                    case DIRECTION.DOWN:X = 0;Y = 1;break;
                }
            }
            public void Move(Position p) { X += p.X; Y += p.Y; }
            public bool Equals(Position equals)
            {
                return equals.X == X && equals.Y == Y;
            }
        }
        public enum DIRECTION { UP, LEFT, DOWN, RIGHT };
        public Form1()
        {
            InitializeComponent();
            checkBoxShowSteps_CheckedChanged(null, null);
        }

        private void randomizeSizeBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            mapSizeXnumericUpDown.Value = rand.Next((int)mapSizeXnumericUpDown.Minimum, (int)mapSizeXnumericUpDown.Maximum);
            mapSizeYnumericUpDown.Value = rand.Next((int)mapSizeYnumericUpDown.Minimum, (int)mapSizeYnumericUpDown.Maximum);
        }
        public static FloodItem[,] fis;
        private void createMapBtn_Click(object sender, EventArgs e)
        {
            floodFillMapPanel.Controls.Clear();
            fis = new FloodItem[(int)mapSizeXnumericUpDown.Value,(int)mapSizeYnumericUpDown.Value];
            //Button[]btns = new Button[20];
            for(int i = 0; i < (int)mapSizeXnumericUpDown.Value; i++)
            {
                for(int j=0;j< (int)mapSizeYnumericUpDown.Value; j++)
                {
                    fis[i,j] = new FloodItem(checkBoxShowSteps.Checked);
                    fis[i,j].Top = 26*i;
                    fis[i,j].Left = 26 * (j);
                    fis[i, j].Position = new Position(i,j);
                    floodFillMapPanel.Controls.Add(fis[i,j]);
                }
            }
            
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string error = Calculator.Calculate();
            if (error != null) MessageBox.Show(error);

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string error = Calculator.Calculate();
            if (error != null)
            {
                MessageBox.Show(error);
            }else GoPath.Start();
        }

        private void checkBoxShowSteps_CheckedChanged(object sender, EventArgs e)
        {
            calculateBtn.Enabled = checkBoxShowSteps.Checked;
            if (fis == null) return;
            for (int i = 0; i < fis.GetLength(0); i++)
            {
                for (int j = 0; j < fis.GetLength(1); j++)
                {
                    fis[i, j].showStep = checkBoxShowSteps.Checked;
                }
            }
        }
    }
}
