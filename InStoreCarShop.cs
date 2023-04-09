public class InStoreCarShop : CarShopTemplate
{
    protected override void CheckAvailability(Car car)
    {
        // Check if the car is available for purchase in-store
    }

    protected override void ReserveCar(Car car)
    {
        // Reserve the car for purchase in-store
    }

    protected override void PayForCar(Car car)
    {
        // Pay for the car using in-store payment method
    }

    protected override void ShipCar(Car car)
    {
        // Do not ship the car as it is purchased in-store
    }
}