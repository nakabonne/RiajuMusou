namespace NendUnityPlugin.AD.Native
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;

	using Callback = System.Action<NendUnityPlugin.AD.Native.INativeAd, int, string>;
	using Timer = NendUnityPlugin.AD.Native.Utils.SimpleTimer;
	using Log = NendUnityPlugin.Common.NendAdLogger;
	using Worker = NendUnityPlugin.Common.NendAdMainThreadWorker;

	internal class NativeAdClient : INativeAdClient, IDisposable
	{
		internal const double MinimumReloadInterval = 30.0 * 1000.0;

		private Timer m_Timer;
		private Callback m_ReloadCallback;
		protected Queue<Callback> m_Callbacks = new Queue<Callback> ();

		protected NativeAdClient ()
		{
			Worker.Prepare ();
			m_Timer = new Timer ();
			m_Timer.OnFireEvent = () => {
				LoadNativeAd (m_ReloadCallback);
			};
		}

		~NativeAdClient ()
		{
			Dispose ();
		}

		public virtual void Dispose ()
		{
			Log.D ("Dispose NativeAdClient.");
			m_Callbacks.Clear ();
			m_Timer.Dispose ();
			m_Timer = null;
		}

		public virtual void LoadNativeAd (Callback callback)
		{
			throw new NotImplementedException ();
		}

		public void EnableAutoReload (double interval, Callback callback)
		{
			if (MinimumReloadInterval <= interval) {
				m_ReloadCallback = callback;
				m_Timer.Start (interval);
			} else {
				Log.W ("A reload interval is less than 30 seconds.");
			}
		}

		public void DisableAutoReload ()
		{
			m_Timer.Stop ();
		}

		protected void EnqueueCallback (Callback callback)
		{
			if (null != callback) {
				lock (m_Callbacks) {
					m_Callbacks.Enqueue (callback);
				}
			}
		}

		protected void DeliverResponseOnMainThread (INativeAd ad, int code, string message) 
		{
			lock (m_Callbacks) {
				if (0 < m_Callbacks.Count) {
					var callback = m_Callbacks.Dequeue ();
					Worker.Instance.Post (() => {
						callback (ad, code, message);
					});
				}
			}
		}
	}
}