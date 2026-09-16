namespace LegacyCode.Test;

public class OrderDetailProviderStub: IOrderDetailProvider
{
    private readonly Order order;

    public OrderDetailProviderStub(Order order)
    {
        this.order = order;
    }
    public Order? FetchOrderDetails(int orderId)
    {
        return order;
    }
}