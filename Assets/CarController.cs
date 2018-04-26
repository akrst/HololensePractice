using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CarController : MonoBehaviour, IInputClickHandler, IManipulationHandler{
	float speed = 0;
	Vector3 startPos;


	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		transform.Translate(this.speed, 0, 0);
		this.speed *= 0.98f;
	}

	public void OnInputClicked(InputClickedEventData eventData){
		/*
		Debug.Log ("Clicked");
		this.speed = 0.2f;
		*/
	}


	public void OnManipulationStarted(ManipulationEventData eventData)
	{
		Debug.Log ("Start");
		this.startPos = eventData.CumulativeDelta;
		Debug.Log (this.startPos);
	}

	public void OnManipulationUpdated(ManipulationEventData eventData)
	{

	}

	public void OnManipulationCompleted(ManipulationEventData eventData)
	{
		Debug.Log ("end");
		Vector3 endPos = eventData.CumulativeDelta;
		Debug.Log (endPos);
		float swipeLength = (endPos.x - this.startPos.x);
		Debug.Log (swipeLength);

		this.speed = swipeLength * 2.0f;
		Debug.Log (this.speed);
	}

	public void OnManipulationCanceled(ManipulationEventData eventData)
	{

	}

}