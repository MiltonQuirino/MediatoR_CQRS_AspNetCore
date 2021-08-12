namespace Shop.Domain.Services
{
    public interface IEmailService
    {
        void Send(string name, string email);
    }
}