﻿using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// Allows to be referenced via "Instance"
	/// and dynamically created on demand.
	/// 
	/// NOTE: This is a VERY light implementation.
	/// 
	/// </summary>
	public class MySingleton : SingletonMonobehavior<MySingleton>
	{
		//  Parent Methods ------------------------------------------
		public override void InstantiateCompleted()
		{
			Debug.Log("InstantiateCompleted()");
		}

		//  Other Methods ------------------------------------------
		public void SayHelloWorld()
		{
			Debug.Log("Hello World!");
		}
	}
}

