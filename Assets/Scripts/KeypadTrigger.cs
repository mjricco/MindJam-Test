using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class KeypadTrigger : MonoBehaviour
{
    public GameObject keypadOBJ;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            keypadOBJ.SetActive(true);
            player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            keypadOBJ.GetComponent<KeypadHandler>().Exit();
        }
    }

}

