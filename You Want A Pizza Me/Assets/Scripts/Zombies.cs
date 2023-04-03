using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public GameObject HealthManager;
    private bool beatPlayer;
    // public bool canBePressed;
    // public KeyCode keyToPress;
    // public int healthPerMiss = 10;

    // public GameObject HealthManager; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -10 && transform.position.x > -19) {
            Destroy(gameObject);
        }

        if(transform.position.x <= -5 && transform.position.x > -19 && !beatPlayer) {
            HealthManager.GetComponent<HealthManager>().TakeDamage(10);
            beatPlayer = true;
        }
        // if (Input.GetKeyDown(keyToPress)) {
        //     if (canBePressed) {
        //         gameObject.SetActive(false);
        //         GameManager.instance.NoteHit();
        //     } else {
        //         GameManager.instance.NoteMissed();
        //         HealthManager.GetComponent<HealthManager>().TakeDamage(10);
        //     }
        // } 
    }

    // private void OnTriggerEnter2D(Collider2D other) {
    //     // print("Zombie entered the trigger");
    //     if(other.gameObject.tag == "Player") {
    //         canBePressed = true;
    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other) {
    //     // print("Zombie exited the trigger");
    //     if(other.gameObject.tag == "Player") {
    //         canBePressed = false;
    //     }
    // }
}
