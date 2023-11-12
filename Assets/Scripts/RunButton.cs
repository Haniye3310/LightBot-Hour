using UnityEngine;
using UnityEngine.UI;

public class RunButton : MonoBehaviour
{
    [SerializeField] SOChannel _OnPlayCompleted;
    [SerializeField] private Button _runBtn;
    [SerializeField] private SOChannel _onRunButtonClicked;
    [SerializeField] SOChannel _OnRetryButtonClicked;

    private void Awake()
    {
        _OnPlayCompleted.Event.AddListener(OnPlayCompleted);
        _runBtn.onClick.AddListener(OnRunButtonClicked);
        _OnRetryButtonClicked.Event.AddListener(OnRetryButtonClicked);
    }
    private void OnDestroy()
    {
        _OnPlayCompleted.Event.RemoveListener(OnPlayCompleted);
        _runBtn.onClick.RemoveListener(OnRunButtonClicked);
        _OnRetryButtonClicked.Event?.RemoveListener(OnRetryButtonClicked);
    }
    private void OnPlayCompleted()
    {
        this.gameObject.SetActive(false);
    }
    private void OnRunButtonClicked() 
    {
        _onRunButtonClicked.Event?.Invoke();
    }
    private void OnRetryButtonClicked() 
    {
        this.gameObject.SetActive(true);
    }
}
