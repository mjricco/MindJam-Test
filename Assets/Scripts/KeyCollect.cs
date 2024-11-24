using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{

    public Animator door;

    // Start is called before the first frame update
    void Start()
    {
        door.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            door.enabled = true;
            Destroy(gameObject);
        }
    }
}
