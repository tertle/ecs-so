using ECS.Setters;
using Unity.Entities;

namespace ECS.Binders
{
    public class SharedComponentDataBinder<T> where T : struct, ISharedComponentData
    {
        private readonly SharedComponentDataSetter<T> _data;

        public SharedComponentDataBinder(SharedComponentDataSetter<T> data)
        {
            _data = data;
        }
        
        public void WithValue(T value)
        {
            _data.Value = value;
        }
    }
}