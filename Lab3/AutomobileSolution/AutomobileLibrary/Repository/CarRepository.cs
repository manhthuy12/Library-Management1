using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarDAO.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarsList();
        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);
        public void DeleteCar(int carID) => CarDAO.Instance.Remove(carID);
        public void UpdateCar(Car car) => CarDAO.Instance.UpdateCar(car);
    }
}
