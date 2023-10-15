// LayerMaskUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   June 27, 2021

using UnityEngine;

/// <summary>
/// Extend the layer mask class.
/// </summary>
public static class LayerMaskUtil
{
	public static int DefaultCollision;
	public static int WaterCollision;

	private static readonly LayerMask[] _masks;

	/// <summary>
	/// Initialize.
	/// </summary>
	static LayerMaskUtil()
	{
		DefaultCollision = GetCollisionMask("Default");
		WaterCollision = GetCollisionMask("Water");
		_masks = new LayerMask[32];
		for (int i = 0; i < _masks.Length; i++)
		{
			_masks[i] = 1 << i;
		}
	}

	/// <summary>
	/// Combine all collision bits for this layer.
	/// </summary>
	public static LayerMask GetCollisionMask(string layerName)
	{
		int index = LayerMask.NameToLayer(layerName);
		int result = 0;

		// Add each collision.
		for (int i = 0; i < 32; i++)
		{
			bool has2D = !Physics2D.GetIgnoreLayerCollision(index, i);
			bool has3D = !Physics.GetIgnoreLayerCollision(index, i);
			if (has2D || has3D)
			{
				result |= 1 << i;
				if (has2D != has3D)
				{
					Debug.LogErrorFormat("Physics 2D and 3D don't match collision masks: {0}, \"{1}\"", index, layerName);
				}
			}
		}

		// Return
		return result;
	}

	/// <summary>
	/// Returns a layer mask for this object.
	/// </summary>
	public static LayerMask GetLayerMask(this GameObject gameObject)
	{
		return (gameObject != null) ? (_masks[gameObject.layer]) : (default);
	}

	/// <summary>
	/// Returns a layer mask for this object.
	/// </summary>
	public static LayerMask GetLayerMask(this Component component)
	{
		return (component != null) ? (_masks[component.gameObject.layer]) : (default);
	}

	/// <summary>
	/// Returns true if the layer mask matches for this object.
	/// </summary>
	public static bool IsInLayerMask(this GameObject go, LayerMask mask)
	{
		return (GetLayerMask(go) & mask) != 0;
	}

	/// <summary>
	/// Returns true if the layer mask matches for this object.
	/// </summary>
	public static bool IsInLayerMask(this Component c, LayerMask mask)
	{
		return (GetLayerMask(c) & mask) != 0;
	}
}