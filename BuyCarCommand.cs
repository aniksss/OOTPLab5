public class BuyCarCommand : ICommand
{
    private readonly CarShopTemplate _shop;
    private readonly Car _car;

    public BuyCarCommand(CarShopTemplate shop, Car car)
    {
        _shop = shop;
        _car = car;
    }

    public void Execute()
    {
        _shop.BuyCar(_car);
    }

    public void Undo()
    {
        // Undo the purchase of the car
    }
}