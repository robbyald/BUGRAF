using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class DragAndDropHard : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EndMenu;
	public GameObject SelectedPiece;
    public GameObject unlockpopUp;
    public int flag;
    public int PlacedPieces = 0;
    bool first = true;
    public static bool normalopen;
    public static int waktuHard;
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
                if(!hit.transform.GetComponent<PieceScriptHard>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PieceScriptHard>().Selected = true;
                }
        	}
        }       
        if(Input.GetMouseButtonUp(0))
        {
            SelectedPiece.GetComponent<PieceScriptHard>().Selected = false;
            SelectedPiece = null;
        }
        if(SelectedPiece != null)
        {
        	Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        if (PlacedPieces == 81 && first)
        {
            Debug.Log("sukses");
            SoundManagerScript.PlaySound("selesai");
            Camera.main.GetComponent<TimerScript>().stop = true;
            Camera.main.GetComponent<TimerScript>().timerText.color = Color.blue;
            EndMenu.SetActive(true);
            if(TimerScript.timer <= 2700)
                {
                   unlockpopUp.SetActive(true);
                }
            waktuHard = TimerScript.timer;
            first = false;
            normalopen = true;
        }
        
    }
}
