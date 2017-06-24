using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LogCatScript : MonoBehaviour {

	public GameObject canvas;
	public float size;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RectTransform rt = GetComponent<RectTransform> ();
		rt.anchorMin = new Vector2 (0, 1);
		rt.offsetMin = new Vector2 (0, -size);
		rt.anchorMax = new Vector2 (1, 1);
		rt.offsetMax = new Vector2 (0, 0);
	}

	public void Inc(){
		float y = canvas.GetComponent<RectTransform> ().rect.height / 10f;
		size += y;
	}

	public void Dec(){
		float y = canvas.GetComponent<RectTransform> ().rect.height / 10f;
		size -= y;
	}
}
