using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelDataList[Name]", menuName = "SO/LevelDataList")]
public class LevelDataList : ScriptableObject
{
    public List<LevelData> List;
}
