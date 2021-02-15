using NUnit.Framework;
using UnityEngine;

namespace RMC.Calculator_02Complete
{
    /// <summary>
    /// The Unity Test Runner tests your code in Edit mode and Play mode,
    /// as well as on target platforms such as Standalone, Android, or iOS.
    /// See https://docs.unity3d.com/Manual/PlaymodeTestFramework.html
    ///
    /// NOTE: This is an example of an PLAY MODE TEST.
    ///
    /// You can run Play Mode tests as a standalone in a Player or inside the
    /// Editor. Play Mode tests allow you to exercise your game code, as the
    /// tests run as coroutines if marked with the UnityTest attribute.
    /// 
    /// </summary>
    public class CalculatorDemoPlayModeTest
    {
        [Test]
        public void Add_10Plus5_Equals15()
        {
            // Arrange
            GameObject gameObject = new GameObject();
            CalculatorDemo calculatorDemo = gameObject.AddComponent<CalculatorDemo>();

            // Act
            float result = calculatorDemo.Calculator.Add(10, 5);

            // Asset
            Assert.That(result, Is.EqualTo(15));
        }
        
        [Test]
        public void Subtract_9Minus4_Equals5()
        {
            // Arrange
            GameObject gameObject = new GameObject();
            CalculatorDemo calculatorDemo = gameObject.AddComponent<CalculatorDemo>();

            // Act
            float result = calculatorDemo.Calculator.Subtract(9, 4);

            // Asset
            Assert.That(result, Is.EqualTo(5));
        }

        /*
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CalculatorTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
        */
    }
}