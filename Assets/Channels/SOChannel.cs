using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SOChannelEvent[Name]", menuName = "SO/Channel/Event")]

public class SOChannel : ScriptableObject
{
    public UnityEvent Event;

}
