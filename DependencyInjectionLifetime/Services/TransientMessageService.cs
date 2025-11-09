using DependencyInjectionLifetime.Repositiory;

namespace DependencyInjectionLifetime.Services
{
    public class TransientMessageService : IMessageService
    {
        private readonly Guid _id;
        public TransientMessageService()
        {
            _id = Guid.NewGuid();
        }
        public string GetMessage() => $"Transient ID: {_id}";
    }
}
