using UnityEngine;

public class EnvironmentCreator : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
    [SerializeField] private Cube _cubePrefab;
    private void Awake()
    {
        _onLevelBtnClicked.Event.AddListener(OnLevelBtnClicked);
    }
    private void OnDisable()
    {
        _onLevelBtnClicked.Event.RemoveListener(OnLevelBtnClicked);

    }
    private void OnLevelBtnClicked(LevelData levelData) 
    {
        Vector3 pos = new Vector3(0, 0, 0);
        Vector3 scale = _cubePrefab.transform.localScale;
        for (int i = 0; i < levelData.EnvironmentList.Count; i++)
        {
            for(int j = 0; j < levelData.EnvironmentList[i].Data.Count; j++) 
            {
                for(int k =0; k < Mathf.Abs(levelData.EnvironmentList[i].Data[j]); k++) 
                {
                    var cube = Instantiate(_cubePrefab, pos, Quaternion.identity, transform);
                    if (levelData.EnvironmentList[i].Data[j] < 0 && k == Mathf.Abs(levelData.EnvironmentList[i].Data[j]) - 1)
                    {
                        cube.Target();
                    }
                    pos = new Vector3(pos.x, pos.y + scale.y, pos.z);
                }
                pos = new Vector3(pos.x, 0, pos.z + scale.z);
            }
            pos = new Vector3(pos.x+ scale.x, 0,0);
        }
    }
}
