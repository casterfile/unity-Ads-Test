using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class TestAds : MonoBehaviour { 

	string gameId = "2881690";
	bool testMode = true;

	void Start () {
		Monetization.Initialize (gameId, testMode);
	}
}