using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SizeFollowScript : MonoBehaviour {

	public GameObject parent;

	private Vector2 oldSize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(parent==null)return;
		RectTransform prt = (RectTransform)parent.GetComponent(typeof(RectTransform));
		Vector2 nowSize = prt.rect.size;
		if(oldSize!=nowSize){
			RectTransform rt = (RectTransform)GetComponent(typeof(RectTransform));
			rt.sizeDelta = nowSize;
			oldSize=nowSize;
		}
	}
}
