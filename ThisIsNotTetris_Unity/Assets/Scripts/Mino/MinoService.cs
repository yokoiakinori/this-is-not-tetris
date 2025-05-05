using System;
using System.Runtime.InteropServices;

namespace Mino
{
    public class MinoService
    {
        private int _widthIndex;
        private int _heightIndex;
        private readonly int _maxWidth = 5;
        private readonly int _maxHeight = 10;
        
        public MinoService()
        {
            _widthIndex = 0;
            _heightIndex = 10;
        }

        public void MoveRight()
        {
            if (_widthIndex < _maxWidth)
            {
                _widthIndex++;
            }
        }

        public void MoveLeft()
        {
            if (_widthIndex > -_maxWidth)
            {
                _widthIndex--;
            }
        }

        public void MoveDown()
        {
            if (_heightIndex > -_maxHeight)
            {
                _heightIndex--;
            }
        }

        public (int, int) GetPosition()
        {
            return (_widthIndex, _heightIndex);
        }
    }
}