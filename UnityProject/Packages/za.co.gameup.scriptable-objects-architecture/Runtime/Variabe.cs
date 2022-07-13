namespace ScriptableObjects.Variables
{
    using System;
    using UnityEngine;

    public abstract class Variable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        public T InitialValue;

        [NonSerialized]
        public T CurrentValue;

        public void OnAfterDeserialize()
        {
            CurrentValue = InitialValue;
        }

        public void OnBeforeSerialize()
        {
        }
    }
}