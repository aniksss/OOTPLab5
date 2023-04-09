public abstract class CarShopTemplate
{
    public void BuyCar(Car car)
    {
        CheckAvailability(car);
        ReserveCar(car);
        PayForCar(car);
        ShipCar(car);
    }

    protected virtual void CheckAvailability(Car car)
    {
        // Check if the car is available for purchase
    }

    protected virtual void ReserveCar(Car car)
    {
        // Reserve the car for purchase
    }

    protected abstract void PayForCar(Car car);

    protected virtual void ShipCar(Car car)
    {
        // Ship the car to the customer
    }
}