using System.Threading.Tasks;
using System.Xml.Linq;

namespace z1
{
    internal abstract class Locality
    {
        private string name;
        public string Name { get => name; }
        public Locality(string name)
        {
            this.name = name;
        }
        public virtual int GetPopulation() => 5;
        public static double GetMinPopulation(Locality[] localities)
        {
            if (localities != null)
            {
                int min = localities[0].GetPopulation();
                for (int i = 0; i < localities.Length; i++)
                {
                    if (min > localities[i].GetPopulation())
                    {
                        min = localities[i].GetPopulation();

                    }
                }
                return min;
            }
            throw new Exception("Нулевой массив!");
        }
    }
}