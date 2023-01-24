using secondaspdotnet.data.modeles;

namespace secondaspdotnet.data.interferes;

public interface IallCars
{
    IEnumerable<cars> Cars {get;}  
    IEnumerable<cars> getFavCars {get; set;}
    cars getObjectCar (int carId);
}
