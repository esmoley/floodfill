using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FloodFill.Form1;

namespace FloodFill
{
    static class Calculator
    {
        public static Position Start;
        static Position Finish;
        private static string FindStartAndFinish()
        {            
            Start = new Position(-1, -1);
            Finish = new Position(-1, -1);
            if (fis == null)
            {
                return "MAP should be defined. Click Create Map button first";
            }
            for (int i = 0; i < fis.GetLength(0); i++)
            {
                for (int j = 0; j < fis.GetLength(1); j++)
                {
                    fis[i, j].Step = -1;
                    if (fis[i, j].State == FloodItem.STATES.START)
                    {
                        if (Start.X != -1)
                        {
                            return "Map should have only one start";
                        }
                        else
                        {
                            Start.X = i;
                            Start.Y = j;
                        }
                    }
                    else if (fis[i, j].State == FloodItem.STATES.FINISH)
                    {
                        if (Finish.X != -1)
                        {
                            return "Map should have only one finish";
                        }
                        else
                        {
                            Finish.X = i;
                            Finish.Y = j;
                            fis[i, j].Step = 0;
                        }
                    }
                }
            }
            if (Start.X == -1) return "Start is not defined";
            if (Finish.X == -1) return "Finish is not defined";
            return null;
        }
        public static string Calculate()
        {
            string errors = FindStartAndFinish();
            if (errors != null) return errors;
            List<Pointer> pointers = new List<Pointer>();
            pointers.Add(new Pointer(Finish,DIRECTION.RIGHT,1));
            pointers.Add(new Pointer(Finish, DIRECTION.DOWN,1));
            pointers.Add(new Pointer(Finish, DIRECTION.LEFT,1));
            pointers.Add(new Pointer(Finish, DIRECTION.UP,1));
            bool end = false;
            bool success = false;
            while (!end)
            {
                end = true;
                List<Pointer> newPointers = new List<Pointer>();
                foreach (Pointer pointer in pointers)
                {
                    if (pointer.NextMove())
                    {
                        end = false;
                        if (!pointer.isStuck && !pointer.end) newPointers.Add(pointer);
                    }else if (pointer.end)
                    {
                        success = true;
                        end = true; break;
                    }
                    foreach (DIRECTION dir in pointer.FreeSides())
                    {
                        Position pos = new Position(pointer.pointer.X, pointer.pointer.Y);
                        newPointers.Add(new Pointer(pos, dir, pointer.step));
                    }
                }
                pointers = newPointers;
            }
            if (!success) return "Error: Cannot get directions";
            return null;
        }
        
        
    }
}
