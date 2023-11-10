using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "JumpMechanicData[Name]", menuName = "SO/JumpMechanicData")]
public class JumpMechanicData : MechanicData
{

    public override Task Move(Player player)
    {
        float jumpDistance = 1f;
        float yOffset = -_cubePrefab.transform.localScale.y; 
        float jumpHeight = 0.5f; 
        float jumpDuration = 1f;
        Vector3 jumpTarget = player.transform.position + player.transform.forward * jumpDistance + new Vector3(0f, yOffset, 0f);

        var tween = player.transform.DOJump(jumpTarget, jumpHeight, 1, jumpDuration);
        return tween.Play().AsyncWaitForCompletion();
    }
}





