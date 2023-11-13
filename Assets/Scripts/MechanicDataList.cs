using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "MechanicDataList[Name]", menuName = "SO/MechanicDataList")]
public class MechanicDataList : ScriptableObject
{
    public List<MechanicData> List;
    private void OnEnable()
    {
        SceneManager.activeSceneChanged += ResetSO;
    }
    private void ResetSO(Scene A, Scene B)
    {
        List .Clear();
    }
}
