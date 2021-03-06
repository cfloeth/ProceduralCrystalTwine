using UnityEngine;

namespace DefaultNamespace.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Rotated(this Vector3 vector, Quaternion rotation, Vector3 pivot = default)
        {
            return rotation * (vector - pivot) + pivot;
        }

        public static Vector3 Rotated(this Vector3 vector, Vector3 rotation, Vector3 pivot = default)
        {
            return Rotated(vector, Quaternion.Euler(rotation), pivot);
        }

        public static Vector3 Rotated(this Vector3 vector, float x, float y, float z, Vector3 pivot = default)
        {
            return Rotated(vector, Quaternion.Euler(x, y, z), pivot);
        }
    }
}