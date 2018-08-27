using Zenject;

namespace ECS
{
    public class EntitySubContainerBinder : SubContainerBinder
    {
        public EntitySubContainerBinder(BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper, object subIdentifier, bool resolveAll) : base(bindInfo, finalizerWrapper, subIdentifier, resolveAll)
        {
        }
    }
}