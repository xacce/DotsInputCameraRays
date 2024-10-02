using Unity.Entities;
using UnityEngine;

namespace DotsInput
{
    public partial struct DotsInputCameraRaysSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            var camera = Camera.main;
            if (camera == null) return;
            foreach (var (raysRwo, axis) in SystemAPI.Query<RefRW<DotsInputCameraRays>, DynamicBuffer<DotsInputAxisElement>>())
            {
                if (axis.Length == 0) return;
                ref var raysRw = ref raysRwo.ValueRW;
                var uray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                var upray = camera.ScreenPointToRay(axis[0].GetFloat3());

                raysRw.center = new DotsInputCameraRays.DotsInputCameraRay { from = uray.origin, direction = uray.direction };
                raysRw.pointer = new DotsInputCameraRays.DotsInputCameraRay { from = upray.origin, direction = upray.direction };
            }
        }
    }
}