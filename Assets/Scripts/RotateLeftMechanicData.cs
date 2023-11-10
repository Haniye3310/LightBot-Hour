using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "RotateLeftMechanicData[Name]", menuName = "SO/RotateLeftMechanicData")]
public class RotateLeftMechanicData : MechanicData
{
    public override void Move(Player player)
    {
        player.transform.DORotate(new Vector3(90, 0, 0), 0.1f);
    }
}