// GameObjectUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   January 18, 2021

using UnityEngine;

/// <summary>
/// Extend the game object class.
/// </summary>
public static class GameObjectUtil
{
	/// <summary>
	/// Enable or disable a game object with safety checks.
	/// </summary>
	public static void TryActivate(this GameObject instance, bool activate)
	{
		if (instance != null && instance.activeSelf != activate)
		{
			instance.SetActive(activate);
		}
	}
}