using UnityEngine;

namespace Math.SigmentSystem
{
    public class SigmentChangedArgs
    {
        public SigmentChangedArgs(Vector3 startOldValue, Vector3 endOldValue)
        {
            StartOldValue = startOldValue;
            EndOldValue = endOldValue;
        }

        public Vector3 StartOldValue { get; }
        public Vector3 EndOldValue { get; }


    }
}