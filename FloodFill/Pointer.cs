using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FloodFill.Form1;

namespace FloodFill
{
    class Pointer
    {
        public Position pointer;
        List<Position> pointerHistory = new List<Position>();
        public DIRECTION direction = DIRECTION.RIGHT;
        public bool isStuck = false;
        public int step = 0;
        private List<DIRECTION> directionsToCheck = new List<DIRECTION>();
        public bool end = false;
        public Pointer(Position pointer, DIRECTION direction, int step)
        {
            this.pointer = pointer;
            this.direction = direction;
            this.step = step;
        }
        public List<DIRECTION> FreeSides()
        {
            List<DIRECTION> freeSides = new List<DIRECTION>();
            foreach (DIRECTION dirToCheck in directionsToCheck)
            {
                if (IsDirectionFree(dirToCheck)) freeSides.Add(dirToCheck);
            }
            return freeSides;
        }
        public bool IsDirectionFree(DIRECTION dir)
        {
            Position tempPointer = new Position(pointer.X, pointer.Y);
            tempPointer.Move(new Position(dir));
            if (tempPointer.X < 0 || tempPointer.X >= fis.GetLength(0)
                    || tempPointer.Y < 0 || tempPointer.Y >= fis.GetLength(1)
                    || fis[tempPointer.X, tempPointer.Y].Step != -1)
            {
                return false;
            }
            else if (fis[tempPointer.X, tempPointer.Y].State == FloodItem.STATES.EMPTY || fis[tempPointer.X, tempPointer.Y].State == FloodItem.STATES.START)
            {
                return true;
            }
            return false;
        }
        public bool NextMove()
        {
            directionsToCheck.Clear();
            if (direction == DIRECTION.LEFT || direction == DIRECTION.RIGHT) directionsToCheck.AddRange(new DIRECTION[] { DIRECTION.DOWN, DIRECTION.UP });
            else if (direction == DIRECTION.DOWN || direction == DIRECTION.UP) directionsToCheck.AddRange(new DIRECTION[] { DIRECTION.LEFT, DIRECTION.RIGHT });
            while (!end && !isStuck)
            {

                pointerHistory.Add(new Position(pointer.X, pointer.Y));
                if (IsStuck()) { isStuck = true; break; }
                if (IsDirectionFree(direction))
                {
                    pointer.Move(new Position(direction));
                    fis[pointer.X, pointer.Y].Step = step++;
                    if (fis[pointer.X, pointer.Y].State == FloodItem.STATES.START) end = true;
                    break;
                }
                else
                {
                    Turn();
                    directionsToCheck.Remove(direction);
                }
            }
            return !end && !isStuck;
        }
        public bool IsStuck()
        {
            int c = pointerHistory.Count;
            if (c < 6) return false;
            else return pointerHistory[c - 1].Equals(pointerHistory[c - 2])
                && pointerHistory[c - 2].Equals(pointerHistory[c - 3])
                && pointerHistory[c - 3].Equals(pointerHistory[c - 4])
                && pointerHistory[c - 4].Equals(pointerHistory[c - 5])
                && pointerHistory[c - 5].Equals(pointerHistory[c - 6]);
        }
        private void Turn()
        {
            if (direction == DIRECTION.RIGHT) direction = DIRECTION.DOWN;
            else if (direction == DIRECTION.DOWN) direction = DIRECTION.LEFT;
            else if (direction == DIRECTION.LEFT) direction = DIRECTION.UP;
            else if (direction == DIRECTION.UP) direction = DIRECTION.RIGHT;
        }
    }
}
