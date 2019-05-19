namespace SunagimoGames
{
	/// <summary>
	/// Scenes拡張クラス（自動生成クラス）。
	/// </summary> 
	public static class ScenesHelper
	{
		/// <summary> 
		/// Scenesを文字列に変換するクラス。
		/// </summary> 
		public static string ScenesToString(this Scenes scenes)
		{
			switch(scenes)
			{
				case Scenes.SampleScene:
					return "SampleScene";
				case Scenes.Sample1:
					return "Sample1";
				case Scenes.Sample2:
					return "Sample2";
				default:
					return "";
			}
		}
	}
}