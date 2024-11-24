using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;

public class KeypadHandler : MonoBehaviour
{
    
    public string answer;
    public GameObject player;
    public GameObject door;
    public TMP_Text inputfield;
    public GameObject maincanvas;

    void Start()
    {
        
    }

    public void Exit()
    {
        maincanvas.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
    }

    public void OnSubmitted()
    {
        if (inputfield.text == answer){
            Destroy(door);
            Exit();
        } else {
            inputfield.text = "";
        }
    }
}
