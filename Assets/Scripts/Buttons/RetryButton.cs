using UnityEngine;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    [SerializeField] SOChannel _OnPlayCompleted;
    [SerializeField] SOChannel _OnRetryButtonClicked;
    [SerializeField] Button _btn;
    private void Awake()
    {
        _OnPlayCompleted.Event.AddListener(OnPlayCompleted);
        _btn.onClick.AddListener(OnRetryClicked);
        this.gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        _OnPlayCompleted.Event.RemoveListener(OnPlayCompleted);
        _btn.onClick.RemoveListener(OnRetryClicked);

    }
    private void OnPlayCompleted() 
    {
        this.gameObject.SetActive(true);
    }
    private void OnRetryClicked()
    {
        _OnRetryButtonClicked.Event?.Invoke();
        this.gameObject.SetActive(false);

    }
}
