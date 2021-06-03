using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomImage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objectDisable;
    bool isVisible = true;
    int random;
    void Start()
    {
        random = Random.Range(0,3);
        objectDisable[random].SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
}
