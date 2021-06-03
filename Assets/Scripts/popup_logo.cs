using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_logo : MonoBehaviour
{
	public GameObject popUp;
	public bool on;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("muncul");
		popUp.SetActive(on);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
