using UnityEngine;
using System.Collections;
using UnityEngine.Cloud.Analytics;

public class UnityAnalyticsIntegration : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		const string projectId = "92309dbc-58d8-49d0-be7f-d43352ace097";
		UnityAnalytics.StartSDK (projectId);
		
	}
	
}