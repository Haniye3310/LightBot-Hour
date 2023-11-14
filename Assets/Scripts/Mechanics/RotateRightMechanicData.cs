using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "RotateRightMechanicData[Name]", menuName = "SO/RotateRightMechanicData")]
public class RotateRightMechanicData : MechanicData
{
    public  override async Task<bool> Move(Player player)
    {
        float rotationAngle = 90f;
        float rotationDuration = 1f;
        Vector3 targetRotation = new Vector3(0f, player.transform.eulerAngles.y + rotationAngle, 0f);
        var tween = player.transform.DORotate(targetRotation, rotationDuration);
        await tween.Play().AsyncWaitForCompletion();
        return true;
    }
         
}
