using ECS.Setters;
using Unity.Entities;

namespace ECS.Binders
{
    public class BufferArrayBinder<T> where T : struct, IBufferElementData
    {
        private readonly BufferArraySetter<T> _data;

        public BufferArrayBinder(BufferArraySetter<T> data)
        {
            _data = data;
        }
        
        public void WithLength(int length)
        {
            _data.Length = length;
        }
    }
}