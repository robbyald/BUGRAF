using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlSelect : MonoBehaviour
{	
    public Button[] lvlB;
    public GameObject[] lockdifficulty;
    public bool finishEasy, finishNormal;
    public int lvlIndex1,lvlIndex2;
	 // Start is called before the first frame update
    void Start()
    {
        // int levelAt = PlayerPrefs.GetInt("levelAt", 5);

        finishEasy = DragAndDrop.normalopen;
        lvlIndex1 = DragAndDrop.indexLvl;
        Debug.Log(finishEasy + " " + lvlIndex1);
        finishNormal = DragAndDropNormal.normalopen;
        lvlIndex2 = DragAndDropNormal.indexLvl;

        for (var i = 1; i < lvlB.Length; i++)
        {
            lvlB[i].interactable = false;
        }

        if( finishEasy && lvlIndex1 == 1){
            lvlB[lvlIndex1].interactable = true;
            lockdifficulty[0].SetActive(false);
        }
        if( finishNormal && lvlIndex2 == 2){
            lvlB[lvlIndex2].interactable = true;
            lockdifficulty[1].SetActive(false);

        }
    }

}
