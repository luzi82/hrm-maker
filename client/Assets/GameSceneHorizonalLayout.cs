using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GameSceneHorizonalLayout : MonoBehaviour {

	public GameObject codePanel;

	private RectTransform rectTransform{
		get{
			if (_rectTransform == null)
				_rectTransform = GetComponent<RectTransform> ();
			return _rectTransform;
		}
	}
	private RectTransform _rectTransform;
	private Rect lastRect;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Rect nowRect = rectTransform.rect;
		if (lastRect == nowRect)
			return;
		UnityEngine.Debug.Log (nowRect);

		// cal instruction height
		float instructionHeight0 = nowRect.height/(INSTRUCTION_ITEM_COUNT+(INSTRUCTION_ITEM_COUNT-1)*0.25f);
		float instructionHeight1 = nowRect.width / PHI / PHI / PHI / PHI / 4f;
		float instructionHeight = Mathf.Min (instructionHeight0, instructionHeight1);

		// set codePanel
		if(codePanel!=null){
			RectTransform codePanelRectTransform = codePanel.GetComponent<RectTransform> ();
			if (codePanelRectTransform != null) {
				float width = instructionHeight * 4f * PHI * PHI;
				codePanelRectTransform.anchorMin = new Vector2 (1, 0);
				codePanelRectTransform.anchorMax = new Vector2 (1, 1);
				codePanelRectTransform.offsetMin = new Vector2 (- width, 0);
				codePanelRectTransform.offsetMax = new Vector2 (0, 0);
//				codePanelRectTransform.localScale = new Vector3 (width, nowRect.height, 0);
//				codePanelRectTransform.localPosition = new Vector3 (nowRect.width - width, 0, 0);
//				codePanelRectTransform.rect = Rect (
//					nowRect.width - width, 0,
//					width, nowRect.height
//				);
				UnityEngine.Debug.Log(codePanelRectTransform.rect);
			}
		}

		lastRect = nowRect;
	}

	private const int INSTRUCTION_ITEM_COUNT = 16;

	private float PHI = (1f+Mathf.Sqrt(5f))/2f;
}
