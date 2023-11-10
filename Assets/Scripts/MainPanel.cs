using Unity.VisualScripting;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    [SerializeField] private Mechanic _mechanicPrefab;
    //[SerializeField] SOChannel OnMechanicClicked
    private void OnMechanicClicked() 
    {
        Mechanic mechanic = Instantiate(_mechanicPrefab, this.transform.position, Quaternion.identity,this.transform);

        Mechanic mechanic = Mechanic.Instantiate(true);
    }
}
