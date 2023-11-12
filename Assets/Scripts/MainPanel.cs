using Unity.VisualScripting;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    [SerializeField] private Mechanic _mechanicPrefab;
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;
    private void Awake()
    {
        _onMechanicInOptionsClicked.Event.AddListener(OnMechanicClicked);
    }
    private void OnDisable()
    {
        _onMechanicInOptionsClicked.Event.RemoveListener(OnMechanicClicked);
    }
    private void OnMechanicClicked(MechanicData mechanicData) 
    {
        Mechanic.Instantiate(_mechanicPrefab,
                             this.transform.position,
                             Quaternion.identity,
                             this.transform, 
                             mechanicData,
                             true);

    }
}
