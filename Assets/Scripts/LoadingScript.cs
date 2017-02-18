using UnityEngine;
using System.Collections;

public class LoadingScript : MonoBehaviour {

	// Use this for initialization

	private AsyncOperation async = null;
	void Start () {
		StartCoroutine(loadScene());  
	}
	
	// Update is called once per frame
	IEnumerator loadScene()  
	{  
		async = Application.LoadLevelAsync("Test");
		yield return async;
		Debug.Log("Complete!");
	}
}
