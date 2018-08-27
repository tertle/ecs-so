using System.Collections.Generic;
using System.Linq;
using ECS.Setters;
using Unity.Entities;

namespace ECS
{
    public class EntityFinalizier
    {
        public Entity Entity;
        
        public EntityFinalizier(Blueprint blueprint, World world, List<IComponentSetter> components)
        {
            var manager = world.GetExistingManager<EntityManager>();
            var archetype = manager.CreateArchetype(components.Select(c => c.Type).ToArray());
            
            Entity = manager.CreateEntity(archetype);

            foreach (var component in components)
                component.SetData(manager, Entity);
        }
    }
}