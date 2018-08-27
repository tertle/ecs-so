using ECS.Binders;
using ECS.Setters;
using Unity.Entities;
using Zenject;

using Inject = Zenject.InjectAttribute;

namespace ECS
{
    public static class DiContainerExtension
    {          
        public static ComponentDataBinder<T> BindComponent<T>(this DiContainer container)
            where T : struct, IComponentData
        {
            var data = new ComponentDataSetter<T>();
            container.Bind<IComponentSetter>().To<ComponentDataSetter<T>>().FromInstance(data).AsSingle();

            return new ComponentDataBinder<T>(data);
        }

        public static SharedComponentDataBinder<T> BindSharedComponent<T>(this DiContainer container)
            where T : struct, ISharedComponentData
        {
            var data = new SharedComponentDataSetter<T>();
            container.Bind<IComponentSetter>().To<SharedComponentDataSetter<T>>().FromInstance(data).AsSingle();

            return new SharedComponentDataBinder<T>(data);
        }

        public static BufferArrayBinder<T> BindBufferArray<T>(this DiContainer container)
            where T : struct, IBufferElementData
        {
            var data = new BufferArraySetter<T>();
            container.Bind<IComponentSetter>().To<BufferArraySetter<T>>().FromInstance(data).AsSingle();

            return new BufferArrayBinder<T>(data);
        }
    }
}