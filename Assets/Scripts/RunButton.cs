using UnityEngine;
using UnityEngine.UI;

public class RunButton : MonoBehaviour
{
    [SerializeField] private Button _runBtn;
    [SerializeField] private SOChannel _onRunButtonClicked;
    private void Awake()
    {
        _runBtn.onClick.AddListener(OnRunButtonClicked);
    }
    private void OnDisable()
    {
        _runBtn.onClick.RemoveListener(OnRunButtonClicked);
    }
    private void OnRunButtonClicked() 
    {
        _onRunButtonClicked.Event?.Invoke();
    }
}
