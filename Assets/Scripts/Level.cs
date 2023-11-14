using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    [SerializeField] private Button _levelBtn;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private IntVariable _currentLevelNumber;
    private int _level;
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
        _currentLevelNumber.Value = _level;
        SceneManager.LoadScene(1);
    }
    public void SetLevelData(int levelIndex) 
    {
        _level = levelIndex +1;
        _text.text = (levelIndex +1 ).ToString();
    }
}


