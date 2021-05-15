using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScript : MonoBehaviour
{
	public Animator animator;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOut(){
    	animator.SetBool("fadeOut", true);
    }

    public void FadeIn(){
    	animator.SetBool("fadeOut", false);
    }
}
