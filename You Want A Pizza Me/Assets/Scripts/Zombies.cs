using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) {
            if (canBePressed) {
                gameObject.SetActive(false);
                GameManager.instance.NoteHit();
            } else {
                GameManager.instance.NoteMissed();
            }
        } 
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // print("Zombie entered the trigger");
        if(other.gameObject.tag == "Player") {
            canBePressed = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        // print("Zombie exited the trigger");
        if(other.gameObject.tag == "Player") {
            canBePressed = false;
        }
        
    }
}
