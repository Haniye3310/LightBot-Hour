using DG.Tweening;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "JumpMechanicData[Name]", menuName = "SO/JumpMechanicData")]
public class JumpMechanicData : MechanicData
{
    public override async Task<bool> Move(Player player)
    {
        float jumpDistance = 1f;
        float yOffset = -_cubePrefab.transform.localScale.y; 
        float jumpHeight = 0.5f; 
        float jumpDuration = 1f;
        Vector3 jumpTarget = player.transform.position + player.transform.forward * jumpDistance + new Vector3(0f, yOffset, 0f);

        bool isValid = false;
        if(!IsValidPos(player.transform.position + player.transform.forward * jumpDistance)) 
        {
            isValid = IsValidPos(new Vector3(jumpTarget.x, jumpTarget.y - _cubePrefab.transform.localScale.y, jumpTarget.z));
        }
        else 
        {
            isValid = IsValidPos(new Vector3(jumpTarget.x, jumpTarget.y + _cubePrefab.transform.localScale.y, jumpTarget.z));
            jumpTarget = player.transform.position + player.transform.forward * jumpDistance + new Vector3(0f, -yOffset, 0f);
        }

        if (isValid) 
        {
            var tween = player.transform.DOJump(jumpTarget, jumpHeight, 1, jumpDuration);
            await tween.Play().AsyncWaitForCompletion();
        }
        return isValid;
        
    }
}





