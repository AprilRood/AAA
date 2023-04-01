using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float topLane; //top lane of the road
    public float bottomLane; //bottom lane of the road
    

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
    }
}
