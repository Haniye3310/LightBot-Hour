using UnityEngine;
using static UnityEditor.PlayerSettings;

public class NextLevelButoon : MonoBehaviour
{
    [SerializeField] SOChannel _OnPlayCompleted;
    private void Awake()
    {
        _OnPlayCompleted.Event.AddListener(OnPlayCompleted);
        this.gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        _OnPlayCompleted.Event.RemoveListener(OnPlayCompleted);
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
        
    }
}
