using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class test : MonoBehaviour, IFocusable {
	public GameObject cube; 

	public void OnFocusEnter(){
		Debug.Log ("Enter");
	}

	public void OnFocusExit(){
		Debug.Log ("Exit");
	}
}
