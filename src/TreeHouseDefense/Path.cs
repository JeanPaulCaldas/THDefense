namespace TreeHouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public int Length => _path.Length;

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
