namespace LegacyCode.Test;

[TestFixture]
public class ShippingCalculatorTests
{
    private ShippingCalculator ShippingCalculator;

    [Test]
    public void CalculatingStandardShippingCostCalculatesCostBasedOnOrder()
    {
        var order = new Order
        {
            OrderId = 1001,
            WeightKg = 5.0,
            DistanceKm = 10.0,
            Fragile = false,
            ShippingType = "STANDARD"
        };
        
        ShippingCalculator = new ShippingCalculator(
            new OrderDetailProviderStub(order));
        var actualShippingCost = ShippingCalculator.CalculateShipping(order.OrderId);
        
        Assert.That(actualShippingCost, Is.EqualTo(2.5));
    }

    [Test]
    public void CalculatingExpressShippingCostCalculatesCostBasedOnOrder()
    {
        var order = new Order
        {
            OrderId = 1002,
            WeightKg = 45,
            DistanceKm = 8.0,
            Fragile = false,
            ShippingType = "EXPRESS"
        };

        ShippingCalculator = new ShippingCalculator(new OrderDetailProviderStub(order));
        var actualShippingCost = ShippingCalculator.CalculateShipping(order.OrderId);

        Assert.That(actualShippingCost, Is.EqualTo(36.8));
    }

    [Test]
    public void CalculatingOvernightShippingCostCalculatesCostBasedOnOrder()
    {
        var order = new Order
        {
            OrderId = 1003,
            WeightKg = 2,
            DistanceKm = 10.0,
            Fragile = false,
            ShippingType = "OVERNIGHT"
        };

        ShippingCalculator = new ShippingCalculator(new OrderDetailProviderStub(order));
        var actualShippingCost = ShippingCalculator.CalculateShipping(order.OrderId);

        Assert.That(actualShippingCost, Is.EqualTo(27.4));
    }

    [Test]
    public void CalculatingInternationalShippingCostCalculatesCostBasedOnOrder()
    {
        var order = new Order
        {
            OrderId = 1004,
            WeightKg = 10,
            DistanceKm = 10.0,
            Fragile = false,
            ShippingType = "INTERNATIONAL"
        };

        ShippingCalculator = new ShippingCalculator(new OrderDetailProviderStub(order));
        var actualShippingCost = ShippingCalculator.CalculateShipping(order.OrderId);

        Assert.That(actualShippingCost, Is.EqualTo(15.0));
    }
}