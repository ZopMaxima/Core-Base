// ColliderUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   November 5, 2022

using System;
using UnityEngine;

/// <summary>
/// Extend the collider class.
/// </summary>
public static class ColliderUtil
{
	private static readonly double SQRT_2 = Math.Sqrt(2);

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this Collider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider)
		{
			return GetSurface(collider as BoxCollider);
		}
		if (collider is SphereCollider)
		{
			return GetSurface(collider as SphereCollider);
		}
		if (collider is CapsuleCollider)
		{
			return GetSurface(collider as CapsuleCollider);
		}
		if (collider is MeshCollider)
		{
			return GetSurface(collider as MeshCollider);
		}
		if (collider is TerrainCollider)
		{
			return GetSurface(collider as TerrainCollider);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this Collider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider)
		{
			return 0; // TODO	return GetVolume(collider as BoxCollider);
		}
		if (collider is SphereCollider)
		{
			return 0; // TODO	return GetVolume(collider as SphereCollider);
		}
		if (collider is CapsuleCollider)
		{
			return 0; // TODO	return GetVolume(collider as CapsuleCollider);
		}
		if (collider is MeshCollider)
		{
			return 0; // TODO	return GetVolume(collider as MeshCollider);
		}
		if (collider is TerrainCollider)
		{
			return 0; // TODO	return GetVolume(collider as TerrainCollider);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this BoxCollider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		float x = collider.size.x * scale.x;
		float y = collider.size.y * scale.y;
		float z = collider.size.z * scale.z;
		return 2 * ((x * y) + (x * z) + (y * z));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this SphereCollider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Sphere.Surface(collider.radius * Mathf.Max(scale.x, scale.y, scale.z));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CapsuleCollider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		switch (collider.direction)
		{
			default:
			case 3:
			{
				float rs = Mathf.Max(scale.x, scale.y);
				float r = collider.radius * rs;
				float e = Mathf.Max(0, (collider.height * scale.z) - r - r);
				return Capsule.Surface(r, e);
			}
			case 2:
			{
				float rs = Mathf.Max(scale.x, scale.z);
				float r = collider.radius * rs;
				float e = Mathf.Max(0, (collider.height * scale.y) - r - r);
				return Capsule.Surface(r, e);
			}
			case 1:
			{
				float rs = Mathf.Max(scale.y, scale.z);
				float r = collider.radius * rs;
				float e = Mathf.Max(0, (collider.height * scale.x) - r - r);
				return Capsule.Surface(r, e);
			}
		}
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this MeshCollider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return MeshUtil.CalculateSurfaceArea(collider.sharedMesh, scale);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this TerrainCollider collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Count cells.
		double area = 0;
		TerrainData data = collider.terrainData;
		int end = data.heightmapResolution;
		for (int x = 0; x < end; x++) // TODO: Each point is calculated ~6 times...
		{
			for (int z = 0; z < end; z++)
			{
				float bl = data.GetHeight(x, z);
				float br = data.GetHeight(x + 1, z);
				float tl = data.GetHeight(x, z + 1);
				float tr = data.GetHeight(x + 1, z + 1);
				if ((x + z) % 2 == 0)
				{
					area += GetHeightmapSurface(bl, tr, tl);
					area += GetHeightmapSurface(bl, tr, br);
				}
				else
				{
					area += GetHeightmapSurface(tl, br, bl);
					area += GetHeightmapSurface(tl, br, tr);
				}
			}
		}

		// Return
		return (float)area;
	}

	/// <summary>
	/// Returns the surface area of a heightmap triangle.
	/// </summary>
	private static double GetHeightmapSurface(float a, float b, float corner)
	{
		float acUp = Math.Max(a - corner, corner - a);
		float bcUp = Math.Max(b - corner, corner - b);
		float abUp = Math.Max(a - b, b - a);
		double acHy = acUp == 0 ? 1 : Math.Sqrt((acUp * acUp) + 1);
		double bcHy = bcUp == 0 ? 1 : Math.Sqrt((bcUp * bcUp) + 1);
		double abHy = abUp == 0 ? SQRT_2 : Math.Sqrt((abUp * abUp) + SQRT_2);
		return Triangle.AreaScalene(acHy, bcHy, abHy);
	}
}