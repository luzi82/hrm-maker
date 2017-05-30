using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AspectRatioScript : MonoBehaviour {

	public bool isOuter;
	public GameObject parent;
	public float ratio;

	private bool oldIsOuter = false;
	private GameObject oldParent = null;
	private float oldRatio = float.NaN;
	private Vector2 oldScale;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		RectTransform prt = (RectTransform)parent.GetComponent(typeof(RectTransform));
		Vector2 nowScale = prt.rect.size;
		if((oldScale!=nowScale)||(oldIsOuter!=isOuter)||(oldParent!=parent)||(oldRatio!=ratio)){
			float w0 = nowScale.y*ratio;
			float h0 = nowScale.x/ratio;
			if(isOuter){
				w0 = Mathf.Max(w0,nowScale.x);
				h0 = Mathf.Max(h0,nowScale.y);
			}else{
				w0 = Mathf.Min(w0,nowScale.x);
				h0 = Mathf.Min(h0,nowScale.y);
			}
			RectTransform rt = (RectTransform)GetComponent(typeof(RectTransform));
			rt.sizeDelta = new Vector2(w0,h0);
			//Debug.Log(rt.sizeDelta);

			oldIsOuter=isOuter;
			oldParent=parent;
			oldRatio=ratio;
			oldScale=nowScale;
		}
	}
}
