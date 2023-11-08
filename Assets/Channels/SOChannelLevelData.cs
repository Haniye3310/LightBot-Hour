using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SOChannelLevelData[Name]", menuName = "SO/Channel/LevelDataEvent")]
public class SOChannelLevelData : ScriptableObject
{
    public UnityEvent<LevelData> Event;
}
