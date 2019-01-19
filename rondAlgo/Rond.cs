using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rondAlgo
{
    public class Rond
    {
        public int posX;
        public int posY;
        public int row;
        public int position;

        public Rond()
        { }

        public Rond(int _posX, int _posY, int _row, int _position)
        {
            posX = _posX;
            posY = _posY;
            row = _row;
            position = _position;
        }
    }
}
