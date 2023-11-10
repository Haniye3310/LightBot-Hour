using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "RotateLeftMechanicData[Name]", menuName = "SO/RotateLeftMechanicData")]
public class RotateLeftMechanicData : MechanicData
{
    public override Task Move(Player player)
    {
        float rotationDuration = 1f;
        Vector3 targetRotation = new Vector3(0f, player.transform.eulerAngles.y - 90f, 0f);
        var tween = player.transform.DORotate(targetRotation, rotationDuration);
        return tween.Play().AsyncWaitForCompletion();

    }
}