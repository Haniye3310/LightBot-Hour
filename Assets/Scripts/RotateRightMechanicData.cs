using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "RotateRightMechanicData[Name]", menuName = "SO/RotateRightMechanicData")]
public class RotateRightMechanicData : MechanicData
{
    public override void Move(Player player)
    {
        player.transform.DORotate(new Vector3(90, 0, 0), 0.1f);
    }
}
