using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private IntVariable _currentLevelNumber;
    [SerializeField] private LevelDataList _levels;
    [SerializeField] private Cube _cube;
    [SerializeField] private SOChannel _onRunButtonClicked;
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;
    [SerializeField] private SOChannelMechanicData _onMechanicInMainPanelClicked;
    [SerializeField] SOChannel _OnPlayCompleted;
    [SerializeField] SOChannel _OnRetryButtonClicked;
    private List<MechanicData> _movements = new List<MechanicData>();
    private LevelData _levelData;
    private void Awake()
    {
        _OnRetryButtonClicked.Event.AddListener(OnRetryButtonClicked);
        _onRunButtonClicked.Event.AddListener(OnRunButtonClicked);
        _onMechanicInOptionsClicked.Event.AddListener(OnMechanicInOptionsClicked);
        _onMechanicInMainPanelClicked.Event.AddListener(OnMechanicInMainPanelClicked);
        Init();
    }
    private void OnDisable()
    {
        _onRunButtonClicked.Event.RemoveListener(OnRunButtonClicked);
        _onMechanicInOptionsClicked.Event.RemoveListener(OnMechanicInOptionsClicked);
        _onMechanicInMainPanelClicked.Event.RemoveListener(OnMechanicInMainPanelClicked);
        _OnRetryButtonClicked.Event.RemoveListener(OnRetryButtonClicked);
    }
    private void OnRetryButtonClicked() 
    {
        Init();
        Cube[] cubes = FindObjectsOfType<Cube>();

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].IsLight()) cubes[i].Target();

        }
    }
    private void Init() 
    {
        var levelData = _levels.List[_currentLevelNumber.Value - 1];
        int height =Mathf.Abs(levelData.EnvironmentList[levelData.StartingPlayerPosition.x].Data[levelData.StartingPlayerPosition.y]);
        this.transform.position = new Vector3Int(levelData.StartingPlayerPosition.x,
                                                 (height) * (int)_cube.transform.localScale.y,
                                                 levelData.StartingPlayerPosition.y);
        this.transform.rotation = Quaternion.Euler( this.transform.rotation.eulerAngles.x,
                                                    (int)levelData.StartingPlayerRotation, 
                                                    this.transform.rotation.eulerAngles.z);
        _levelData = levelData;
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
            if (false == await _movements[i].Move(this))
            {
                break;
            }
        }
        _OnPlayCompleted.Event?.Invoke();
    }
}
