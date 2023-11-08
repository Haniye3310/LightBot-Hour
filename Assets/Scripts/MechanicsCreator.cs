using UnityEngine;
using UnityEngine.UI;

public class MechanicsCreator : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
    [SerializeField] private Mechanic _mechanicBtn;
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
        for(int i = 0; i < levelData.AvailableMechanics.Length; i++) 
        {
            var mechanic = Instantiate(_mechanicBtn,this.transform.position,Quaternion.identity,this.transform);
        }
    }
}
