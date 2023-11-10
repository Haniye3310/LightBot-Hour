using UnityEngine;
public abstract class MechanicData:ScriptableObject
{
    public Sprite MechanicSprite;
    [SerializeField] protected Cube _cubePrefab;
    public abstract void Move( Player player);
}