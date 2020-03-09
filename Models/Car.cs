namespace CarDealership.Models
{
  public class Car
  {
    public string Make {get; set;}
    public string Model {get; set;}
    public string Year {get; set;}
    private static List<Car> _carList = new List<Car>();
    public Car(string make, string model, int year)
    {
      Make = make;
      Model = model;
      Year = year;
      _carList.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _carList;
    }

    public void ClearAllCars()
    {
      _carList.Clear();
    }
  }
}