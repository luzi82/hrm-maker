using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionListItemGen : MonoBehaviour
{

	public GameObject rawInstructionItem0;

	public GameObject[] instructionItemList{
		get{
			return _instructionItemList;
		}
	}
	private GameObject[] _instructionItemList;


	// Use this for initialization
	void Start ()
	{
		int INSTRUCTION_TYPE_LENGTH = System.Enum.GetValues (typeof(InstructionType)).Length;
		_instructionItemList = new GameObject[INSTRUCTION_TYPE_LENGTH];
		for (int idx = 0; idx < INSTRUCTION_TYPE_LENGTH; ++idx) {
			InstructionType it = (InstructionType) System.Enum.GetValues (typeof(InstructionType)).GetValue(idx);
			GameObject iil = _instructionItemList [idx] = Object.Instantiate (rawInstructionItem0);
			iil.transform.SetParent (gameObject.transform);
			iil.transform.localScale = Vector3.one;
			iil.name = it.ToString ();

			InstructionSourceBehaviour isb = iil.GetComponent<InstructionSourceBehaviour> ();
			if (isb != null) {
				UnityEngine.UI.Text text = isb.text.GetComponent<UnityEngine.UI.Text>();
				text.text = it.ToString ();
			}
		}

		rawInstructionItem0.SetActive (false);
		foreach (GameObject instructionItem in _instructionItemList) {
			instructionItem.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

}
