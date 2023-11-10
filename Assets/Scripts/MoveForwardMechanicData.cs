
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveForwardMechanicData[Name]", menuName = "SO/MoveForwardMechanicData")]
public class MoveForwardMechanicData : MechanicData
{
    public override void Move(Player player)
    {
        player.transform.DOMove(new Vector3(
                                           player.transform.position.x + _cubePrefab.transform.localScale.x,
                                           player.transform.position.y,
                                           player.transform.position.z),
                                0.1f
                               );
    }
}