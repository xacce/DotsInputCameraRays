#if UNITY_EDITOR
using Unity.Entities;
using UnityEngine;

namespace DotsInput
{
    [RequireComponent(typeof(DotsInputAuthoring))]
    [DisallowMultipleComponent]
    public class DotsInputCameraRaysAuthoring : MonoBehaviour
    {
        private class DotsInputCameraRaysBaker : Baker<DotsInputCameraRaysAuthoring>
        {
            public override void Bake(DotsInputCameraRaysAuthoring authoring)
            {
                var e = GetEntity(TransformUsageFlags.None);
                AddComponent<DotsInputCameraRays>(e);
            }
        }
    }
}
#endif