using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "JumpMechanicData[Name]", menuName = "SO/JumpMechanicData")]
public class JumpMechanicData : MechanicData
{
    public override void Move(Player player)
    {
        Debug.Log("Jump");
        player.transform.DOJump(new Vector3(
                                           player.transform.position.x + _cubePrefab.transform.localScale.x,
                                           player.transform.position.y,
                                           player.transform.position.z),
                                0.1f,
                                1,
                                0.1f);
    }
}
