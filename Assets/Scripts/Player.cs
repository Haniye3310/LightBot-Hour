using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelClicked;
    [SerializeField] private GameObject _cube;
    private void Awake()
    {
        _onLevelClicked.Event.AddListener(OnLevelBtnClicked);
    }
    private void OnDisable()
    {
        _onLevelClicked.Event.RemoveListener(OnLevelBtnClicked);

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
}
