using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SOChanneVector3[Name]", menuName = "SO/Channel/Vector3")]
public class SOChanneVector3 : ScriptableObject
{
    public UnityEvent<Vector3> Event;
}
