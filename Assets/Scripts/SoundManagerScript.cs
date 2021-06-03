using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
	public static AudioClip correctSound, successSound, clickSound;
	static AudioSource audioSrc;

    void Start()
    {
     correctSound = Resources.Load<AudioClip>("benar");
     successSound = Resources.Load<AudioClip>("selesai");
     clickSound = Resources.Load<AudioClip>("click");

     audioSrc = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
    	switch(clip){
    		case "benar":	
    			audioSrc.PlayOneShot(correctSound);
    			Debug.Log("benar");
    			break;
    		case "selesai":
    			audioSrc.PlayOneShot(successSound);
    			break;
    		case "click":
    			audioSrc.PlayOneShot(clickSound);
    			break;
    	}
    }
}
