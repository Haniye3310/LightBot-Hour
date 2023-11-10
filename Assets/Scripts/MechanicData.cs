using System.Threading.Tasks;
using UnityEngine;
public abstract class MechanicData:ScriptableObject
{
    public Sprite MechanicSprite;
    [SerializeField] protected Cube _cubePrefab;
    public abstract Task Move( Player player);
}