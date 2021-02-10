using System;
using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Singleton
	{
		public static Singleton Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Singleton();
				}
				return _instance;
			}
		}

		private static Singleton _instance;

		private Singleton ()
		{
			Debug.Log("Singleton.Constructor()");
			_instance = this;
		}

		public void SayHelloWorld()
		{
			Debug.Log("Hello World!");
		}
	}
}