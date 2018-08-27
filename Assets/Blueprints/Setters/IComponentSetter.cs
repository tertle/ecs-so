using Unity.Entities;

namespace ECS.Setters
{
    public interface IComponentSetter
    {
        ComponentType Type { get; }
        void SetData(EntityManager entityManager, Entity entity);
    }
}