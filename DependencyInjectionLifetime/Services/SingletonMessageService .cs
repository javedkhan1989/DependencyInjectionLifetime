using DependencyInjectionLifetime.Repositiory;

namespace DependencyInjectionLifetime.Services
{
    public class SingletonMessageService : IMessageService
    {
        private readonly Guid _id;
        public SingletonMessageService()
        {
            _id = Guid.NewGuid();
        }
        public string GetMessage() => $"Singleton ID: {_id}";
    }

}
