using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    [SerializeField] private Button _levelBtn;
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;

    private void Awake()
    {
        _levelBtn.onClick.AddListener(Level_OnClick);
    }
    private void OnDisable()
    {
        _levelBtn.onClick.RemoveListener(Level_OnClick);
    }
    private void Level_OnClick()
    {
        _onLevelBtnClicked.Event?.Invoke(_levelData);
    }
}


