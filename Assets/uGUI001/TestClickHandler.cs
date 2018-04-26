using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class TestClickHandler : MonoBehaviour, IInputClickHandler {

	public void OnInputClicked(InputClickedEventData eventData){
		Debug.Log ("Clicked");
	}

}