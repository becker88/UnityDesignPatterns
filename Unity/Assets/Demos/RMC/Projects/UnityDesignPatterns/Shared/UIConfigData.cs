using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Shared
{
	[CreateAssetMenu(fileName = "UIConfigData",
	menuName = Constants.CreateAssetMenuPath + "UIConfigData",
	order = Constants.CreateAssetMenuOrder)]

	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class UIConfigData : ConfigData
	{
		public string LeftText {  get { return _leftText; } }
		public string RightText { get { return _rightText; } }

		[SerializeField]
		private string _leftText = "";

		[SerializeField]
		private string _rightText = "";

	}
}