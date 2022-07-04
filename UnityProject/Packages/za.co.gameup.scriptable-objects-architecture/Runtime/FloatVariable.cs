namespace ScriptableObjects.Variables
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : ScriptableObject
    {
        public float Value;

        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetValue(FloatVariable value)
        {
            Value = value.Value;
        }
    }
}