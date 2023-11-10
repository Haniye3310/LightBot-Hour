using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelClicked;
    [SerializeField] private Cube _cube;
    [SerializeField] private SOChannel _onRunButtonClicked;
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;
    [SerializeField] private SOChannelMechanicData _onMechanicInMainPanelClicked;
    private List<MechanicData> _movements = new List<MechanicData>();
    private void Awake()
    {
        _onLevelClicked.Event.AddListener(OnLevelBtnClicked);
        _onRunButtonClicked.Event.AddListener(OnRunButtonClicked);
        _onMechanicInOptionsClicked.Event.AddListener(OnMechanicInOptionsClicked);
        _onMechanicInMainPanelClicked.Event.AddListener(OnMechanicInMainPanelClicked);
    }
    private void OnDisable()
    {
        _onLevelClicked.Event.RemoveListener(OnLevelBtnClicked);
        _onRunButtonClicked.Event.RemoveListener(OnRunButtonClicked);
        _onMechanicInOptionsClicked.Event.RemoveListener(OnMechanicInOptionsClicked);
        _onMechanicInMainPanelClicked.Event.RemoveListener(OnMechanicInMainPanelClicked);

    }
    private void OnLevelBtnClicked(LevelData levelData) 
    {
        int height =Mathf.Abs(levelData.EnvironmentList[levelData.StartingPlayerPosition.x].Data[levelData.StartingPlayerPosition.y]);
        this.transform.position = new Vector3Int(levelData.StartingPlayerPosition.x,
                                                 (height) * (int)_cube.transform.localScale.y,
                                                 levelData.StartingPlayerPosition.y);
        this.transform.rotation = Quaternion.Euler( this.transform.rotation.eulerAngles.x,
                                                    (int)levelData.StartingPlayerRotation, 
                                                    this.transform.rotation.eulerAngles.z);
    }
    private void OnMechanicInOptionsClicked(MechanicData mechanicData) 
    {
        _movements.Add(mechanicData);
    }
    private void OnMechanicInMainPanelClicked(MechanicData mechanicData) 
    {
        _movements.Remove(mechanicData);
    }
    private async void OnRunButtonClicked() 
    {
        for(int i = 0;i< _movements.Count;i++) 
        {
            await _movements[i].Move(this);
        }
    }
}
