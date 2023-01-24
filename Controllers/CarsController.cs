using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using secondaspdotnet.data.interferes;
using secondaspdotnet.Models;

namespace secondaspdotnet.Controllers;

public class CarsController : Controller
{

    private readonly IallCars _allCars;
    private readonly IcarsCategory _allCategories;

    public CarsController(IallCars iallCars, IcarsCategory ICarsCat)
    {
        _allCars = iallCars;
        _allCategories = ICarsCat; 
    }

    public ViewResult List() {
        var cars = _allCars.Cars;
        return  View(cars);
    }    
}
