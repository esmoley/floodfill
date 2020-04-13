using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FloodFill.Form1;

namespace FloodFill
{
    public partial class FloodItem : UserControl
    {
        public FloodItem(bool showStep=true)
        {
            InitializeComponent();
            this.showStep = showStep;
            Step = -1;
            SetState();
        }
        public bool showStep = true;
        int step = -1;
        public int Step{
            set {
                step = value;
                if (value == -1||!showStep) label1.Text = "";
                else label1.Text = value.ToString();
            }
            get
            {
                return step;
            }
        }
        public Position Position;
        public enum STATES { EMPTY,WALL,START,FINISH};
        public STATES State { private set; get; } = 0;
        public void SetState(int new_state= 0)
        {
            if (new_state < Enum.GetNames(typeof(STATES)).Length)
            {
                State = (STATES)new_state;
            }
            else State = 0;
            UpdateVisualState();
        }
        private void UpdateVisualState()
        {
            switch ((int)State)
            {
                case 0:
                    BackColor = Color.White;
                    break;
                case 1:
                    BackColor = Color.Black;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                case 3:
                    BackColor = Color.Red;
                    break;
            }
            
        }
        public void NextState()
        {
            SetState((int)State + 1);
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            NextState();
        }
    }
}
