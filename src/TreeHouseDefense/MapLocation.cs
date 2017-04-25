namespace TreeHouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new System.Exception(this + " is out of the boundaries of the map." );
            }
        }

        public bool InRangeOf(MapLocation location, int range) => DistanceTo(location) <= range;
        
    }
}
