using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteCollider : MonoBehaviour
{
    public GameObject thisRoom;
    public GameObject thisCollider;

    
    //public GameObject otherRoom;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Pizdec");
        if(true)
        {
            
            float roomSize = thisRoom.GetComponent<SpriteRenderer>().size.x;
            GameObject newRoom = GameObject.Instantiate(thisRoom);
            newRoom.transform.position = thisRoom.transform.position;
            newRoom.transform.parent = thisRoom.transform.parent;
            if (thisCollider.tag == "Right")
            {
                newRoom.transform.position += new Vector3((roomSize), 0, 0);
            }
            else if (thisCollider.tag == "Left")
            {
                newRoom.transform.position -= new Vector3((roomSize), 0, 0);
            }

            thisRoom = newRoom;
            
        }
    
    }
}
