using secondaspdotnet.data.interferes;
using secondaspdotnet.data.modeles;

namespace secondaspdotnet.data.mocks;

public class MockCars : IallCars
{

    private readonly IcarsCategory _categoryCars = new MockCategory();
    public IEnumerable<cars> Cars
    {
        get
        {
            return new List<cars>{
            new cars
            {
                name = "Tesla model S",
                shortDesc = "Быстрая машина",
                longDesc = "Стильный, модный, молодежный автомобиль.",
                price = 45000,
                isFavourite = true,
                avaible = true,
                Category = _categoryCars.Allcategories.First()
            },
            new cars
            {
                name = "Lada 2114",
                shortDesc = "Пожилая машина",
                longDesc = "Кусок дерьма на колесах, 1 колесo из 10.",
                price = 8900,
                isFavourite = false,
                avaible = true,
                Category = _categoryCars.Allcategories.Last()
            },
            new cars
            {
                name = "BMW M3",
                shortDesc = "Дерзский и стильный",
                longDesc = "Удобный автомобиль для городской езды",
                price = 65000,
                isFavourite = true,
                avaible = true,
                Category = _categoryCars.Allcategories.Last()
            },
            new cars
            {
                name = "Ford Fiesta",
                shortDesc = "Тихий и спокойный",
                longDesc = "Удобный автомобиль для городской жизни",
                price = 65000,
                isFavourite = true,
                avaible = true,
                Category = _categoryCars.Allcategories.Last()
            },
        };

    }
}
public IEnumerable<cars> getFavCars { get; set; }

public cars getObjectCar(int carId)
{
    throw new NotImplementedException();
}
}
