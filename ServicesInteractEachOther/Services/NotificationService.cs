namespace ServicesInteractEachOther.Services
{
    public class NotificationService : INotificationService
    {
        public void NotifyOrder(int orderId)
        {
            Console.WriteLine($"Notificaiton sent: {orderId}");
        }
    }
}
