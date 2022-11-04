using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Statki
{
    internal class Pole
    {
        private bool[,] pole { get; set; } = new bool[10, 10];
        public Pole()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pole[i, j] = true;
                }
            }
        }
        public bool Getpole(int x, int y)
        {
            return pole[x, y];
        }
        public bool CanTake(Statek ob)
        {
            int s = ob.GetV(1);
            int r = ob.GetV(2);
            int x = ob.GetV(3) - 1;
            int y = ob.GetV(4) - 1;
            for (int i = 0; i < s; i++)
            {
                if (r == 0)
                {
                    if (!pole[x + i, y]) { return pole[x + i, y]; }
                }
                else
                {
                    if (!pole[x, y + i]) { return pole[x, y + i]; }
                }
            }
            return true;
        }
        public void Take(Statek ob, bool act)
        {
            int s = ob.GetV(1);
            int r = ob.GetV(2);
            int x = ob.GetV(3) - 1;
            int y = ob.GetV(4) - 1;
            if (act == false)
            {

                for (int i = -1; i <= s; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (r == 0)
                        {
                            if (x + i >= 0 && x + i < 10 && y + j >= 0 && y + j < 10) { pole[x + i, y + j] = false; }
                        }
                        else
                        {
                            if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10) { pole[x + j, y + i] = false; }
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < s; i++)
                {
                    if (r == 0)
                    {
                        pole[x + i, y] = false;
                    }
                    else
                    {
                        pole[x, y + i] = false;
                    }
                }
            }
        }
    }
}
