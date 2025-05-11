using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NezukoAnimControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) 
        {
            anim.SetTrigger("isRun");
        }
        else
        {
            anim.SetTrigger("isIdle");
        }


    }
}
