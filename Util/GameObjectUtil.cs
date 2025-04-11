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

	/// <summary>
	/// Instantiate an inactive instance.
	/// </summary>
	public static GameObject InstantiateInactive(GameObject prefab)
	{
		return InstantiateInactive(prefab, null);
	}

	/// <summary>
	/// Instantiate an inactive instance.
	/// </summary>
	public static GameObject InstantiateInactive(GameObject prefab, Transform parent)
	{
		return InstantiateInactive(prefab, prefab.transform.position, prefab.transform.rotation, parent);
	}

	/// <summary>
	/// Instantiate an inactive instance.
	/// </summary>
	public static GameObject InstantiateInactive(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return InstantiateInactive(prefab, position, rotation, null);
	}

	/// <summary>
	/// Instantiate an inactive instance.
	/// </summary>
	public static GameObject InstantiateInactive(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent)
	{
		if (prefab == null)
		{
			return null;
		}

		// Deactivate while instantiating.
		bool wasActive = prefab.activeSelf;
		if (wasActive)
		{
			prefab.SetActive(false);
		}
		GameObject instance = GameObject.Instantiate(prefab, position, rotation, parent);
		if (wasActive)
		{
			prefab.SetActive(true);
		}

		// Return
		return instance;
	}

	/// <summary>
	/// Returns the nearest component of matching type.
	/// </summary>
	public static void FindComponentToRoot<T>(this Component instance, ref T component) where T : Component
	{
		if (instance != null)
		{
			FindComponentToRoot(instance.gameObject, ref component);
		}
	}

	/// <summary>
	/// Returns the nearest component of matching type.
	/// </summary>
	public static void FindComponentToRoot<T>(this GameObject instance, ref T component) where T : Component
	{
		if (component == null)
		{
			component = instance.GetComponent<T>();
			if (component == null)
			{
				component = instance.GetComponentInParent<T>();
				if (component == null)
				{
					component = instance.GetComponentInParent<T>(true);
				}
			}
		}
	}
}