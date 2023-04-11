using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 30;
    public Rigidbody rb;
    [SerializeField]private float rot = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("forward");
            rb.velocity = new Vector3(0, 0, 1) * speed;
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("forward");
            rb.transform.Rotate(new Vector3(0, -rot, 0));   
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("forward");
            rb.transform.Rotate(new Vector3(0, rot, 0));   
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("forward");
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }
    }
}
