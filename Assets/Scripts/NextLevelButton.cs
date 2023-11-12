using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] IntVariable _currentLevel;
    [SerializeField] SOChannel _OnPlayCompleted;
    [SerializeField] Button _btn;
    private void Awake()
    {
        _OnPlayCompleted.Event.AddListener(OnPlayCompleted);
        _btn.onClick.AddListener(OnNextLevelButtonClicked);
        this.gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        _OnPlayCompleted.Event.RemoveListener(OnPlayCompleted);
        _btn.onClick.RemoveListener(OnNextLevelButtonClicked);
    }
    private void OnPlayCompleted() 
    {
        Cube[] cubes = FindObjectsOfType<Cube>();

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].IsBlue()) return;
                
        }
        this.gameObject.SetActive(true);
    }
    private void OnNextLevelButtonClicked() 
    {
        _currentLevel.Value++;
        SceneManager.LoadScene(1);
    }
}
