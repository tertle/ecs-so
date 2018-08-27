using Unity.Entities;

namespace ECS.Setters
{
    public class SharedComponentDataSetter<T> : IComponentSetter where T : struct, ISharedComponentData
    {
        private T? _value;

        public T Value
        {
            set => _value = value;
        }

        public ComponentType Type { get; } = ComponentType.Create<T>();

        public void SetData(EntityManager entityManager, Entity entity)
        {
            if (_value.HasValue)
                entityManager.SetSharedComponentData(entity, _value.Value);
        }
    }
}