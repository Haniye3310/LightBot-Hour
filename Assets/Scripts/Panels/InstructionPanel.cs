using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InstructionPanel : MonoBehaviour
{
    [SerializeField] private MechanicBase _mechanicPrefab;
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;
    [SerializeField] protected bool _isActive;
    [SerializeField] private Button _btn;
    protected virtual void Awake()
    {
        SetActive(_isActive);
        _btn.onClick.AddListener(OnPanelClicked);
        _onMechanicInOptionsClicked.Event.AddListener(OnMechanicClicked);
    }
    protected virtual void OnDestroy()
    {
        _onMechanicInOptionsClicked.Event.RemoveListener(OnMechanicClicked);
        _btn.onClick.RemoveListener(OnPanelClicked);
    }
    protected virtual void OnPanelClicked()
    {

    }
    private void OnMechanicClicked(MechanicData mechanicData)
    {
        if (_isActive) 
        {
            MechanicBase mechanic = MechanicBase.Instantiate(_mechanicPrefab,
                                 this.transform.position,
                                 Quaternion.identity,
                                 this.transform,
                                 mechanicData);
            ((MechanicInPanel)mechanic).SetIsMain(this is MainPanel);
        }

    }
    protected void SetActive(bool active) 
    {
        _isActive = active;
        if (active) 
            this.gameObject.GetComponent<Image>().color = new Color(1f, 0.9f, 0f, 1);
        else
            this.gameObject.GetComponent<Image>().color = new Color(0.7f, 0.7f, 0.7f, 1);
    }
}

