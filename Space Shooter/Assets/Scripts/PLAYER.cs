using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary 
        {
public float xMin, xMax, zMin, zMax;
        }
public class PLAYER : MonoBehaviour
{ 
    public float Speed = 10;
    public Boundary boundary;
    public float tilt;
    public GameObject shot;
    public Transform shotSpawn;

    public float fireRate = 0.5f;
    public float nextFire = 0.0f;

    public void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
    }

 private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");      

     GetComponent<Rigidbody>().rotation = Quaternion.Euler
            (
            0f,
            0f,
            GetComponent <Rigidbody>().velocity.x * -tilt 
            );
     
        GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal, 0f, moveVertical)*Speed;

        GetComponent<Rigidbody>().position = new Vector3
            ( 
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
            );
    }
}
