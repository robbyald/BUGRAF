using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class DragAndDrop : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EndMenu;
    public GameObject unlockpopUp;
	public GameObject SelectedPiece;
    public int flag;
    public int PlacedPieces = 0;
    bool first = true;
    public static bool normalopen;
    public static int indexLvl;
    public static int waktuEasy;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit  = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if(Input.GetMouseButtonDown(0))
        {
        	
        	if(hit.transform.CompareTag("pieces"))
        	{
                if(!hit.transform.GetComponent<PieceScript>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PieceScript>().Selected = true;
                }
        	}
        }       
        if(Input.GetMouseButtonUp(0))
        {
            SelectedPiece.GetComponent<PieceScript>().Selected = false;
            SelectedPiece = null;
        }
        if(SelectedPiece != null)
        {
        	Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        if (PlacedPieces == 9 && first)
        {
            Debug.Log("sukses");
            SoundManagerScript.PlaySound("selesai");
            Camera.main.GetComponent<TimerScript>().stop = true;
            Camera.main.GetComponent<TimerScript>().timerText.color = Color.blue;
            EndMenu.SetActive(true);
                if(TimerScript.timer <= 15)
                {
                   unlockpopUp.SetActive(true);
                }
            waktuEasy = TimerScript.timer;
            first = false;
            normalopen = true;
            indexLvl = 1;
        }
        
    }
}
