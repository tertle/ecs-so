using Unity.Entities;
using UnityEngine;
using Zenject;

namespace ECS
{
    [CreateAssetMenu(fileName = "Blueprint", menuName = "BovineLabs/Entities/Blueprint")]
    public class Blueprint : ScriptableObject
    {
        [SerializeField] private ComponentBlueprint[] _customInstallers = new ComponentBlueprint[0];
    
        public void Install(DiContainer container, World world)
        {
            // Entity is created within the EntityFinalizier after it has been initialized
            container.Bind<EntityFinalizier>().AsSingle().WithArguments(this, world);
            container.Bind<Entity>().FromResolveGetter<EntityFinalizier>(e => e.Entity).AsSingle();
        
            foreach (var installer in _customInstallers)
                installer.Install(container);
        }
    }
}