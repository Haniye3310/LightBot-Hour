using UnityEngine;
using UnityEngine.UI;

public class Mechanic : MonoBehaviour
{
    private MechanicEnum _mechanicEnum;
    private Sprite[] _mechanicSprites;
    public void SetMechanicEnum(MechanicEnum mechanicEnum) 
    {
        _mechanicEnum = mechanicEnum;
        //this.GetComponent<Image>().sprite = 
    }
}
