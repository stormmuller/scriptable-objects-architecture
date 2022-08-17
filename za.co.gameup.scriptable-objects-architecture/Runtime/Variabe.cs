namespace ScriptableObjects.Variables
{
    using System;
    using UnityEngine;

    public abstract class Variable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        public T InitialValue;

        [NonSerialized]
        public T CurrentValue;

        public static implicit operator T(Variable<T> variable) => variable.CurrentValue;

        public void OnAfterDeserialize()
        {
            CurrentValue = InitialValue;
        }

        public void OnBeforeSerialize()
        {
        }

        public override string ToString()
        {
            return CurrentValue.ToString();
        }
    }
}