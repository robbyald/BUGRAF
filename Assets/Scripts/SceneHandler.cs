﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToScene(string name){
        Debug.Log("Pindah");
        SceneManager.LoadScene(name);
        //SoundManagerScript.PlaySound("click");
    	
        
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
