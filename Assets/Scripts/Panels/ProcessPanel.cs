using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProcessPanel : InstructionPanel
{
    [SerializeField] private LevelDataList _levels;
    [SerializeField] private IntVariable _currentLevelNumber;
    [SerializeField] private SOChannel _onProcessPanelClicked;
    [SerializeField] private SOChannel _onMainPanelClicked;
    protected override void Awake()
    {
        base.Awake();
        this.gameObject.SetActive(_levels.List[_currentLevelNumber.Value -1].HasProcessPanel);
        _onMainPanelClicked.Event.AddListener(OnMainPanelClicked);
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
        _onMainPanelClicked.Event.RemoveListener(OnMainPanelClicked);
    }
    protected override void OnPanelClicked()
    {
        base.OnPanelClicked();
        SetActive(true);
        _onProcessPanelClicked.Event?.Invoke();

    }
    private void OnMainPanelClicked() 
    {
        SetActive(false);
    }

}
