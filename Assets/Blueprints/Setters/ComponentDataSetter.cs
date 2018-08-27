using Unity.Entities;

namespace ECS.Setters
{
    public class ComponentDataSetter<T> : IComponentSetter where T : struct, IComponentData
    {
        private T? _value;

        public T Value
        {
            set => _value = value;
        }

        public ComponentType Type { get; } = ComponentType.Create<T>();

        public void SetData(EntityManager entityManager, Entity entity)
        {
            // Equals is a bit dirty but I should find a nicer way of doing this
            // Something like the ECS FastEquality method
            if (_value.HasValue)
                entityManager.SetComponentData(entity, _value.Value);
        }
    }
}