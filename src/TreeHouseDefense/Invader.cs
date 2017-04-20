namespace TreeHouseDefense
{
    class Invader
    {
        private int _pathStep = 0;
        private readonly Path _path;

        public MapLocation Location { get => _path.GetLocationAt(_pathStep); }

        public int Health { get; private set; } = 2;

        public bool HasScored { get => _pathStep >= _path.Length; }

        public bool IsNeutralized => Health < 1;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path) => _path = path;

        public void Move() => _pathStep++;

        public void DecreaseHealth(int factor) => Health -= factor;

    }
}
