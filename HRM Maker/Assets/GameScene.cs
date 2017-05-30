using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour {

	public Camera mCamera;

	// Use this for initialization
	void Start () {
		UnityEngine.Debug.Log("GameScene.Start");
		UnityEngine.Debug.Log("camera.aspect.ToString: "+mCamera.aspect.ToString());
	}
	
	// Update is called once per frame
	void Update () {
//		UnityEngine.Debug.Log("GameScene.Update");
	}
}
