
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "LightMechanicData[Name]", menuName = "SO/LightMechanicData")]
public class LightMechanicData : MechanicData
{
    public override Task Move(Player player)
    {
        return Task.CompletedTask;

    }
}