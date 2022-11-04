using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Race
{
    internal class Racer
    {
        public int Speed { get; set; }
        public int Id { get; }
        private int pos { get; set; } = 0;
        public string RectId { get; }
        public Color Kolor { get; }
        public Racer(int Id, int Speed, int RectId, Windows.UI.Color Kolor)
        {
            this.Id = Id;
            this.Speed = Speed;
            this.RectId = RectId.ToString();
            this.Kolor = Kolor;
        }
        public void UpdatePos()
        {
            pos += this.Speed;
        }
        public void UpdatePos(int offset)
        {
            pos += offset;
        }
        public void UpdatePos(float bonus)
        {
            pos += (int)(this.Speed * bonus);
        }
        public int GetPos()
        {
            return pos;
        }
        public bool CheckEnd()
        {
            if (this.pos > 900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Vector3 DisplayPos()
        {
            return new Vector3(this.pos, 0, 0);
        }
    }
}
