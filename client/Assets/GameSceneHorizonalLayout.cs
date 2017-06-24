using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneHorizonalLayout : AbstractOnSizeChangeBehaviour {
	
	public GameObject codePanel;

	public override void OnSizeChange(Rect nowRect){
//		UnityEngine.Debug.Log ("GameSceneHorizonalLayout.OnSizeChange");
		// set codePanel
		if(codePanel!=null){
			RectTransform codePanelRectTransform = codePanel.GetComponent<RectTransform> ();
			if (codePanelRectTransform != null) {
				float width = nowRect.width / Fact.PHI / Fact.PHI;
				codePanelRectTransform.anchorMin = new Vector2 (1, 0);
				codePanelRectTransform.anchorMax = new Vector2 (1, 1);
				codePanelRectTransform.offsetMin = new Vector2 (- width, 0);
				codePanelRectTransform.offsetMax = new Vector2 (0, 0);
				//UnityEngine.Debug.Log(codePanelRectTransform.rect);
			}
		}
	}
}
