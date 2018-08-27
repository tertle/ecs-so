using ECS;
using Unity.Rendering;
using UnityEngine;
using Zenject;

namespace Test
{
    [CreateAssetMenu(fileName = "MeshInstanceRenderer", menuName = "BovineLabs/Entities/Component/Mesh Instance Renderer")]
    public class MeshInstanceRendererBlueprint : ComponentBlueprint
    {
        [SerializeField] private Mesh _mesh;
        [SerializeField] private Material _material;
        
        public override void Install(DiContainer container)
        {
            container.BindSharedComponent<MeshInstanceRenderer>().WithValue(new MeshInstanceRenderer
            {
                mesh = _mesh,
                material = _material
            });
        }
    }
}