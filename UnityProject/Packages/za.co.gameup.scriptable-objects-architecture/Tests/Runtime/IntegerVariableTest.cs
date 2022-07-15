using NUnit.Framework;
using ScriptableObjects.Variables;
using UnityEngine;

public class IntegerVariableTest
{
    [Test]
    public void Sets_Current_Value_To_Initial_Value_On_Deserialize()
    {
        var integerVariable = ScriptableObject.CreateInstance<IntegerVariable>();
        integerVariable.InitialValue = 2;

        Assert.AreEqual(integerVariable.CurrentValue, 0);

        integerVariable.OnAfterDeserialize();
        Assert.AreEqual(integerVariable.CurrentValue, 2);
    }

    [Test]
    public void ToString_Returns_Integer_As_String()
    {
        var integerVariable = ScriptableObject.CreateInstance<IntegerVariable>();

        integerVariable.CurrentValue = 2;

        Assert.AreEqual(integerVariable.ToString(), "2");
    }

    [Test]
    [TestCase(2, 2, 4)]
    [TestCase(1, 2, 3)]
    [TestCase(12, 43, 55)]
    public void Adding_Two_Integers(int number1, int number2, int total)
    {
        var integerVariable1 = ScriptableObject.CreateInstance<IntegerVariable>();
        var integerVariable2 = ScriptableObject.CreateInstance<IntegerVariable>();

        integerVariable1.CurrentValue = number1;
        integerVariable2.CurrentValue = number2;

        Assert.AreEqual(integerVariable1 + integerVariable2, total);
    }
}
