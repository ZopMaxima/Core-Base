// MeshUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using UnityEngine;

/// <summary>
/// Extend the mesh class.
/// </summary>
public static class MeshUtil
{
	/// <summary>
	/// Returns the surface area of a mesh.
	/// </summary>
	public static float CalculateSurfaceArea(this Mesh mesh)
	{
		// Cannot be null.
		if (mesh == null)
		{
			return 0;
		}

		// Count
		int[] triangles = mesh.triangles;
		Vector3[] vertices = mesh.vertices;
		double sum = 0.0;
		int end = triangles.Length;
		for (int i = 0; i < end; i += 3)
		{
			Vector3 corner = vertices[triangles[i]];
			Vector3 a = vertices[triangles[i + 1]] - corner;
			Vector3 b = vertices[triangles[i + 2]] - corner;
			sum += Vector3.Cross(a, b).magnitude;
		}

		// Return
		return (float)(sum / 2.0);
	}

	/// <summary>
	/// Returns the surface area of a mesh.
	/// </summary>
	public static float CalculateSurfaceArea(this Mesh mesh, Vector3 scale)
	{
		// Cannot be null.
		if (mesh == null)
		{
			return 0;
		}

		// Count
		int[] triangles = mesh.triangles;
		Vector3[] vertices = mesh.vertices;
		double sum = 0.0;
		int end = triangles.Length;
		for (int i = 0; i < end; i += 3)
		{
			Vector3 c = Vector3.Scale(scale, vertices[triangles[i]]);
			Vector3 a = Vector3.Scale(scale, vertices[triangles[i + 1]]) - c;
			Vector3 b = Vector3.Scale(scale, vertices[triangles[i + 2]]) - c;
			sum += Vector3.Cross(a, b).magnitude;
		}

		// Return
		return (float)(sum / 2.0);
	}

	/// <summary>
	/// Returns the surface area of a mesh, visible from a veiwing angle.
	/// </summary>
	public static float CalculateSurfaceAreaFromView(this Mesh mesh, Vector3 direction)
	{
		// Cannot be null.
		if (mesh == null)
		{
			return 0;
		}

		// Count
		direction = direction.normalized;
		int[] triangles = mesh.triangles;
		Vector3[] vertices = mesh.vertices;
		double sum = 0.0;
		int end = triangles.Length;
		for (int i = 0; i < end; i += 3)
		{
			Vector3 corner = vertices[triangles[i]];
			Vector3 a = vertices[triangles[i + 1]] - corner;
			Vector3 b = vertices[triangles[i + 2]] - corner;
			float projection = Vector3.Dot(Vector3.Cross(b, a), direction);
			if (projection > 0f)
			{
				sum += projection;
			}
		}

		// Return
		return (float)(sum / 2.0);
	}

	/// <summary>
	/// Returns the surface area of a mesh, visible from a veiwing angle.
	/// </summary>
	public static float CalculateSurfaceAreaFromView(this MeshCollider collider, Vector3 direction)
	{
		return (collider == null) ? (0) : (CalculateSurfaceAreaFromView(collider.sharedMesh, direction, collider.transform.lossyScale));
	}

	/// <summary>
	/// Returns the surface area of a mesh, visible from a veiwing angle.
	/// </summary>
	public static float CalculateSurfaceAreaFromView(this Mesh mesh, Vector3 direction, Vector3 scale)
	{
		// Cannot be null.
		if (mesh == null)
		{
			return 0;
		}

		// Count
		direction = direction.normalized;
		int[] triangles = mesh.triangles;
		Vector3[] vertices = mesh.vertices;
		double sum = 0.0;
		int end = triangles.Length;
		for (int i = 0; i < end; i += 3)
		{
			Vector3 c = Vector3.Scale(scale, vertices[triangles[i]]);
			Vector3 a = Vector3.Scale(scale, vertices[triangles[i + 1]]) - c;
			Vector3 b = Vector3.Scale(scale, vertices[triangles[i + 2]]) - c;
			float projection = Vector3.Dot(Vector3.Cross(b, a), direction);
			if (projection > 0f)
			{
				sum += projection;
			}
		}

		// Return
		return (float)(sum / 2.0);
	}
}