// SubscribedBoolean.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 14, 2022

using System.Collections.Generic;

namespace Zop
{
	/// <summary>
	/// Returns true while this is observed by one or more objects.
	/// </summary>
	public class SubscribedBoolean
	{
		public bool IsActive { get { return _isSubscribed; } }
		public bool IsSubscribed { get { return _isSubscribed; } }

		private bool _isSubscribed;
		private readonly HashSet<object> _subscribers = new HashSet<object>(ObjectComparer.Instance);

		/// <summary>
		/// Returns true if this subscriber is added.
		/// </summary>
		public bool Add(object subscriber)
		{
			bool result = subscriber != null && _subscribers.Add(subscriber);
			_isSubscribed = _subscribers.Count > 0;
			return result;
		}

		/// <summary>
		/// Returns true if this subscriber is removed.
		/// </summary>
		public bool Remove(object subscriber)
		{
			bool result = _subscribers.Remove(subscriber);
			_isSubscribed = _subscribers.Count > 0;
			return result;
		}

		/// <summary>
		/// Clear all subscribers.
		/// </summary>
		public void Clear()
		{
			_subscribers.Clear();
			_isSubscribed = false;
		}
	}
}