
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveForwardMechanicData[Name]", menuName = "SO/MoveForwardMechanicData")]
public class MoveForwardMechanicData : MechanicData
{
    public override Task Move(Player player)
    {
         var tween = player.transform.DOMove(player.transform.position + player.transform.forward * _cubePrefab.transform.localScale.x,
                                0.1f
                               );
        return tween.Play().AsyncWaitForCompletion();
    }
}