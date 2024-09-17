using Unity.Entities;
using Unity.Mathematics;

namespace DotsInput
{
    public partial struct DotsInputCameraRays : IComponentData
    {
        public struct DotsInputCameraRay
        {
            public float3 from;
            public float3 direction;
        }

        public DotsInputCameraRay center;
        public DotsInputCameraRay pointer;
    }
}