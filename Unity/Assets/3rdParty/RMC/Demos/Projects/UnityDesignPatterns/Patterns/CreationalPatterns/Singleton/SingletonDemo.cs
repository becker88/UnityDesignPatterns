using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonDemo : MonoBehaviour
	{
		protected void Start()
		{
			// Singleton MonoBehaviour
			// -- Call multiple times. Note: It only gets created 1 time
			MySingleton.Instance.SayHelloWorld();
			MySingleton.Instance.SayHelloWorld();
			MySingleton.Instance.SayHelloWorld();
			
			// Singleton ScriptableObject
			// -- Writes to local path
			MyScriptableSingleton.instance.Log();
			MyScriptableSingleton.instance.IncrementSomeCounter();
			MyScriptableSingleton.instance.Log();
		}
	}
}