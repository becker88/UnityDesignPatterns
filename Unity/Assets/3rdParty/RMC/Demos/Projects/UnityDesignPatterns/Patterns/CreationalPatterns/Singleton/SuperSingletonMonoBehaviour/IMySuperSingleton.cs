namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// This is optional, but helpful to enforce
	/// </summary>
	public interface IMySuperSingleton 
	{
		//  Other Methods ------------------------------------------
		public void SayHelloWorld();
		public SubSystemA SubSystemA { get; }
		public SubSystemB SubSystemB { get; }
	}
}

