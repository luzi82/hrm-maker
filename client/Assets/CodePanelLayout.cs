using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePanelLayout : AbstractOnSizeChangeBehaviour {

	public GameObject instructionList;
	public GameObject codeList;

	public override void OnSizeChange(Rect nowRect){
//		UnityEngine.Debug.Log ("CodePanelLayout.OnSizeChange");

//		int INSTRUCTION_TYPE_LENGTH = System.Enum.GetValues(typeof(InstructionType)).Length;
//		float INSTRUCTION_ASPECT_RATIO = 4f / (INSTRUCTION_TYPE_LENGTH + INSTRUCTION_TYPE_LENGTH * 0.25f);
		float INSTRUCTION_ASPECT_RATIO = InstructionListLayout.RATIO;

		float instructionListWidth0 = nowRect.width / Fact.PHI / Fact.PHI;
		float instructionListWidth1 = nowRect.height * INSTRUCTION_ASPECT_RATIO;
		float instructionListWidth = Mathf.Min (instructionListWidth0, instructionListWidth1);
		float instructionListHeight = instructionListWidth / INSTRUCTION_ASPECT_RATIO;

		if (instructionList != null) {
			RectTransform instructionListRectTransform = instructionList.GetComponent<RectTransform> ();
			if (instructionListRectTransform != null) {
				instructionListRectTransform.anchorMin = new Vector2 (0, 0.5f);
				instructionListRectTransform.offsetMin = new Vector2 (0, -instructionListHeight / 2);
				instructionListRectTransform.anchorMax = new Vector2 (0, 0.5f);
				instructionListRectTransform.offsetMax = new Vector2 (instructionListWidth, instructionListHeight / 2);
			}
		}

		if (codeList != null) {
			RectTransform codeListRectTransform = codeList.GetComponent<RectTransform> ();
			if (codeListRectTransform != null) {
				codeListRectTransform.anchorMin = new Vector2 (0, 0);
				codeListRectTransform.offsetMin = new Vector2 (instructionListWidth, 0);
				codeListRectTransform.anchorMax = new Vector2 (1, 1);
				codeListRectTransform.offsetMax = new Vector2 (0, 0);
			}
		}
	}
}
