namespace TreeHouseDefense
{
    class LongRangeTower:Tower
    {
        protected virtual int Range { get; } = 2;

        public LongRangeTower(MapLocation location) : base(location) { }
    }
}
