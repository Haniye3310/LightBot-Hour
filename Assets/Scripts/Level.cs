using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    private LevelData _levelData;
    [SerializeField] private Button _levelBtn;
    [SerializeField] private SOChannelLevelData _onLevelBtnClicked;
    [SerializeField] private TextMeshProUGUI _text;
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
    public void SetLevelData(LevelData levelData) 
    {
        _levelData = levelData;
        _text.text = levelData.LevelNumber.ToString();
    }
}


