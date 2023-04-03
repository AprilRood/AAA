using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public static float damage;
    public Image healthBar;
    public float healthAmount = 100f;
    public static HealthManager instance;

    public AudioSource playerHurt;

    void Start()
    {

    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     TakeDamage(20);
        // }
        // print("Health: " + healthAmount);
        if (healthAmount < 1) {
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void TakeDamage(int healthPerMiss)
    {
        healthAmount -= healthPerMiss;
        healthBar.fillAmount = healthAmount / 100f;
        playerHurt.Play();
    }
}