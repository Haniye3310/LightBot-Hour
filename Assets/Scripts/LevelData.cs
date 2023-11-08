using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData[Name]", menuName = "SO/LevelData")]
public class LevelData : ScriptableObject
{
    public List<Serializable2DList<int>> EnvironmentList;
    public Vector2Int StartingPlayerPosition;
    public PlayerRotation StartingPlayerRotation;
    public MechanicEnum[] AvailableMechanics;
}
public enum PlayerRotation
{
    Left = 180, Right = 0, Forward = 270, Backward = 90
}
public enum MechanicEnum
{
    Move, Jump, RotateLeft, RotateRight, Light
}