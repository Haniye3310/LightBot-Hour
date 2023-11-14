using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanicInPanel : MechanicBase
{
    [SerializeField] private MechanicDataList _mainMovements;
    [SerializeField] private MechanicDataList _processMovements;
    private bool _isMain;
    private void Start() 
    {
        if (_isMain) 
        {
            _mainMovements.List.Add(_mechanicData);
        }
        else 
        {
            _processMovements.List.Add(_mechanicData);
        }
    }
    public void SetIsMain(bool isMain) 
    {
        _isMain = isMain;
    }
    private void OnDestroy()
    {
        if (_isMain)
        {
            _mainMovements.List.Remove(_mechanicData);
        }
        else
        {
            _processMovements.List.Remove(_mechanicData);
        }
    }
    protected override void OnMechanicClicked()
    {
        Destroy(this.gameObject);
    }
}
