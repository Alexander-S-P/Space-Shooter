using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster_Move : MonoBehaviour
{
    public float speed; 
    public void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;

    }
}
