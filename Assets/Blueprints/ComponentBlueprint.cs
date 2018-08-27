using UnityEngine;
using Zenject;

namespace ECS
{
    public abstract class ComponentBlueprint : ScriptableObject
    {
        public abstract void Install(DiContainer container);
    }
}