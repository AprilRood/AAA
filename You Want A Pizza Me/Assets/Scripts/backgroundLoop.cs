using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundLoop : MonoBehaviour
{
    //started on this in case we need the background to loop, but realizing that we might not need it at all
    public GameObject[] levels;
    private Camera mainCamera;
    private Vector2 screenBounds;

    void Start(){
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        //this lets us have multiple background pieces that will all be looped
        foreach(GameObject obj in levels){
            loadChildObjects(obj);
        }
    }

    //gets the width of the backgrounds, creates a clone and places it to the right of the original
    void loadChildObjects(GameObject obj){
        // Debug.Log(obj.name);
        float objectWidth = obj.GetComponent<SpriteRenderer>().bounds.size.x;
        int childsNeeded = (int)Mathf.Ceil(screenBounds.x * 2 / objectWidth);
        GameObject clone = Instantiate(obj) as GameObject;
        for (int i = 0; i <= childsNeeded; i++){
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
            c.transform.position = new Vector3(objectWidth * i, obj.transform.position.y, obj.transform.position.z);
            c.name = obj.name + i;
        }
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }

}
