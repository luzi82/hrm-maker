using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionListLayout : AbstractOnSizeChangeBehaviour {

	public static float BORDER = 0.125f;
	public static float SPACE = 0.125f;
	public static float ITEM_RATIO = 3f;

	public static float RATIO_WIDTH = 2*BORDER+ITEM_RATIO;
	public static float RATIO_HEIGHT = 2 * BORDER + InstructionTypeConst.INSTRUCTION_TYPE_LENGTH + (InstructionTypeConst.INSTRUCTION_TYPE_LENGTH - 1) * SPACE;
	public static float RATIO = RATIO_WIDTH / RATIO_HEIGHT;

	public override void OnSizeChange(Rect nowRect){
		InstructionListItemGen ilig = GetComponent<InstructionListItemGen> ();
		if (ilig.instructionItemList != null){
			for (int idx = 0; idx < ilig.instructionItemList.Length; ++idx) {
				GameObject instructionItemGO = ilig.instructionItemList [idx];
				RectTransform instructionItemGameObjectRectTransform = instructionItemGO.GetComponent<RectTransform> ();
				int posIdx = InstructionTypeConst.INSTRUCTION_TYPE_LENGTH - 1 - idx;
				instructionItemGameObjectRectTransform.anchorMin = new Vector2 (BORDER/RATIO_WIDTH, (BORDER+(SPACE+1)*posIdx)/RATIO_HEIGHT );
				instructionItemGameObjectRectTransform.offsetMin = new Vector2 (0, 0);
				instructionItemGameObjectRectTransform.anchorMax = new Vector2 (1-BORDER/RATIO_WIDTH, (BORDER+(SPACE+1)*posIdx+1)/RATIO_HEIGHT);
				instructionItemGameObjectRectTransform.offsetMax = new Vector2 (0, 0);
			}
		}
//		if (ilig.rawInstructionItem0 != null) {
//			RectTransform rt = ilig.rawInstructionItem0.GetComponent<RectTransform> ();
//			int posIdx = InstructionTypeConst.INSTRUCTION_TYPE_LENGTH - 1;
//			rt.anchorMin = new Vector2 (BORDER/RATIO_WIDTH, (BORDER+(SPACE+1)*posIdx)/RATIO_HEIGHT );
//			rt.offsetMin = new Vector2 (0, 0);
//			rt.anchorMax = new Vector2 (1-BORDER/RATIO_WIDTH, (BORDER+(SPACE+1)*posIdx+1)/RATIO_HEIGHT);
//			rt.offsetMax = new Vector2 (0, 0);
//		}
	}

}
