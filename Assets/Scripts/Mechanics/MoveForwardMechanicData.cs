
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveForwardMechanicData[Name]", menuName = "SO/MoveForwardMechanicData")]
public class MoveForwardMechanicData : MechanicData
{
    public async override Task<bool> Move(Player player)
    {
        Vector3 targetPos = player.transform.position + player.transform.forward * _cubePrefab.transform.localScale.x;

        bool isValid = (IsValidPos(new Vector3(targetPos.x, targetPos.y - _cubePrefab.transform.localScale.y, targetPos.z)))&&
            (!IsValidPos(new Vector3(targetPos.x ,targetPos.y,targetPos.z)));

        if (isValid)
        {
            var tween = player.transform.DOMove(targetPos, 0.1f);
            await tween.Play().AsyncWaitForCompletion();
        }

        return isValid;
    }
}