namespace TreeHouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .85;

        public SniperTower(MapLocation location) : base(location) { }
    }
}
