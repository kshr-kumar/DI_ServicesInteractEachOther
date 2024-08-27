namespace ServicesInteractEachOther.Services
{
    public class OrderService : IOrderService 
    {
        INotificationService _notificationService;

        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder(int orderId)
        {
            Console.WriteLine($"Order {orderId} has been placed");
            _notificationService.NotifyOrder(orderId);
        }
    }
}
