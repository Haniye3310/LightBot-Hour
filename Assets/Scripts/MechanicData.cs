using System.Threading.Tasks;
using UnityEngine;
public abstract class MechanicData:ScriptableObject
{
    public Sprite MechanicSprite;
    [SerializeField] protected Cube _cubePrefab;
    public abstract Task<bool> Move( Player player);
    private Cube[] cubes = null;
    protected bool IsValidPos(Vector3 pos) 
    {
        if (null == cubes)
        {
            cubes = FindObjectsOfType<Cube>();
        }

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].transform.position == pos)
                return true;
        }
        return false;
    }
}