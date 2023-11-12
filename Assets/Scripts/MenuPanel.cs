using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
    [SerializeField] private LevelData[] _levelData;
    [SerializeField] private Level _levelPrefab;
    private void Awake()
    {
        _onLevelBtnClicked.Event.AddListener(OnLevelBtnClicked);
        CreateLevelButtons();
    }
    private void OnDisable()
    {
        _onLevelBtnClicked.Event.RemoveListener(OnLevelBtnClicked);
    }
    private void OnLevelBtnClicked(LevelData levelData) 
    {
        this.gameObject.SetActive(false);
    }
    private void CreateLevelButtons()
    {
        for (int i = 0; i < _levelData.Length; i++)
        {
             Level levelBtn = Instantiate(_levelPrefab, this.transform.position, Quaternion.identity, this.transform);
            levelBtn.SetLevelData(_levelData[i]);
        }
    }
}
