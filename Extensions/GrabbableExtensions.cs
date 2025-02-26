using BNG;
using UnityEngine;

namespace OghiVrTools.Extensions
{
    public static class GrabbableExtensions
    {
        public static void LockGrabbable(this Grabbable grabbable)
        {
            grabbable.enabled = false;
            grabbable.GetComponent<Collider>().enabled = false;
        }

        public static void UnlockGrabbable(this Grabbable grabbable)
        {
            grabbable.enabled = true;
            grabbable.GetComponent<Collider>().enabled = true;
        }
    }
}