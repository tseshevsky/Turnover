using SimpleInjector;

namespace Turnover.EntityFramework
{
    public class EntityFrameworkInjector
    {
        public void Register(Container container)
        {
            container.RegisterSingleton<TurnoverDbContext>();
        }
    }
}
