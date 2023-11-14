using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private LevelDataList _levels;
    [SerializeField] private Level _levelPrefab;
    private void Awake()
    {
        CreateLevelButtons();
    }
    private void CreateLevelButtons()
    {
        for (int i = 0; i < _levels.List.Count; i++)
        {
             Level levelBtn = Instantiate(_levelPrefab, this.transform.position, Quaternion.identity, this.transform);
            levelBtn.SetLevelData(i);
        }
    }
}
