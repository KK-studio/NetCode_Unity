
using Unity.Entities;
using Unity.NetCode;

[GenerateAuthoringComponent]
public struct MovementComponent : IComponentData
{
    [GhostDefaultField] public int ID;
}
