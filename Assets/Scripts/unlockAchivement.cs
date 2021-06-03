using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockAchivement : MonoBehaviour
{
    // Start is called before the first frame update
    // Unlock
    public GameObject[] lockscreen;
    public int waktuUnlockEasy, waktuUnlockNormal, waktuUnlockHard;
    public bool isUnlockeasy, isUnlockNormal, isUnlockHard;
    void Start()
    {
        waktuUnlockEasy = DragAndDrop.waktuEasy;
        // Waktu level Easy 15 detik
        isUnlockeasy = DragAndDrop.normalopen;
        if(waktuUnlockEasy <= 15 && isUnlockeasy)
        {
            lockscreen[0].SetActive(false);
        }

        // Waktu level Normal 3 menit
        waktuUnlockNormal = DragAndDropNormal.waktuNormal;
        isUnlockNormal = DragAndDropNormal.normalopen;
        if(waktuUnlockNormal <= 180 && isUnlockNormal){
            lockscreen[1].SetActive(false);
        }

        // Waktu level Hard 45 menit
        waktuUnlockHard = DragAndDropHard.waktuHard;
        isUnlockHard = DragAndDropHard.normalopen;
        if(waktuUnlockHard <= 2700 && isUnlockHard){
            lockscreen[1].SetActive(false);
        }
     }


    // Update is called once per frame
    void Update()
    {
        
    }
}
