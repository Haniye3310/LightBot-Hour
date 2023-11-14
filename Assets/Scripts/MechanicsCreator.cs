using UnityEngine;
using UnityEngine.UI;

public class MechanicsCreator : MonoBehaviour
{
    [SerializeField] private MechanicBase _mechanicPrefab;
    [SerializeField] private LevelDataList _levels;
    [SerializeField] private IntVariable _currentLevelNumber;
    private void Awake()
    {
        Init();
    }

    private void Init() 
    {
        LevelData levelData = _levels.List[_currentLevelNumber.Value - 1];
        for (int i = 0; i < levelData.AvailableMechanics.Length; i++) 
        {
            MechanicBase.Instantiate(_mechanicPrefab,
                                 this.transform.position,
                                 Quaternion.identity,
                                 this.transform,
                                 levelData.AvailableMechanics[i]);
        }
    }
}
