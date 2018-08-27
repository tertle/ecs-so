using JetBrains.Annotations;
using Unity.Entities;
using Zenject;

namespace ECS
{
	public class EntityFactory 
	{
		private readonly Factory _factory;

		public EntityFactory(Factory factory)
		{
			_factory = factory;
		}
		
		public Entity Create(Blueprint blueprint)
		{
			return Create(blueprint, World.Active);
		}
		
		public Entity Create(Blueprint blueprint, World world)
		{
			return _factory.Create(blueprint, world);
		}

		[UsedImplicitly(ImplicitUseKindFlags.Assign)]
		public class Factory : PlaceholderFactory<Blueprint, World, Entity>
		{
		
		}
	}
}