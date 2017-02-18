using UnityEngine;
using System.Collections;

public class LoadToTutorial : MonoBehaviour {

	private AsyncOperation async = null;
	void Start () {
		StartCoroutine(loadScene());  
	}
	
	// Update is called once per frame
	IEnumerator loadScene()  
	{  
		async = Application.LoadLevelAsync("Tutorial");
		yield return async;
		Debug.Log("Complete!");
	}
}
