﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    public string SceneName001;
    public string SceneName002;
    public string SceneName003;
    public string SceneName004;
    public string SceneName005;
    
	public void SceneStartButton001(){
        SceneManager.LoadScene(SceneName001);
	}

    public void SceneStartButton002()
    {
        SceneManager.LoadScene(SceneName002);
    }

    public void SceneStartButton003()
    {
        SceneManager.LoadScene(SceneName003);
    }

    public void SceneStartButton004()
    {
        SceneManager.LoadScene(SceneName004);
    }

    public void SceneStartButton005()
    {
        SceneManager.LoadScene(SceneName005);
    }

}
