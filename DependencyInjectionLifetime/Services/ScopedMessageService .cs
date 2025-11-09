using DependencyInjectionLifetime.Repositiory;

namespace DependencyInjectionLifetime.Services
{
    public class ScopedMessageService : IMessageService
    {
        private readonly Guid _id;
        public ScopedMessageService()
        {
            _id = Guid.NewGuid();
        }
        public string GetMessage() => $"Scoped ID: {_id}";
    }

}
