using UnityEngine;
using UnityEngine.UI;

public class Mechanic : MonoBehaviour
{
    private MechanicData _mechanicData;
    [SerializeField] private Image _image;
    [SerializeField] Button _btn;
    private bool _inMainPanel;
    [SerializeField] private SOChannelMechanicData _onMechanicInOptionsClicked;
    [SerializeField] private SOChannelMechanicData _onMechanicInMainPanelClicked;
    public static Mechanic Instantiate(Mechanic prefab,Vector3 position,Quaternion rotation,Transform parent,MechanicData mechanicData ,bool inMainPanel)
    {
        var mechanic = Instantiate(prefab, position , rotation, parent);
        mechanic._inMainPanel = inMainPanel;
        mechanic._mechanicData = mechanicData;
        mechanic.SetSprite();
        return mechanic;
    }

    private void Start()
    {
        if (_inMainPanel) 
        {
            _btn.onClick.AddListener(OnMechanicInMainPanelClicked);
        }
        else 
        {
            _btn.onClick.AddListener(OnMechanicInOptionsClicked);
        }
    }
    private void OnDisable()
    {
        if (_inMainPanel)
        {
            _btn.onClick.RemoveListener(OnMechanicInMainPanelClicked);

        }
        else
        {
            _btn.onClick.RemoveListener(OnMechanicInOptionsClicked);
        }
    }
    private void OnMechanicInMainPanelClicked()
    {
        _onMechanicInMainPanelClicked.Event?.Invoke(_mechanicData);
        Destroy(this.gameObject);
    }
    private void OnMechanicInOptionsClicked()
    {
        _onMechanicInOptionsClicked.Event?.Invoke(_mechanicData);
    }
    private void SetSprite() 
    {
        _image.sprite = _mechanicData.MechanicSprite;
    }
}
