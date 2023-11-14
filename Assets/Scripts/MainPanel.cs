using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : InstructionPanel
{
    [SerializeField] private SOChannel _onProcessPanelClicked;
    [SerializeField] private SOChannel _onMainPanelClicked;
    protected override void Awake()
    {
        base.Awake();
        _onProcessPanelClicked.Event.AddListener(OnProcessPanelClicked);

    }
    protected override void OnDisable() 
    {
        base.OnDisable();
        _onProcessPanelClicked.Event.RemoveListener(OnProcessPanelClicked);
    }
    protected override void OnPanelClicked()
    {
        base.OnPanelClicked();
        SetActive(true);
        _onMainPanelClicked.Event?.Invoke();
    }
    private void OnProcessPanelClicked() 
    {
        SetActive(false);
    }
}
