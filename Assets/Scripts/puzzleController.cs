using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleController : MonoBehaviour
{

    public GameObject level;
    public FadingScript fading;
    
    public int neededActions = 3;
    public int currentActions = 0;
    public bool isComplete = false;
    public bool isDark = false;

    void Start()
    {
        fading = FindObjectOfType<FadingScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButtonDown(1)){
            if(!isDark){
                fading.FadeOut();
                isDark = true;
            }
            else {
                fading.FadeIn();
                isDark=false;
            }

        }

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
                    // fading.FadeOut();
                    Destroy(level);

                }

                Destroy(GameObject.Find(hitCollider.name));
            }
        }
    }
}
