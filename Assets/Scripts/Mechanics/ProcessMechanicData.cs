using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "ProcessMechanicData[Name]", menuName = "SO/ProcessMechanicData")]

public class ProcessMechanicData : MechanicData
{
    [SerializeField] private MechanicDataList _mechanicDataList;
    public override async Task<bool> Move(Player player)
    {
        for(int i = 0; i < _mechanicDataList.List.Count; i++) 
        {
            if(false== await _mechanicDataList.List[i].Move(player))
                return false;
        }
        return true;
    }
}
