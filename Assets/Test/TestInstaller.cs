using ECS;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using Zenject;

namespace Test
{
    public class TestInstaller : MonoInstaller<TestInstaller>
    {
        [SerializeField] private Blueprint[] _blueprints;
        
        public override void InstallBindings()
        {
            Container.Bind<IInitializable>().To<Init>().AsSingle();
            Container.Bind<Blueprint[]>().FromInstance(_blueprints).AsSingle();
        }

        public class Init : IInitializable
        {
            private readonly Blueprint[] _blueprints;
            private readonly EntityFactory _factory;

            private readonly Blueprint _blueprint;

            public Init(EntityFactory factory)
            {
                var entity1 = factory.Create(_blueprint);
                var entity2 = factory.Create(_blueprint, World.Active);
            }
            
            public void Initialize()
            {
                // Normally would inject this
                var world = World.Active;
                var entityManager = world.GetExistingManager<EntityManager>();
                
                foreach(var blueprint in _blueprints)
                {
                    var entity = _factory.Create(blueprint, world);
                    //entityManager.SetComponentData(entity, new Position {Value = new float3(0, 0, 0)});
                }
            }
        }
    }
}