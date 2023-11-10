using UnityEngine;
using UnityEngine.UI;

public class Mechanic : MonoBehaviour
{
    private MechanicData _mechanicData;
    [SerializeField] private Image _image;
    [SerializeField] Button _btn;

    public static Mechanic Instantiate(GameObject prefab, bool inMainPanel)
    {
        Instantiate(prefab, this.transform.position, Quaternion.identity, this.transform);
    }

    private void Awake()
    {
        _btn.onClick.AddListener(OnMechanicClicked);
    }
    private void OnDisable()
    {
        _btn.onClick.RemoveListener(OnMechanicClicked);
    }
    private void OnMechanicClicked()
    {

    }
    public void SetMechanicData(MechanicData mechanicData) 
    {
        _mechanicData = mechanicData;
        SetSprite();
    }
    private void SetSprite() 
    {
        _image.sprite = _mechanicData.MechanicSprite;
    }
}
