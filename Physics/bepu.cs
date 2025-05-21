using BepuUtilities;
using BepuPhysics;
using OpenTK.Mathematics;

public static class Vector3Extensions
{
    public static Vector3 ToBepu(this OpenTK.Mathematics.Vector3 v)
        => new Vector3(v.X, v.Y, v.Z);

    public static OpenTK.Mathematics.Vector3 ToOpenTK(this Vector3 v)
        => new OpenTK.Mathematics.Vector3(v.X, v.Y, v.Z);
}



public class PhysicsWorld
{
    private Space space;

    public PhysicsWorld()
    {
        space = new Space();
    }

    public void Update(float deltaTime)
    {
        space.Update(deltaTime);
    }
}


