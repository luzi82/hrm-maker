using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CodeListContentScript : MonoBehaviour {

	public GameObject parent;
	public GameObject child;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (child == null)
			return;
		if (parent == null)
			return;

		RectTransform parentRt = parent.GetComponent<RectTransform> ();
		float parentHeight = parentRt.rect.height;

		RectTransform childRt = child.GetComponent<RectTransform> ();
		CodeListScript cls = child.GetComponent<CodeListScript> ();
		float childHeight = cls.GetHeight();

//		UnityEngine.Debug.Log (System.String.Format ("childHeight {0}, parentHeight {1}", childHeight, parentHeight));

		RectTransform rt = GetComponent<RectTransform> ();
		if (childHeight >= parentHeight) {
			float y1 = rt.offsetMax.y;
			rt.anchorMin = new Vector2 (0, 1);
			rt.offsetMin = new Vector2 (0, y1 - childHeight);
			rt.anchorMax = new Vector2 (1, 1);
			rt.offsetMax = new Vector2 (0, y1);

			childRt.anchorMin = new Vector2 (0, 1);
			childRt.offsetMin = new Vector2 (0, -childHeight);
			childRt.anchorMax = new Vector2 (1, 1);
			childRt.offsetMax = new Vector2 (0, 0);
		} else {
			rt.anchorMin = new Vector2 (0, 0);
			rt.offsetMin = new Vector2 (0, 0);
			rt.anchorMax = new Vector2 (1, 1);
			rt.offsetMax = new Vector2 (0, 0);

			float y0 = (parentHeight - childHeight) / Fact.PHI;
			childRt.anchorMin = new Vector2 (0, 0);
			childRt.offsetMin = new Vector2 (0, y0);
			childRt.anchorMax = new Vector2 (1, 0);
			childRt.offsetMax = new Vector2 (0, y0 + childHeight);
		}
	}
}
