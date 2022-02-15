using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        [UnityTest]
        public IEnumerator TestOnFloatToTest()
        {
            var gameObject = new GameObject();
            var scriptToTestWithTests = gameObject.AddComponent<ScriptToTestWithTests>();

            scriptToTestWithTests.SetFloatToTestValue(3.01f);

            yield return new WaitForSeconds(1);

            Assert.AreEqual(3.01f, ScriptToTestWithTests.floatToTest);
        }
    }
}