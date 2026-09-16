namespace LegacyCode;

public interface IOrderDetailProvider
{
    Order? FetchOrderDetails(int orderId);
}