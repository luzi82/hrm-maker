using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class CodeListScript : MonoBehaviour {

	public GameObject logcat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (logcat == null)
//			return;
//
//		float size = logcat.GetComponent<RectTransform> ().rect.height;
//
//		RectTransform rt = GetComponent<RectTransform> ();
//		rt.anchorMin = new Vector2 (0, 1);
//		rt.offsetMin = new Vector2 (0, -size);
//		rt.anchorMax = new Vector2 (1, 1);
//		rt.offsetMax = new Vector2 (0, 0);
	}

	public float GetHeight(){
		if (logcat == null)
			return 0;
//		return logcat.GetComponent<RectTransform> ().rect.height;
		return logcat.GetComponent<LogCatScript> ().size;
	}
}
