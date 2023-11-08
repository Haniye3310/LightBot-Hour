using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
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
        this.gameObject.SetActive(false);
    }
}
