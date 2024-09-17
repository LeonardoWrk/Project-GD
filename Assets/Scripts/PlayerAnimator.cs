using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //references
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aaaaaaaaaaaaaa");
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0) 
        {
            am.SetBool("Move", true);

            SpriteDiretionChecker();
        }
        else
        {
            am.SetBool("Move", false);
        }
    }

    void SpriteDiretionChecker()
    {
        if (pm.lastHorizontalVector < 0)
        {
            sr.flipX = true;
        }
        else 
        {
            sr.flipX = false;
        }
    }
}
