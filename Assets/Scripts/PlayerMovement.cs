using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{	
	public float moveSpeed = 1f;
	// public Vector3 initialPosition = new Vector3(-1.529056, -2.807506, 0);
	public float initialX = -1.529056f;
	public float initialY = -16.23677f;
	public float initialZ = 0f;

	public Animator animator;
	// public Room room;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", movement);
        //Debug.Log("speed: "+ movement);
        if(movement > 0.1){
        	animator.SetBool("moveLeft", false);
        	animator.SetBool("moveRight", true);
        }

        if(movement < 0.1){
        	animator.SetBool("moveLeft", true);
        	animator.SetBool("moveRight", false);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;
    }
}
