using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public Beats_Manager theBS;
    public static GameManager instance;

    public int playerHealth = 100;
    public int healthPerMiss = 10;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        theBS = FindObjectOfType<Beats_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying) {
            if (Input.anyKeyDown) {
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit() {
        Debug.Log("Hit on time");
    }

    public void NoteMissed() {
        Debug.Log("Missed Note");
        playerHealth -= healthPerMiss;
    }

}
