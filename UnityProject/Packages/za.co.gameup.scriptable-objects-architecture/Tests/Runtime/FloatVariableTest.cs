using NUnit.Framework;
using ScriptableObjects.Variables;
using System;
using UnityEngine;

public class FloatVariableTest
{
    [Test]
    public void Sets_Current_Value_To_Initial_Value_On_Deserialize()
    {
        var floatVariable = ScriptableObject.CreateInstance<FloatVariable>();
        floatVariable.InitialValue = 3.14f;

        Assert.AreEqual(floatVariable.CurrentValue, 0f);

        floatVariable.OnAfterDeserialize();
        Assert.AreEqual(floatVariable.CurrentValue, 3.14f);
    }

    [Test]
    public void ToString_Returns_Float_As_String()
    {
        var floatVariable = ScriptableObject.CreateInstance<FloatVariable>();

        floatVariable.CurrentValue = 3.14f;

        Assert.AreEqual(floatVariable.ToString(), "3.14");
    }

    [Test]
    [TestCase(2.12f, 2.14f, 4.26f)]
    [TestCase(1.111f, 2.222f, 3.333f)]
    [TestCase(12f, 43f, 55f)]
    public void Adding_Two_Floats(float number1, float number2, float total)
    {
        var floatVariable1 = ScriptableObject.CreateInstance<FloatVariable>();
        var floatVariable2 = ScriptableObject.CreateInstance<FloatVariable>();

        floatVariable1.CurrentValue = number1;
        floatVariable2.CurrentValue = number2;

        Assert.IsTrue(FloatEquals(floatVariable1 + floatVariable2, total, 0.000001f));
    }

    bool FloatEquals(float x, float y, float tolerance)
    {
        var diff = Math.Abs(x - y);
        return diff <= tolerance ||
               diff <= Math.Max(Math.Abs(x), Math.Abs(y)) * tolerance;
    }
}
