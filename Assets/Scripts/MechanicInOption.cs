using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechanicInOption : MechanicBase
{
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;

    protected override void OnMechanicClicked()
    {
        _onMechanicInOptionsClicked.Event?.Invoke(_mechanicData);
    }
}
