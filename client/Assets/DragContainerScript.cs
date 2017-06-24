using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragContainerScript : MonoBehaviour {

	public GameObject clonedGameObject;

	private RectTransform rectTransform;

	// Use this for initialization
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBeginDrag(GameObject gObject, Vector2 size, PointerEventData ped){
		if (clonedGameObject != null) {
			Destroy (clonedGameObject);
			clonedGameObject = null;
		}
		if (gObject != null) {
			clonedGameObject = Instantiate (gObject);
			clonedGameObject.transform.SetParent(gameObject.transform);
			RectTransform clonedGameObjectRectTransform = clonedGameObject.GetComponent<RectTransform> ();
			clonedGameObjectRectTransform.anchorMin = Vector2.zero;
			clonedGameObjectRectTransform.offsetMin = Vector2.zero;
			clonedGameObjectRectTransform.anchorMax = Vector2.one;
			clonedGameObjectRectTransform.offsetMax = Vector2.zero;
			clonedGameObjectRectTransform.localScale = Vector3.one;
		}

		rectTransform.sizeDelta = size;
		rectTransform.position = ped.position;

		gameObject.SetActive (true);
		clonedGameObject.SetActive (true);
	}

	public void OnDrag(PointerEventData ped){
		rectTransform.position = ped.position;
	}

	public void OnEndDrag(PointerEventData ped){
		gameObject.SetActive (false);
		if (clonedGameObject != null) {
			Destroy (clonedGameObject);
			clonedGameObject = null;
		}
	}
}
