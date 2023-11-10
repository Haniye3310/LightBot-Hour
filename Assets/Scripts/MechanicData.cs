using UnityEngine;

public abstract class MechanicData:ScriptableObject
{
    public Sprite MechanicSprite;
    public abstract void Move();
}
[CreateAssetMenu(fileName = "JumpMechanicData[Name]", menuName = "SO/JumpMechanicData")]
public class JumpMechanicData : MechanicData
{
    public override void Move() 
    {
        
    }
}
[CreateAssetMenu(fileName = "RotateRightMechanicData[Name]", menuName = "SO/RotateRightMechanicData")]
public class RotateRightMechanicData : MechanicData
{
    public override void Move()
    {

    }
}
[CreateAssetMenu(fileName = "RotateLeftMechanicData[Name]", menuName = "SO/RotateLeftMechanicData")]
public class RotateLeftMechanicData : MechanicData
{
    public override void Move()
    {

    }
}
[CreateAssetMenu(fileName = "LightMechanicData[Name]", menuName = "SO/LightMechanicData")]
public class LightMechanicData : MechanicData
{
    public override void Move()
    {

    }
}
[CreateAssetMenu(fileName = "MoveForwardMechanicData[Name]", menuName = "SO/MoveForwardMechanicData")]
public class MoveForwardMechanicData : MechanicData
{
    public override void Move()
    {

    }
}