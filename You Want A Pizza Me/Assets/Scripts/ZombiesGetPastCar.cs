using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesGetPastCar : MonoBehaviour
{
    public GameObject HealthManager; 

    // Update is called once per frame
    void Update()
    {
        // HealthManager.GetComponent<HealthManager>().TakeDamage(10);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // print("Zombie entered trigger area");
        if(other.gameObject.tag == "zombie") {
            HealthManager.GetComponent<HealthManager>().TakeDamage(10);
        }
    }
}
