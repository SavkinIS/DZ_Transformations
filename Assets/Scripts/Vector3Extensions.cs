using UnityEngine;

public static class Vector3Extensions
{
    public static bool IsHigherThan(this Vector3 current, Vector3 target)
    {
        return (current.x >  target.x
                && current.y >  target.y
                && current.z >  target.z);
    }
    
    public static bool IsLowerThan(this Vector3 current, Vector3 target)
    {
        return (current.x <  target.x
                && current.y <  target.y
                && current.z <  target.z);
    }
}