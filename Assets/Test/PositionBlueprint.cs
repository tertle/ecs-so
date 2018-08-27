using ECS;
using Unity.Transforms;
using UnityEngine;
using Zenject;

namespace Test
{
    [CreateAssetMenu(fileName = "Position", menuName = "BovineLabs/Entities/Component/Position")]
    public class PositionBlueprint : ComponentBlueprint
    {
        [SerializeField] private Position _defaultPosition;
        
        public override void Install(DiContainer container)
        {
            container.BindComponent<Position>().WithValue(_defaultPosition);
        }
    }
}