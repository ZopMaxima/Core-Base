// PolygonUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   November 5, 2022

using System;
using UnityEngine;

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Circle
{
	public const double PERCENT_BOUNDS_DOUBLE = 0.25d * Math.PI;
	public const float PERCENT_BOUNDS = (float)PERCENT_BOUNDS_DOUBLE;

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Area(float radius)
	{
		return (float)(radius * radius * Math.PI);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Area(double radius)
	{
		return radius * radius * Math.PI;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Area(float radiusX, float radiusY)
	{
		return (float)(radiusX * radiusY * Math.PI);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Area(double radiusX, double radiusY)
	{
		return radiusX * radiusY * Math.PI;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Area(Vector2 scale)
	{
		return Area(scale.x * 0.5f, scale.y * 0.5f);
	}

	/// <summary>
	/// Returns the perimeter of this polygon.
	/// </summary>
	public static float Perimeter(float radius)
	{
		return (float)((radius + radius) * Math.PI);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Perimeter(double radius)
	{
		return (radius + radius) * Math.PI;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Perimeter(float radiusX, float radiusY)
	{
		float a = radiusX + radiusY;
		float s = radiusX - radiusY;
		float a2 = a * a;
		float s2 = s * s;
		return (float)(Math.PI * a * (3 * (s2 / (a2 * (Math.Sqrt(-3 * (s2 / a2) + 4) + 10)) + 1)));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double Perimeter(double radiusX, double radiusY)
	{
		double a = radiusX + radiusY;
		double s = radiusX - radiusY;
		double a2 = a * a;
		double s2 = s * s;
		return Math.PI * a * (3 * (s2 / (a2 * (Math.Sqrt(-3 * (s2 / a2) + 4) + 10)) + 1));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float Perimeter(Vector2 scale)
	{
		return Perimeter(scale.x * 0.5f, scale.y * 0.5f);
	}
}

/// <summary>
/// Basic math equations for polygons.
/// </summary>
public static class Triangle
{
	private static readonly double SQRT_3 = Math.Sqrt(3);
	private static readonly double MULTIPLY_EQUIL_AREA = SQRT_3 / 4.0d;
	private static readonly double MULTIPLY_EQUIL_SIDE = 2.0d / SQRT_3;
	private static readonly double MULTIPLY_EQUIL_HEIGHT = SQRT_3 / 2.0d;

	public const double PERCENT_BOUNDS_DOUBLE = 0.5f;
	public const float PERCENT_BOUNDS = (float)PERCENT_BOUNDS_DOUBLE;

	/// <summary>
	/// Returns the hypotenuse of this polygon.
	/// </summary>
	public static float Hypotenuse(float sideA, float sideB)
	{
		return (float)Math.Sqrt((sideA * sideA) + (sideB * sideB));
	}

	/// <summary>
	/// Returns the hypotenuse of this polygon.
	/// </summary>
	public static double Hypotenuse(double sideA, double sideB)
	{
		return Math.Sqrt((sideA * sideA) + (sideB * sideB));
	}

	/// <summary>
	/// Returns the side of this polygon.
	/// </summary>
	public static float SideEquil(float height)
	{
		return (float)(MULTIPLY_EQUIL_SIDE * height);
	}

	/// <summary>
	/// Returns the side of this polygon.
	/// </summary>
	public static double SideEquil(double height)
	{
		return MULTIPLY_EQUIL_SIDE * height;
	}

	/// <summary>
	/// Returns the height of this polygon.
	/// </summary>
	public static float HeightEquil(float side)
	{
		return (float)(MULTIPLY_EQUIL_HEIGHT * side);
	}

	/// <summary>
	/// Returns the height of this polygon.
	/// </summary>
	public static double HeightEquil(double side)
	{
		return MULTIPLY_EQUIL_HEIGHT * side;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float AreaRight(float width, float height)
	{
		return width * height * 0.5f;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double AreaRight(double width, double height)
	{
		return width * height * 0.5d;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float AreaAcute(float width, float height)
	{
		return width * height * 0.5f;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double AreaAcute(double width, double height)
	{
		return width * height * 0.5d;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float AreaEquil(float side)
	{
		return (float)(MULTIPLY_EQUIL_AREA * side * side);
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double AreaEquil(double side)
	{
		return MULTIPLY_EQUIL_AREA * side * side;
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static float AreaScalene(float sideA, float sideB, float sideC)
	{
		float s = (sideA + sideB + sideC) * 0.5f;
		return (float)Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
	}

	/// <summary>
	/// Returns the surface area of this polygon.
	/// </summary>
	public static double AreaScalene(double sideA, double sideB, double sideC)
	{
		double s = (sideA + sideB + sideC) * 0.5d;
		return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
	}
}