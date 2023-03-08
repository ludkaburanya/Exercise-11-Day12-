using z1;

Locality[] localities = new Locality[]
{
    new City("Витебск",362466, 134),
    new City("Ляховичи", 10997 ,100),
    new City ("Подольск",314934,400),
    new Village("Бояры",20,57,16),
    new Village("Толочки",93,46,20)
};

foreach (Locality locality in localities)
{
    Console.WriteLine($"Плотность населения: {locality.GetPopulation():.###}");
}
Console.Write("Наименьшая плотность населения:");
Console.Write(Locality.GetMinPopulation(localities));