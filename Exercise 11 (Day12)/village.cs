namespace z1
{
    internal class Village : Locality
    {
        private int Houses;
        private int People;
        private int square;
        public Village(string name, int Houses, int People, int square) : base(name)
        {
            this.Houses = Houses;
            this.People = People;
            this.square = square;
        }
        public override int GetPopulation() => (People * Houses) / square;
    }
}
