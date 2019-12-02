using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Monetization;

public class UnityAdsPlacement : MonoBehaviour {

	private string placementId = "rewardvideo";

	public void ShowAd () {
		StartCoroutine (ShowAdWhenReady ());
	}

	private IEnumerator ShowAdWhenReady () {
		while (!Monetization.IsReady (placementId)) {
			yield return new WaitForSeconds(0.25f);
		}

		ShowAdPlacementContent ad = null;
		ad = Monetization.GetPlacementContent (placementId) as ShowAdPlacementContent;

		if(ad != null) {
			ad.Show ();
		}
	}
}