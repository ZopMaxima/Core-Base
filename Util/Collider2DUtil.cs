// Collider2DUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   November 7, 2022

using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// Extend the collider class.
/// </summary>
public static class Collider2DUtil
{
	public const float EDGE_WIDTH = 0.01f;

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this Collider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider2D)
		{
			return GetArea(collider as BoxCollider2D);
		}
		if (collider is CircleCollider2D)
		{
			return GetArea(collider as CircleCollider2D);
		}
		if (collider is CapsuleCollider2D)
		{
			return GetArea(collider as CapsuleCollider2D);
		}
		if (collider is PolygonCollider2D)
		{
			return GetArea(collider as PolygonCollider2D);
		}
		if (collider is EdgeCollider2D)
		{
			return GetArea(collider as EdgeCollider2D);
		}
		if (collider is TilemapCollider2D)
		{
			return GetArea(collider as TilemapCollider2D);
		}
		if (collider is CompositeCollider2D)
		{
			return GetArea(collider as CompositeCollider2D);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this Collider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider2D)
		{
			return GetSurface(collider as BoxCollider2D);
		}
		if (collider is CircleCollider2D)
		{
			return GetSurface(collider as CircleCollider2D);
		}
		if (collider is CapsuleCollider2D)
		{
			return GetSurface(collider as CapsuleCollider2D);
		}
		if (collider is PolygonCollider2D)
		{
			return GetSurface(collider as PolygonCollider2D);
		}
		if (collider is EdgeCollider2D)
		{
			return GetSurface(collider as EdgeCollider2D);
		}
		if (collider is TilemapCollider2D)
		{
			return GetSurface(collider as TilemapCollider2D);
		}
		if (collider is CompositeCollider2D)
		{
			return GetSurface(collider as CompositeCollider2D);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this Collider2D collider, float depth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider2D)
		{
			return GetSurface(collider as BoxCollider2D, depth);
		}
		if (collider is CircleCollider2D)
		{
			return GetSurface(collider as CircleCollider2D, depth);
		}
		if (collider is CapsuleCollider2D)
		{
			return GetSurface(collider as CapsuleCollider2D, depth);
		}
		if (collider is PolygonCollider2D)
		{
			return GetSurface(collider as PolygonCollider2D, depth);
		}
		if (collider is EdgeCollider2D)
		{
			return GetSurface(collider as EdgeCollider2D, depth);
		}
		if (collider is TilemapCollider2D)
		{
			return GetSurface(collider as TilemapCollider2D, depth);
		}
		if (collider is CompositeCollider2D)
		{
			return GetSurface(collider as CompositeCollider2D, depth);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this Collider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider2D)
		{
			return GetVolume(collider as BoxCollider2D);
		}
		if (collider is CircleCollider2D)
		{
			return GetVolume(collider as CircleCollider2D);
		}
		if (collider is CapsuleCollider2D)
		{
			return GetVolume(collider as CapsuleCollider2D);
		}
		if (collider is PolygonCollider2D)
		{
			return GetVolume(collider as PolygonCollider2D);
		}
		if (collider is EdgeCollider2D)
		{
			return GetVolume(collider as EdgeCollider2D);
		}
		if (collider is TilemapCollider2D)
		{
			return GetVolume(collider as TilemapCollider2D);
		}
		if (collider is CompositeCollider2D)
		{
			return GetVolume(collider as CompositeCollider2D);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this Collider2D collider, float depth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Cast away!
		if (collider is BoxCollider2D)
		{
			return GetVolume(collider as BoxCollider2D, depth);
		}
		if (collider is CircleCollider2D)
		{
			return GetVolume(collider as CircleCollider2D, depth);
		}
		if (collider is CapsuleCollider2D)
		{
			return GetVolume(collider as CapsuleCollider2D, depth);
		}
		if (collider is PolygonCollider2D)
		{
			return GetVolume(collider as PolygonCollider2D, depth);
		}
		if (collider is EdgeCollider2D)
		{
			return GetVolume(collider as EdgeCollider2D, depth);
		}
		if (collider is TilemapCollider2D)
		{
			return GetVolume(collider as TilemapCollider2D, depth);
		}
		if (collider is CompositeCollider2D)
		{
			return GetVolume(collider as CompositeCollider2D, depth);
		}

		// Failed
		return 0;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this BoxCollider2D collider)
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
		return x * y;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this BoxCollider2D collider, float prismDepth)
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
		float z = prismDepth * scale.z;
		return 2 * ((x * y) + (x * z) + (y * z));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this BoxCollider2D collider)
	{
		return (collider != null) ? (GetSurface(collider, Mathf.Min(collider.size.x, collider.size.y))) : (0);
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this BoxCollider2D collider, float prismDepth)
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
		float z = prismDepth * scale.z;
		return x * y * z;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this BoxCollider2D collider)
	{
		return (collider != null) ? (GetVolume(collider, Mathf.Min(collider.size.x, collider.size.y))) : (0);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this CircleCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Circle.Area(collider.radius * Mathf.Max(scale.x, scale.y));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CircleCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Circle.Area(collider.radius * Mathf.Max(scale.x, scale.y)) + (Circle.Perimeter(collider.radius) * prismDepth * scale.z);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CircleCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Sphere.Surface(collider.radius * Mathf.Max(scale.x, scale.y));
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CircleCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Circle.Area(collider.radius * Mathf.Max(scale.x, scale.y)) * prismDepth * scale.z;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CircleCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return Sphere.Volume(collider.radius * Mathf.Max(scale.x, scale.y));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this CapsuleCollider2D collider)
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
			case CapsuleDirection2D.Vertical:
			{
				float r = collider.size.x * 0.5f * scale.x;
				float e = Mathf.Max(0, (collider.size.y * scale.y) - r - r);
				return Circle.Area(r) + (e * r * 2);
			}
			case CapsuleDirection2D.Horizontal:
			{
				float r = collider.size.y * 0.5f * scale.y;
				float e = Mathf.Max(0, (collider.size.x * scale.x) - r - r);
				return Circle.Area(r) + (e * r * 2);
			}
		}
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CapsuleCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Axis
		Vector3 scale = collider.transform.lossyScale;
		float radius;
		float extension;
		switch (collider.direction)
		{
			default:
			case CapsuleDirection2D.Vertical:
			{
				radius = collider.size.x * 0.5f * scale.x;
				extension = Mathf.Max(0, (collider.size.y * scale.y) - radius - radius);
				break;
			}
			case CapsuleDirection2D.Horizontal:
			{
				radius = collider.size.y * 0.5f * scale.y;
				extension = Mathf.Max(0, (collider.size.x * scale.x) - radius - radius);
				break;
			}
		}

		// Return
		return Cylinder.Surface(radius, prismDepth) + ((extension * (radius + radius + prismDepth)) * 2);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CapsuleCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Axis
		Vector3 scale = collider.transform.lossyScale;
		float radius;
		float extension;
		switch (collider.direction)
		{
			default:
			case CapsuleDirection2D.Vertical:
			{
				radius = collider.size.x * 0.5f * scale.x;
				extension = Mathf.Max(0, (collider.size.y * scale.y) - radius - radius);
				break;
			}
			case CapsuleDirection2D.Horizontal:
			{
				radius = collider.size.y * 0.5f * scale.y;
				extension = Mathf.Max(0, (collider.size.x * scale.x) - radius - radius);
				break;
			}
		}

		// Return
		return Capsule.Surface(radius, extension);
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CapsuleCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Axis
		Vector3 scale = collider.transform.lossyScale;
		float radius;
		float extension;
		switch (collider.direction)
		{
			default:
			case CapsuleDirection2D.Vertical:
			{
				radius = collider.size.x * 0.5f * scale.x;
				extension = Mathf.Max(0, (collider.size.y * scale.y) - radius - radius);
				break;
			}
			case CapsuleDirection2D.Horizontal:
			{
				radius = collider.size.y * 0.5f * scale.y;
				extension = Mathf.Max(0, (collider.size.x * scale.x) - radius - radius);
				break;
			}
		}

		// Return
		return Cylinder.Volume(radius, prismDepth) + ((radius + radius) * extension * prismDepth);
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CapsuleCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Axis
		Vector3 scale = collider.transform.lossyScale;
		float radius;
		float extension;
		switch (collider.direction)
		{
			default:
			case CapsuleDirection2D.Vertical:
			{
				radius = collider.size.x * 0.5f * scale.x;
				extension = Mathf.Max(0, (collider.size.y * scale.y) - radius - radius);
				break;
			}
			case CapsuleDirection2D.Horizontal:
			{
				radius = collider.size.y * 0.5f * scale.y;
				extension = Mathf.Max(0, (collider.size.x * scale.x) - radius - radius);
				break;
			}
		}

		// Return
		return Capsule.Volume(radius, extension);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this PolygonCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this PolygonCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this PolygonCollider2D collider)
	{
		return (collider != null) ? (GetSurface(collider, 1)) : (0); // TODO: Run through the polygon for a depth.
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this PolygonCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this PolygonCollider2D collider)
	{
		return (collider != null) ? (GetVolume(collider, 1)) : (0); // TODO: Run through the polygon for a depth.
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this EdgeCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Length
		Vector3 scale = collider.transform.lossyScale;
		float length = 0;
		int end = collider.points.Length;
		for (int i = 1; i < end; i++)
		{
			Vector2 point0 = Vector2.Scale(scale, collider.points[i - 1] * scale);
			Vector2 point1 = Vector2.Scale(scale, collider.points[i]);
			length += Vector2.Distance(point0, point1);
		}

		// Return
		return length * EDGE_WIDTH;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this EdgeCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Length
		Vector3 scale = collider.transform.lossyScale;
		float length = 0;
		int end = collider.points.Length;
		for (int i = 1; i < end; i++)
		{
			Vector2 point0 = Vector2.Scale(scale, collider.points[i - 1] * scale);
			Vector2 point1 = Vector2.Scale(scale, collider.points[i]);
			length += Vector2.Distance(point0, point1);
		}

		// Return
		return 2 * ((length * EDGE_WIDTH) + (length * prismDepth) + (EDGE_WIDTH * EDGE_WIDTH));
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this EdgeCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Length
		Vector3 scale = collider.transform.lossyScale;
		float length = 0;
		int end = collider.points.Length;
		for (int i = 1; i < end; i++)
		{
			Vector2 point0 = Vector2.Scale(scale, collider.points[i - 1] * scale);
			Vector2 point1 = Vector2.Scale(scale, collider.points[i]);
			length += Vector2.Distance(point0, point1);
		}

		// Return
		return (length * EDGE_WIDTH * 4) + (EDGE_WIDTH * EDGE_WIDTH * 2);
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this EdgeCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Length
		Vector3 scale = collider.transform.lossyScale;
		float length = 0;
		int end = collider.points.Length;
		for (int i = 1; i < end; i++)
		{
			Vector2 point0 = Vector2.Scale(scale, collider.points[i - 1] * scale);
			Vector2 point1 = Vector2.Scale(scale, collider.points[i]);
			length += Vector2.Distance(point0, point1);
		}

		// Return
		return length * EDGE_WIDTH * prismDepth;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this EdgeCollider2D collider)
	{
		return (collider != null) ? (GetVolume(collider, EDGE_WIDTH)) : (0);
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this TilemapCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Sum
		Vector3 scale = collider.transform.lossyScale;
		float area = 0;
		PhysicsShapeGroup2D group = new PhysicsShapeGroup2D();
		int end = collider.GetShapes(group);
		for (int i = 1; i < end; i++)
		{
			PhysicsShape2D shape = group.GetShape(i);
			switch (shape.shapeType)
			{
				case PhysicsShapeType2D.Circle:
				{
					area += Circle.Area(shape.radius * Mathf.Max(scale.x, scale.y));
					break;
				}
				case PhysicsShapeType2D.Capsule:
				{
					Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, 0));
					Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, 1));
					area += (shape.radius + shape.radius) * Vector2.Distance(v0, v1);
					area += Circle.Area(shape.radius * Mathf.Max(scale.x, scale.y));
					break;
				}
				case PhysicsShapeType2D.Edges:
				{
					float length = 0;
					for (int j = 1; j < shape.vertexCount; j++)
					{
						Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, j - 1));
						Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, j));
						length += Vector2.Distance(v0, v1);
					}
					area += length * EDGE_WIDTH;
					break;
				}
				default:
				{
					if (shape.vertexCount > 1)
					{
						float xMin = float.MaxValue;
						float xMax = float.MinValue;
						float yMin = float.MaxValue;
						float yMax = float.MinValue;
						for (int j = 0; j < shape.vertexCount; j++)
						{
							Vector2 v = Vector2.Scale(scale, group.GetShapeVertex(i, j));
							xMin = Mathf.Min(xMin, v.x);
							xMax = Mathf.Max(xMax, v.x);
							yMin = Mathf.Min(yMin, v.y);
							yMax = Mathf.Max(yMax, v.y);
						}
						area += (xMax - xMin) * (yMax - yMin); // TODO: More polygons than just a rectabgle.
					}
					break;
				}
			}
		}

		// Return
		return area;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this TilemapCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Sum
		Vector3 scale = collider.transform.lossyScale;
		float area = 0;
		PhysicsShapeGroup2D group = new PhysicsShapeGroup2D();
		int end = collider.GetShapes(group);
		for (int i = 1; i < end; i++)
		{
			PhysicsShape2D shape = group.GetShape(i);
			switch (shape.shapeType)
			{
				case PhysicsShapeType2D.Circle:
				{
					area += Cylinder.Surface(shape.radius * Mathf.Max(scale.x, scale.y), prismDepth);
					break;
				}
				case PhysicsShapeType2D.Capsule:
				{
					Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, 0));
					Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, 1));
					area += ((shape.radius * 4) + prismDepth + prismDepth) * Vector2.Distance(v0, v1);
					area += Cylinder.Surface(shape.radius * Mathf.Max(scale.x, scale.y), prismDepth);
					break;
				}
				case PhysicsShapeType2D.Edges:
				{
					float length = 0;
					for (int j = 1; j < shape.vertexCount; j++)
					{
						Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, j - 1));
						Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, j));
						length += Vector2.Distance(v0, v1);
					}
					area += 2 * ((length * EDGE_WIDTH) + (length * prismDepth) + (EDGE_WIDTH * EDGE_WIDTH));
					break;
				}
				default:
				{
					if (shape.vertexCount > 1)
					{
						float xMin = float.MaxValue;
						float xMax = float.MinValue;
						float yMin = float.MaxValue;
						float yMax = float.MinValue;
						for (int j = 0; j < shape.vertexCount; j++)
						{
							Vector2 v = Vector2.Scale(scale, group.GetShapeVertex(i, j));
							xMin = Mathf.Min(xMin, v.x);
							xMax = Mathf.Max(xMax, v.x);
							yMin = Mathf.Min(yMin, v.y);
							yMax = Mathf.Max(yMax, v.y);
						}
						float x = xMax - xMin;
						float y = yMax - yMin;
						area += 2 * ((x * y) + (x * prismDepth) + (y * prismDepth)); // TODO: More polygons than just a rectangle.
					}
					break;
				}
			}
		}

		// Return
		return area;
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this TilemapCollider2D collider)
	{
		return (collider != null) ? (GetVolume(collider, 1)) : (0); // TODO: Expand to unique depths.
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this TilemapCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Sum
		Vector3 scale = collider.transform.lossyScale;
		float area = 0;
		PhysicsShapeGroup2D group = new PhysicsShapeGroup2D();
		int end = collider.GetShapes(group);
		for (int i = 1; i < end; i++)
		{
			PhysicsShape2D shape = group.GetShape(i);
			switch (shape.shapeType)
			{
				case PhysicsShapeType2D.Circle:
				{
					area += Cylinder.Volume(shape.radius * Mathf.Max(scale.x, scale.y), prismDepth);
					break;
				}
				case PhysicsShapeType2D.Capsule:
				{
					Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, 0));
					Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, 1));
					area += (shape.radius + shape.radius) * Vector2.Distance(v0, v1);
					area += Cylinder.Volume(shape.radius * Mathf.Max(scale.x, scale.y), prismDepth);
					break;
				}
				case PhysicsShapeType2D.Edges:
				{
					float length = 0;
					for (int j = 1; j < shape.vertexCount; j++)
					{
						Vector2 v0 = Vector2.Scale(scale, group.GetShapeVertex(i, j - 1));
						Vector2 v1 = Vector2.Scale(scale, group.GetShapeVertex(i, j));
						length += Vector2.Distance(v0, v1);
					}
					area += length * EDGE_WIDTH * prismDepth;
					break;
				}
				default:
				{
					if (shape.vertexCount > 1)
					{
						float xMin = float.MaxValue;
						float xMax = float.MinValue;
						float yMin = float.MaxValue;
						float yMax = float.MinValue;
						for (int j = 0; j < shape.vertexCount; j++)
						{
							Vector2 v = Vector2.Scale(scale, group.GetShapeVertex(i, j));
							xMin = Mathf.Min(xMin, v.x);
							xMax = Mathf.Max(xMax, v.x);
							yMin = Mathf.Min(yMin, v.y);
							yMax = Mathf.Max(yMax, v.y);
						}
						area += (xMax - xMin) * (yMax - yMin) * prismDepth; // TODO: More polygons than just a rectangle.
					}
					break;
				}
			}
		}

		// Return
		return area;
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this TilemapCollider2D collider)
	{
		return (collider != null) ? (GetVolume(collider, 1)) : (0); // TODO: Expand to unique depths.
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetArea(this CompositeCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CompositeCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the surface area of this collider.
	/// </summary>
	public static float GetSurface(this CompositeCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CompositeCollider2D collider, float prismDepth)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}

	/// <summary>
	/// Returns the volume of this collider.
	/// </summary>
	public static float GetVolume(this CompositeCollider2D collider)
	{
		// Cannot be null.
		if (collider == null)
		{
			return 0;
		}

		// Return
		Vector3 scale = collider.transform.lossyScale;
		return 0; // TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO
	}
}