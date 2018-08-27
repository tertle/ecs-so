using ECS;
using Unity.Entities;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "EntityInstaller", menuName = "BovineLabs/Entity Installer")]
public class EntityInstaller : ScriptableObjectInstaller 
{
	public override void InstallBindings()
	{
		Container.Bind<EntityFactory>().AsSingle();

		Container.BindFactory<Blueprint, World, Entity, EntityFactory.Factory>()
			.FromSubContainerResolve()
			.ByMethod((container, blueprint, world) => blueprint.Install(container, world))
			.WhenInjectedInto<EntityFactory>();
	}
}