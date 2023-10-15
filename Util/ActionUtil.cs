// ActionUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extend the action class.
/// </summary>
public static class ActionUtil
{
	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try(this Action action)
	{
		if (action == null) return;
		try { action(); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T>(this Action<T> action, T t)
	{
		if (action == null) return;
		try { action(t); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1>(this Action<T0, T1> action, T0 t0, T1 t1)
	{
		if (action == null) return;
		try { action(t0, t1); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2>(this Action<T0, T1, T2> action, T0 t0, T1 t1, T2 t2)
	{
		if (action == null) return;
		try { action(t0, t1, t2); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2, T3>(this Action<T0, T1, T2, T3> action, T0 t0, T1 t1, T2 t2, T3 t3)
	{
		if (action == null) return;
		try { action(t0, t1, t2, t3); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2, T3, T4>(this Action<T0, T1, T2, T3, T4> action, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
	{
		if (action == null) return;
		try { action(t0, t1, t2, t3, t4); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2, T3, T4, T5>(this Action<T0, T1, T2, T3, T4, T5> action, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
	{
		if (action == null) return;
		try { action(t0, t1, t2, t3, t4, t5); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2, T3, T4, T5, T6>(this Action<T0, T1, T2, T3, T4, T5, T6> action, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
	{
		if (action == null) return;
		try { action(t0, t1, t2, t3, t4, t5, t6); }
		catch (Exception e) { Debug.LogException(e); }
	}

	/// <summary>
	/// Invoke the action.
	/// </summary>
	public static void Try<T0, T1, T2, T3, T4, T5, T6, T7>(this Action<T0, T1, T2, T3, T4, T5, T6, T7> action, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
	{
		if (action == null) return;
		try { action(t0, t1, t2, t3, t4, t5, t6, t7); }
		catch (Exception e) { Debug.LogException(e); }
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction
{
	private readonly List<Action> _actions = new List<Action>();
	private readonly List<Action> _cache = new List<Action>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke()
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try();
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T>
{
	private readonly List<Action<T>> _actions = new List<Action<T>>();
	private readonly List<Action<T>> _cache = new List<Action<T>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T t)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1>
{
	private readonly List<Action<T0, T1>> _actions = new List<Action<T0, T1>>();
	private readonly List<Action<T0, T1>> _cache = new List<Action<T0, T1>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2>
{
	private readonly List<Action<T0, T1, T2>> _actions = new List<Action<T0, T1, T2>>();
	private readonly List<Action<T0, T1, T2>> _cache = new List<Action<T0, T1, T2>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2, T3>
{
	private readonly List<Action<T0, T1, T2, T3>> _actions = new List<Action<T0, T1, T2, T3>>();
	private readonly List<Action<T0, T1, T2, T3>> _cache = new List<Action<T0, T1, T2, T3>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2, T3 t3)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2, t3);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2, T3> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2, T3> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2, T3> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2, T3, T4>
{
	private readonly List<Action<T0, T1, T2, T3, T4>> _actions = new List<Action<T0, T1, T2, T3, T4>>();
	private readonly List<Action<T0, T1, T2, T3, T4>> _cache = new List<Action<T0, T1, T2, T3, T4>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2, t3, t4);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2, T3, T4> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2, T3, T4> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2, T3, T4> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2, T3, T4, T5>
{
	private readonly List<Action<T0, T1, T2, T3, T4, T5>> _actions = new List<Action<T0, T1, T2, T3, T4, T5>>();
	private readonly List<Action<T0, T1, T2, T3, T4, T5>> _cache = new List<Action<T0, T1, T2, T3, T4, T5>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2, t3, t4, t5);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2, T3, T4, T5> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2, T3, T4, T5> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2, T3, T4, T5> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2, T3, T4, T5, T6>
{
	private readonly List<Action<T0, T1, T2, T3, T4, T5, T6>> _actions = new List<Action<T0, T1, T2, T3, T4, T5, T6>>();
	private readonly List<Action<T0, T1, T2, T3, T4, T5, T6>> _cache = new List<Action<T0, T1, T2, T3, T4, T5, T6>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2, t3, t4, t5, t6);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2, T3, T4, T5, T6> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2, T3, T4, T5, T6> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2, T3, T4, T5, T6> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}

/// <summary>
/// Perform a full action, even if exceptions are thrown.
/// </summary>
public class FullAction<T0, T1, T2, T3, T4, T5, T6, T7>
{
	private readonly List<Action<T0, T1, T2, T3, T4, T5, T6, T7>> _actions = new List<Action<T0, T1, T2, T3, T4, T5, T6, T7>>();
	private readonly List<Action<T0, T1, T2, T3, T4, T5, T6, T7>> _cache = new List<Action<T0, T1, T2, T3, T4, T5, T6, T7>>();

	/// <summary>
	/// Invoke all registered actions.
	/// </summary>
	public void Invoke(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
	{
		_cache.AddRange(_actions);
		int end = _cache.Count;
		for (int i = 0; i < end; i++)
		{
			_cache[i].Try(t0, t1, t2, t3, t4, t5, t6, t7);
		}
		_cache.Clear();
	}

	/// <summary>
	/// Returns true if this action is present.
	/// </summary>
	public bool Has(Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
	{
		return _actions.Contains(action);
	}

	/// <summary>
	/// Returns true if this action is added.
	/// </summary>
	public bool Add(Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
	{
		if (!_actions.Contains(action))
		{
			_actions.Add(action);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Returns true if this action is removed.
	/// </summary>
	public bool Remove(Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
	{
		return _actions.Remove(action);
	}

	/// <summary>
	/// Clear all registered actions.
	/// </summary>
	public void Clear()
	{
		_actions.Clear();
	}
}