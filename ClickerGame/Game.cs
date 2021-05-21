namespace ClickerGame
{
    class Game
    {
        private int _points = 0;
        private int _pointsPerClick = 1;
        private readonly Smiley _smiley;
        public char ClickChar { get; }
        public char UpgradeChar { get; }

        public Game(char clickChar, char upgradeChar)
        {
            UpgradeChar = upgradeChar;
            ClickChar = clickChar;
            _smiley = new Smiley();
        }

        // controller
        public void DoClick()
        {
            _points += _pointsPerClick;
            _smiley.Toggle();
        }

        public void BuyUpgrade()
        {
            if (_points < 10) return;
            _points -= 10;
            _pointsPerClick++;
        }

        // view
        public string UpdateView()
        {
            return _smiley.Char + " " + _points;
        }
    }
}
