using ECS;
using Unity.Transforms;
using UnityEngine;
using Zenject;

namespace Test
{
    [CreateAssetMenu(fileName = "Rotation", menuName = "BovineLabs/Entities/Component/Rotation")]
    public class RotationBlueprint : ComponentBlueprint
    {
        [SerializeField] private Rotation _default;
        
        public override void Install(DiContainer container)
        {
            container.BindComponent<Rotation>().WithValue(_default);
        }
    }
}