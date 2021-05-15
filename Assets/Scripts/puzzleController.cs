using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleController : MonoBehaviour
{

    public GameObject level;
    
    public int neededActions = 3;
    public int currentActions = 0;
    public bool isComplete = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));
            if (hitCollider != null && hitCollider.CompareTag("KeyItem"))
            {
                currentActions++;
                Debug.Log("Current actions: " + currentActions);
                if (currentActions == neededActions)
                {
                    isComplete = true;
                    Debug.Log("Level Complete");
                    Destroy(level);
                }

                Destroy(GameObject.Find(hitCollider.name));
            }
        }
    }
}
