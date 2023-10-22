// VectorUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   March 21, 2021

using UnityEngine;

/// <summary>
/// Extend the vector class.
/// </summary>
public static class VectorUtil
{
	/// <summary>
	/// Returns the squared distance between these points.
	/// </summary>
	public static float DistanceSqr(this Vector2 self, Vector2 other)
	{
		return (other - self).sqrMagnitude;
	}

	/// <summary>
	/// Returns the squared distance between these points.
	/// </summary>
	public static float DistanceSqr(this Vector3 self, Vector3 other)
	{
		return (other - self).sqrMagnitude;
	}

	/// <summary>
	/// Returns the squared distance between these points.
	/// </summary>
	public static float DistanceSqr(this Vector4 self, Vector4 other)
	{
		return (other - self).sqrMagnitude;
	}

	/// <summary>
	/// Returns the first intersection point with this circle.
	/// https://stackoverflow.com/questions/23016676/line-segment-and-circle-intersection
	/// </summary>
	public static bool IntersectCircle(this Vector2 center, float radius, Vector2 lineStart, Vector2 lineEnd, out Vector2 intersection)
	{
		float A, B, C, det, t;
		float dx = lineEnd.x - lineStart.x;
		float dy = lineEnd.y - lineStart.y;

		// Wizard math given to use by the internet.
		A = dx * dx + dy * dy;
		B = 2 * (dx * (lineStart.x - center.x) + dy * (lineStart.y - center.y));
		C = (lineStart.x - center.x) * (lineStart.x - center.x) + (lineStart.y - center.y) * (lineStart.y - center.y) - radius * radius;
		det = B * B - 4 * A * C;

		// Return the first intersection.
		if ((A <= 0.0000001) || (det < 0))
		{
			intersection = new Vector2();
			return false;
		}
		else if (det == 0)
		{
			t = -B / (2 * A);
			intersection = new Vector2(lineStart.x + t * dx, lineStart.y + t * dy);
			return true;
		}
		else
		{
			t = (float)((-B + Mathf.Sqrt(det)) / (2 * A));
			intersection = new Vector2(lineStart.x + t * dx, lineStart.y + t * dy);
			return true;
		}
	}

	/// <summary>
	/// Returns the first intersection point with this circle.
	/// https://stackoverflow.com/questions/23016676/line-segment-and-circle-intersection
	/// </summary>
	public static bool IntersectCircle(this Vector3 center, float radius, Vector3 lineStart, Vector3 lineEnd, out Vector3 intersection)
	{
		float A, B, C, det, t;
		float dx = lineEnd.x - lineStart.x;
		float dy = lineEnd.y - lineStart.y;

		// Wizard math given to use by the internet.
		A = dx * dx + dy * dy;
		B = 2 * (dx * (lineStart.x - center.x) + dy * (lineStart.y - center.y));
		C = (lineStart.x - center.x) * (lineStart.x - center.x) + (lineStart.y - center.y) * (lineStart.y - center.y) - radius * radius;
		det = B * B - 4 * A * C;

		// Return the first intersection.
		if ((A <= 0.0000001) || (det < 0))
		{
			intersection = new Vector3();
			return false;
		}
		else if (det == 0)
		{
			t = -B / (2 * A);
			intersection = new Vector3(lineStart.x + t * dx, lineStart.y + t * dy);
			return true;
		}
		else
		{
			t = (float)((-B + Mathf.Sqrt(det)) / (2 * A));
			intersection = new Vector3(lineStart.x + t * dx, lineStart.y + t * dy);
			return true;
		}
	}
}