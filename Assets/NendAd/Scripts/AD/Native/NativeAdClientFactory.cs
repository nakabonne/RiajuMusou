namespace NendUnityPlugin.AD.Native
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;

	/// <summary>
	/// Native ad client factory.
	/// </summary>
	public class NativeAdClientFactory
	{
		/// <summary>
		/// Create the new client instance.
		/// </summary>
		/// <returns>The client.</returns>
		/// <param name="spotId">Spot identifier.</param>
		/// <param name="apiKey">API key.</param>
		/// \warning Call this on the main thread.
		public static INativeAdClient NewClient (string spotId, string apiKey)
		{
			#if !UNITY_EDITOR && UNITY_IPHONE
			return new NendUnityPlugin.Platform.iOS.IOSNativeAdClient(apiKey, spotId);
			#elif !UNITY_EDITOR && UNITY_ANDROID
			return new NendUnityPlugin.Platform.Android.AndroidNativeAdClient(apiKey, spotId);
			#else
			return null;
			#endif
		}

		#region Test

		#if UNITY_EDITOR

		/// <summary>
		/// The type of native ad.
		/// </summary>
		/// \warning Can use only on UnityEditor.
		public enum NativeAdType
		{
			/// <summary>
			/// Contains 80x80 image.
			/// </summary>
			SmallSquare,
			/// <summary>
			/// Contains 80x60 image.
			/// </summary>
			SmallWide,
			/// <summary>
			/// Contains 300x180 image.
			/// </summary>
			LargeWide,
			/// <summary>
			/// Text only.
			/// </summary>
			TextOnly
		}

		/// <summary>
		/// Create the new client instance for test.
		/// </summary>
		/// <returns>The client.</returns>
		/// <param name="type">Type.</param>
		/// \warning Can use only on UnityEditor.
		public static INativeAdClient NewClient (NativeAdType type) {
			return new NativeClientStub (type);
		}

	    private class NativeClientStub : NativeAdClient
		{
			private NativeAdType m_AdType;

			internal NativeClientStub (NativeAdType adType)
			{
				m_AdType = adType;
			}

			public override void LoadNativeAd (Action<INativeAd, int, string> callback)
			{
				m_Callbacks.Enqueue (callback);
				DeliverResponseOnMainThread (new DummyNativeAd (m_AdType), 200, "");
			}
		}

		private class DummyNativeAd : NativeAd
		{
			private NativeAdType m_AdType;
			private int m_ImageIndex = 0;
			private Dictionary<int, string> m_LargeImageMap = new Dictionary<int, string> ();
			private Dictionary<int, string> m_LogoImageMap = new Dictionary<int, string> ();

			internal DummyNativeAd (NativeAdType adType)
			{
				m_AdType = adType;

				m_LargeImageMap[0] = "https://img1.nend.net/img/banner/329/71105/1307070.png";
				m_LargeImageMap[1] = "https://img1.nend.net/img/banner/329/70572/1292197.png";
				m_LargeImageMap[2] = "https://img1.nend.net/img/banner/329/71103/1307041.png";
				m_LargeImageMap[3] = "https://img1.nend.net/img/banner/329/71102/1307030.png";
				m_LargeImageMap[4] = "https://img1.nend.net/img/banner/329/71104/1307056.png";
				m_LogoImageMap[0] = "https://img1.nend.net/img/banner/329/71105/1307071.png";
				m_LogoImageMap[1] = "https://img1.nend.net/img/banner/329/70572/1292198.png";
				m_LogoImageMap[2] = "https://img1.nend.net/img/banner/329/71103/1307042.png";
				m_LogoImageMap[3] = "https://img1.nend.net/img/banner/329/71102/1307031.png";
				m_LogoImageMap[4] = "https://img1.nend.net/img/banner/329/71104/1307057.png";

				if (NativeAdType.LargeWide == m_AdType) {
					var r = new System.Random ();
					m_ImageIndex = r.Next (5);
				}
			}

			public override string ToString ()
			{
				return "DummyNativeAd: " + GetHashCode ();
			}

			internal override void SendImpression ()
			{
				Debug.Log ("SendImpression");
			}

			internal override void PerformAdClick ()
			{
				Debug.Log ("PerformAdClick");
			}

			internal override void PerformInformationClick ()
			{
				Debug.Log ("PerformInformationClick");
			}

			public override string GetAdvertisingExplicitlyText (AdvertisingExplicitly advertisingExplicitly)
			{
				switch (advertisingExplicitly) {
				case AdvertisingExplicitly.PR:
					return "PR";
				case AdvertisingExplicitly.Sponsored:
					return "Sponsored";
				case AdvertisingExplicitly.AD:
					return "広告";
				case AdvertisingExplicitly.Promotion:
					return "プロモーション";
				default:
					return "";
				}
			}

			public override string ShortText {
				get {
					return "国内・海外の旅行予約はnendトラベル";
				}
			}

			public override string LongText {
				get {
					return "国内旅行・海外旅行のツアーやホテル予約が簡単。日程や条件から細かく検索できます";
				}
			}

			public override string PromotionUrl {
				get {
					return "nend.net";
				}
			}

			public override string PromotionName {
				get {
					return "nendトラベル";
				}
			}

			public override string ActionButtonText {
				get {
					return "サイトへ行く";
				}
			}

			public override string AdImageUrl {
				get {
					switch (m_AdType) {
					case NativeAdType.SmallSquare:
						return "https://img1.nend.net/img/banner/329/71105/1307068.png";
					case NativeAdType.SmallWide:
						return "https://img1.nend.net/img/banner/329/70572/1292196.png";
					case NativeAdType.LargeWide:
						return m_LargeImageMap [m_ImageIndex];
					default:
						return null;
					}
				}
			}
				
			public override  string LogoImageUrl {
				get {
					if (NativeAdType.LargeWide == m_AdType) {
						return m_LogoImageMap [m_ImageIndex];
					} else {
						return null;
					}
				}
			}
		}
		#endif

		#endregion
	}
}