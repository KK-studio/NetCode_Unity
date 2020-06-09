
using Unity.Entities;
using Unity.NetCode;

[GenerateAuthoringComponent]
public struct Movement : IComponentData
{
    [GhostDefaultField] public int ID;
}
