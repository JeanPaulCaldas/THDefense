namespace TreeHouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location { get => _path.GetLocationAt(_pathStep); }

        public virtual int Health { get; protected set; } = 2;

        public bool HasScored { get => _pathStep >= _path.Length; }

        public bool IsNeutralized => Health < 1;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path) => _path = path;

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Hit on target!");
        }
    }
}
