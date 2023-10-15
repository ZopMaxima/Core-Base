// FuncUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using UnityEngine;

/// <summary>
/// Extend the func class.
/// </summary>
public static class FuncUtil
{
	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<TReturn>(this Func<TReturn> func)
	{
		if (func != null)
		{
			try { return func(); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T, TReturn>(this Func<T, TReturn> func, T t)
	{
		if (func != null)
		{
			try { return func(t); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, TReturn>(this Func<T0, T1, TReturn> func, T0 t0, T1 t1)
	{
		if (func != null)
		{
			try { return func(t0, t1); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, TReturn>(this Func<T0, T1, T2, TReturn> func, T0 t0, T1 t1, T2 t2)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, T3, TReturn>(this Func<T0, T1, T2, T3, TReturn> func, T0 t0, T1 t1, T2 t2, T3 t3)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2, t3); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, T3, T4, TReturn>(this Func<T0, T1, T2, T3, T4, TReturn> func, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2, t3, t4); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, T3, T4, T5, TReturn>(this Func<T0, T1, T2, T3, T4, T5, TReturn> func, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2, t3, t4, t5); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, T3, T4, T5, T6, TReturn>(this Func<T0, T1, T2, T3, T4, T5, T6, TReturn> func, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2, t3, t4, t5, t6); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}

	/// <summary>
	/// Invoke the function.
	/// </summary>
	public static TReturn Try<T0, T1, T2, T3, T4, T5, T6, T7, TReturn>(this Func<T0, T1, T2, T3, T4, T5, T6, T7, TReturn> func, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
	{
		if (func != null)
		{
			try { return func(t0, t1, t2, t3, t4, t5, t6, t7); }
			catch (Exception e) { Debug.LogException(e); }
		}
		return default(TReturn);
	}
}