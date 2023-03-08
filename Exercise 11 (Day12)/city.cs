namespace z1
{
    internal class City : Locality
    {
        private int Population;
        private int square;
        public City(string name, int Population, int square) : base(name)
        {
            this.Population = Population;
            this.square = square;
        }

        public override int GetPopulation() => Population / square;
    }
}