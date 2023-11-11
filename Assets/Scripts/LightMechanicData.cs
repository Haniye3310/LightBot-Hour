
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "LightMechanicData[Name]", menuName = "SO/LightMechanicData")]
public class LightMechanicData : MechanicData
{
    [SerializeField] private SOChanneVector3 _onLightClicked;
    public override Task Move(Player player)
    {
        Vector3 cubePosition = new Vector3(player.transform.position.x,
                                           player.transform.position.y - _cubePrefab.transform.localScale.y,
                                           player.transform.position.z);

        _onLightClicked?.Event.Invoke(cubePosition);
        return Task.CompletedTask;

    }
}