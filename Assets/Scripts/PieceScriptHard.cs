using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PieceScriptHard : MonoBehaviour
{
    // Start is called before the first frame update
	private Vector3 RightPosition;
	public bool InRightPosition;
	public bool Selected;
    public int flag = 0;

    void Start()
    {
    	RightPosition = transform.position;
    	transform.position = new Vector3(Random.Range(2f, 8f), Random.Range(4.5f, -4.5f));

    }

    // Update is called once per frame
    void Update()
    {
     if(Vector3.Distance(transform.position, RightPosition) < 0.5f)
     {
     	if(!Selected)
        {
            if(InRightPosition == false)
            {
                transform.position = RightPosition;
                InRightPosition = true;
                SoundManagerScript.PlaySound("benar");
                Camera.main.GetComponent<DragAndDropHard>().PlacedPieces++;
            }
        }
     }
    }
}