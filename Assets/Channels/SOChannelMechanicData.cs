using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SOChannelMechanicData[Name]", menuName = "SO/Channel/MechanicData")]
public class SOChannelMechanicData : ScriptableObject
{
    public UnityEvent<MechanicData> Event;
}
