using Unity.Entities;

namespace ECS.Setters
{
    public class BufferArraySetter<T> : IComponentSetter where T : struct, IBufferElementData
    {
        private int _length;

        public int Length
        {
            set => _length = value;
        }

        public ComponentType Type { get; } = ComponentType.Create<T>();

        public void SetData(EntityManager entityManager, Entity entity)
        {
            if (_length <= 0) return;
            
            var buffer = entityManager.GetBuffer<T>(entity);
            buffer.ResizeUninitialized(_length);
        }
    }
}