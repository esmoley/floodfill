using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static FloodFill.Form1;

namespace FloodFill
{
    class GoPath
    {
        private static System.Timers.Timer aTimer;
        public static void Start()
        {
            SetTimer();
            for(int i = 0; i < fis.GetLength(0); i++)
            {
                for(int j = 0; j < fis.GetLength(1); j++)
                {
                    fis[i, j].SetState((int)fis[i, j].State);
                }
            }
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            if (aTimer != null)
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
             aTimer = new System.Timers.Timer(500);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            position = Calculator.Start;
        }
        static Position position;
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",e.SignalTime);
            
            Position bestPosition = BestPosition();
            if (fis[bestPosition.X, bestPosition.Y].Step == 0)
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
            else
            {
                position = bestPosition;
                fis[position.X, position.Y].BackColor = Color.Blue;
            }

        }
        static Position BestPosition()
        {
            List<Position> positions = new List<Position>();
            for(int i=0;i<Enum.GetNames(typeof(DIRECTION)).Length;i++)
            {
                Position pos = new Position(position.X,position.Y);
                pos.Move(new Position((DIRECTION)i));
                if(pos.X< fis.GetLength(0)&& pos.Y < fis.GetLength(1)&& pos.X>=0&& pos.Y>=0)
                    positions.Add(pos);
            }
            Position bestPosition = positions[0];
            for(int i=1;i<positions.Count;i++)
            {
                if (fis[bestPosition.X, bestPosition.Y].Step > fis[positions[i].X, positions[i].Y].Step&& fis[positions[i].X, positions[i].Y].Step>=0|| fis[bestPosition.X, bestPosition.Y].Step<0)
                {
                    bestPosition = positions[i];
                }
            }
            return bestPosition;
        }
    }
}
