using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public float topLane; //top lane of the road
    public float bottomLane; //bottom lane of the road

    public bool canBePressed;
    public KeyCode keyToPress;
    public int healthPerMiss = 10;

    public GameObject HealthManager; 
    private GameObject zombieToKill;

    public AudioSource hitZombie;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves the car up and down on the road
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            gameObject.transform.position = new Vector2 (transform.position.x, topLane);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            gameObject.transform.position = new Vector2 (transform.position.x, bottomLane);
        }

        if (Input.GetKeyDown(keyToPress)) {
            if (canBePressed) {
                Destroy(zombieToKill);
                hitZombie.Play();
                GameManager.instance.NoteHit();
            } else {
                GameManager.instance.NoteMissed();
                HealthManager.GetComponent<HealthManager>().TakeDamage(10);
            }
        } 
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // print("Zombie entered the trigger");
        if(other.gameObject.tag == "zombie") {
            canBePressed = true;
            zombieToKill = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        // print("Zombie exited the trigger");
        if(other.gameObject.tag == "zombie") {
            canBePressed = false;
        }
    }
}
