using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstructionSourceBehaviour : MonoBehaviour {

	public GameObject text;
	public GameObject graphic;
	public GameObject dragContainer;

	private DragContainerScript dragContainerScript;

	// Use this for initialization
	void Start () {
		EventTrigger trigger = GetComponent<EventTrigger>();

		EventTrigger.Entry entry;
		entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.BeginDrag;
		entry.callback.AddListener((data) => { OnBeginDrag((PointerEventData)data); });
		trigger.triggers.Add(entry);
		entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.Drag;
		entry.callback.AddListener((data) => { OnDrag((PointerEventData)data); });
		trigger.triggers.Add(entry);
		entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.EndDrag;
		entry.callback.AddListener((data) => { OnEndDrag((PointerEventData)data); });
		trigger.triggers.Add(entry);

		dragContainerScript = dragContainer.GetComponent<DragContainerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	private RectTransform dragContainerRectTransform;

	public void OnBeginDrag(PointerEventData ped){
//		UnityEngine.Debug.Log ("OnBeginDrag");
		RectTransform rt = GetComponent<RectTransform> ();
//		UnityEngine.Debug.Log ("rect="+rt.rect);
//		dragContainer.SetActive (true);
//		if (dragContainerRectTransform == null) {
//			dragContainerRectTransform = dragContainer.GetComponent<RectTransform> ();
//		}
//		dragContainerRectTransform.sizeDelta = new Vector2 (rt.rect.width, rt.rect.height);
//		dragContainerRectTransform.position = ped.position;

		dragContainerScript.OnBeginDrag (graphic, rt.rect.size, ped);
	}
	public void OnDrag(PointerEventData ped){
		dragContainerScript.OnDrag (ped);
//		UnityEngine.Debug.Log ("OnDrag");
//		dragContainerRectTransform.position = ped.position;
	}
	public void OnEndDrag(PointerEventData ped){
		dragContainerScript.OnEndDrag (ped);
//		UnityEngine.Debug.Log ("OnEndDrag");
//		dragContainer.SetActive (false);
//		dragContainer.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0,0);
	}
}
