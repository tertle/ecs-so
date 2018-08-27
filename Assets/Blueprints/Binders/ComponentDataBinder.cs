using ECS.Setters;
using Unity.Entities;

namespace ECS.Binders
{
    public class ComponentDataBinder<T> where T : struct, IComponentData
    {
        private readonly ComponentDataSetter<T> _data;

        public ComponentDataBinder(ComponentDataSetter<T> data)
        {
            _data = data;
        }
        
        public void WithValue(T value)
        {
            _data.Value = value;
        }
    }
}