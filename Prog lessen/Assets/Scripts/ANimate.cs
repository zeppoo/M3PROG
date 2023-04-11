using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANimate : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            //Reset the "Crouch" trigger
            anim.ResetTrigger("click");
            anim.SetTrigger("click");

        }
    }
}
