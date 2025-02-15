﻿using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class ShapeDecorator : IShape
	{
		protected IShape _shape;

		public Transform Transform { get { return _shape.Transform; } }

		public ShapeDecorator(IShape shape)
		{
			_shape = shape;
		}

		public virtual void DrawMe() { }
	}
}