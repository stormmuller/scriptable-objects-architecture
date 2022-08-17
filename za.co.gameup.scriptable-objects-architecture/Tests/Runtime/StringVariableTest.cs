using NUnit.Framework;
using ScriptableObjects.Variables;
using UnityEngine;

public class StringVariableTest
{

    [Test]
    public void Sets_Current_Value_To_Initial_Value_On_Deserialize()
    {
        var stringVariable = ScriptableObject.CreateInstance<StringVariable>();
        stringVariable.InitialValue = "Hello world!";

        Assert.AreEqual(stringVariable.CurrentValue, null);

        stringVariable.OnAfterDeserialize();
        Assert.AreEqual(stringVariable.CurrentValue, "Hello world!");
    }

    [Test]
    public void Adding_Two_Strings()
    {
        var stringVariable1 = ScriptableObject.CreateInstance<StringVariable>();
        var stringVariable2 = ScriptableObject.CreateInstance<StringVariable>();

        stringVariable1.CurrentValue = "Hello ";
        stringVariable2.CurrentValue = "world!";

        Assert.AreEqual(stringVariable1 + stringVariable2, "Hello world!");
    }
}
