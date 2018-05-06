using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    

	// Use this for initialization
	void Start () {  

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
	public void SceneStartButton001(){
        //SceneManager.UnloadSceneAsync("StartScene");
        SceneManager.LoadScene("uGUI002");
        //Scene uGUI002 = SceneManager.GetSceneByName("uGUI002");
        //SceneManager.SetActiveScene(uGUI002);
	}
    
	public void SceneStartButton002(){
        SceneManager.LoadScene("TrackingUI3DObjectChange");
        //Scene TrackingUI = SceneManager.GetSceneByName("TrackingUI3DObjectChange");
        //SceneManager.SetActiveScene(TrackingUI);
    }

    public void SceneStartButton003(){
        SceneManager.LoadScene("Unity5text4");
        //Scene Unity5text4 = SceneManager.GetSceneByName("TrackingUI3DObjectChange");
        //SceneManager.SetActiveScene(Unity5text4);
    }
    
}
