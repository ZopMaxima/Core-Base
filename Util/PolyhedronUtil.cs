// PolyhedronUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   November 5, 2022

using System;
using UnityEngine;

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Sphere
{
	private const double DIV_4_3 = 4.0d / 3.0d;
	private const double DIV_1_16 = 1.0d / 16.0d;

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radius)
	{
		return (float)(4 * radius * radius * Math.PI);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radius)
	{
		return 4 * radius * radius * Math.PI;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radiusX, float radiusY, float radiusZ)
	{
		return (float)(4 * Math.PI * Math.Pow(((Math.Pow(radiusX + radiusY, 1.6d) + Math.Pow(radiusX + radiusZ, 1.6d) + Math.Pow(radiusY + radiusZ, 1.6d)) / 3), DIV_1_16));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radiusX, double radiusY, double radiusZ)
	{
		return 4 * Math.PI * Math.Pow(((Math.Pow(radiusX + radiusY, 1.6d) + Math.Pow(radiusX + radiusZ, 1.6d) + Math.Pow(radiusY + radiusZ, 1.6d)) / 3), DIV_1_16);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(Vector3 scale)
	{
		return Surface(scale.x * 0.5f, scale.y * 0.5f, scale.z * 0.5f);
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radius)
	{
		return (float)(DIV_4_3 * (radius * radius * radius) * Math.PI);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radius)
	{
		return DIV_4_3 * (radius * radius * radius) * Math.PI;
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static float Volume(float radiusX, float radiusY, float radiusZ)
	{
		return (float)(DIV_4_3 * (radiusX * radiusY * radiusZ) * Math.PI);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radiusX, double radiusY, double radiusZ)
	{
		return DIV_4_3 * (radiusX * radiusY * radiusZ) * Math.PI;
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(Vector3 scale)
	{
		return Volume(scale.x * 0.5f, scale.y * 0.5f, scale.z * 0.5f);
	}
}

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Cylinder
{
	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radius, float height)
	{
		return (2 * Circle.Area(radius)) + (Circle.Perimeter(radius) * height);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radius, double height)
	{
		return (2 * Circle.Area(radius)) + (Circle.Perimeter(radius) * height);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radiusX, float radiusY, float height)
	{
		return (2 * Circle.Area(radiusX, radiusY)) + (Circle.Perimeter(radiusX, radiusY) * height);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radiusX, double radiusY, double height)
	{
		return (2 * Circle.Area(radiusX, radiusY)) + (Circle.Perimeter(radiusX, radiusY) * height);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(Vector2 scale, float height)
	{
		return Surface(scale.x * 0.5f, scale.y * 0.5f, height);
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radius, float height)
	{
		return Circle.Area(radius) * height;
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radius, double height)
	{
		return Circle.Area(radius) * height;
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radiusX, float radiusY, float height)
	{
		return Circle.Area(radiusX, radiusY) * height;
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radiusX, double radiusY, double height)
	{
		return Circle.Area(radiusX, radiusY) * height;
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(Vector2 scale, float height)
	{
		return Volume(scale.x * 0.5f, scale.y * 0.5f, height);
	}
}

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Capsule
{
	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radius, float extension)
	{
		return Sphere.Surface(radius) + (Circle.Perimeter(radius) * extension);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radius, double extension)
	{
		return Sphere.Surface(radius) + (Circle.Perimeter(radius) * extension);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radiusX, float radiusY, float radiusExtension, float extension)
	{
		return Sphere.Surface(radiusX, radiusY, radiusExtension) + (Circle.Perimeter(radiusX, radiusY) * extension);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radiusX, double radiusY, double radiusExtension, double extension)
	{
		return Sphere.Surface(radiusX, radiusY, radiusExtension) + (Circle.Perimeter(radiusX, radiusY) * extension * radiusExtension * 2);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(Vector3 scale, float extension)
	{
		return Surface(scale.x * 0.5f, scale.y * 0.5f, scale.z * 0.5f, extension);
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radius, float extension)
	{
		return Sphere.Volume(radius) + Cylinder.Volume(radius, extension);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radius, double extension)
	{
		return Sphere.Volume(radius) + Cylinder.Volume(radius, extension);
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radiusX, float radiusY, float radiusExtension, float extension)
	{
		return Sphere.Volume(radiusX, radiusY, radiusExtension) + Cylinder.Volume(radiusX, radiusY, extension * radiusExtension * 2);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radiusX, double radiusY, double radiusExtension, double extension)
	{
		return Sphere.Volume(radiusX, radiusY, radiusExtension) + Cylinder.Volume(radiusX, radiusY, extension * radiusExtension * 2);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(Vector3 scale, float extension)
	{
		return Volume(scale.x * 0.5f, scale.y * 0.5f, scale.z * 0.5f, extension);
	}
}

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Cone
{
	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radius, float height)
	{
		return (float)(Math.PI * radius * (radius + Math.Sqrt((radius * radius) + (height * height))));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radius, double height)
	{
		return Math.PI * radius * (radius + Math.Sqrt((radius * radius) + (height * height)));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Surface(float radiusX, float radiusY, float height)
	{
		return (radiusX == radiusY) ? (Surface(radiusX, height)) : (Surface(radiusX, radiusY, height) * radiusY); // TODO: LOLNO, Complete the elliptical formula.
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(double radiusX, double radiusY, double height)
	{
		return (radiusX == radiusY) ? (Surface(radiusX, height)) : (Surface(radiusX, radiusY, height) * radiusY); // TODO: LOLNO, Complete the elliptical formula.
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Surface(Vector2 scale, double height)
	{
		return Surface(scale.x * 0.5f, scale.y * 0.5f, height);
	}

	/// <summary>
	/// Returns the volume of this polygon.
	/// </summary>
	public static float Volume(float radius, float height)
	{
		return Circle.Area(radius) * (height / 3.0f);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radius, double height)
	{
		return Circle.Area(radius) * (height / 3.0d);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static float Volume(float radiusX, float radiusY, float height)
	{
		return Circle.Area(radiusX, radiusY) * (height / 3.0f);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(double radiusX, double radiusY, double height)
	{
		return Circle.Area(radiusX, radiusY) * (height / 3.0d);
	}

	/// <summary>
	/// Returns the volume area of this polygon.
	/// </summary>
	public static double Volume(Vector2 scale, double height)
	{
		return Volume(scale.x * 0.5f, scale.y * 0.5f, height);
	}
}