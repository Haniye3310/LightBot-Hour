using System.Threading.Tasks;
using UnityEngine;
public abstract class MechanicData : ScriptableObject
{
    public Sprite MechanicSprite;
    [SerializeField] protected Cube _cubePrefab;
    public abstract Task<bool> Move(Player player);
    protected bool IsValidPos(Vector3 pos)
    {
        Cube[] cubes = FindObjectsOfType<Cube>();

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].transform.position == pos)
                return true;
        }
        return false;
    }
}