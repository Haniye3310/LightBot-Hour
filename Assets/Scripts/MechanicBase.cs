using UnityEngine;
using UnityEngine.UI;

public abstract class MechanicBase : MonoBehaviour
{
    protected MechanicData _mechanicData;
    [SerializeField] private Image _image;
    [SerializeField] Button _btn;
    public static MechanicBase Instantiate(MechanicBase prefab,Vector3 position,Quaternion rotation,Transform parent,MechanicData mechanicData)
    {
        var mechanic = Instantiate(prefab, position , rotation, parent);
        mechanic._mechanicData = mechanicData;
        mechanic.SetSprite();
        return mechanic;
    }

    protected virtual void OnEnable()
    {
            _btn.onClick.AddListener(OnMechanicClicked);
    }
    protected virtual void OnDisable()
    {
            _btn.onClick.RemoveListener(OnMechanicClicked);
    }
    protected abstract void OnMechanicClicked();


    private void SetSprite() 
    {
        _image.sprite = _mechanicData.MechanicSprite;
    }
}
