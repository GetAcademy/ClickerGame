using System;

namespace ClickerGame
{
    class Smiley
    {
        //private int _smileyIndex = 0;
        public char Char { get; private set; }

        public Smiley()
        {
            Toggle();
        }

        public void Toggle()
        {
            Char = Char == 'o' ? 'ø' : 'o';
            //_smileyIndex = 1 - _smileyIndex;
        }
    }
}
