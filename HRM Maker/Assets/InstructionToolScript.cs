using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstructionToolScript : MonoBehaviour, IDragHandler {

	// Use this for initialization
	void Start () {
		UnityEngine.Debug.Log("InstructionToolScript.Start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown() {
		UnityEngine.Debug.Log("InstructionToolScript.OnMouseDown");
	}

	public void OnMouseOver() {
		UnityEngine.Debug.Log("InstructionToolScript.OnMouseOver");
	}

	public void OnDrag(UnityEngine.EventSystems.PointerEventData ped){
		UnityEngine.Debug.Log("InstructionToolScript.OnDrag");
	}
}
