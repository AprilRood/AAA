using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public bool canBePressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTripperEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            canBePressed = true;
        }

    }

    void onTripperExit2D(Collider2D other) {
        if(other.tag == "Player") {
            canBePressed = false;
        }
        
    }
}
