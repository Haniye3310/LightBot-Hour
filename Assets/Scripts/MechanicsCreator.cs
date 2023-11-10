using UnityEngine;
using UnityEngine.UI;

public class MechanicsCreator : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
    [SerializeField] private Mechanic _mechanicPrefab;
    private void Awake()
    {
        _onLevelBtnClicked.Event.AddListener(OnLevelBtnClicked);
    }
    private void OnDisable()
    {
        _onLevelBtnClicked.Event.AddListener(OnLevelBtnClicked);
    }
    private void OnLevelBtnClicked(LevelData levelData) 
    {
        Vector3 pos = this.transform.position;
        for (int i = 0; i < levelData.AvailableMechanics.Length; i++) 
        {
            var mechanic = Instantiate(_mechanicPrefab,pos,Quaternion.identity,this.transform);
            mechanic.SetMechanicData(levelData.AvailableMechanics[i]);
            pos = new Vector3(pos.x + _mechanicPrefab.GetComponent<RectTransform>().sizeDelta.x + 10f, pos.y,pos.z);
        }
    }
}
