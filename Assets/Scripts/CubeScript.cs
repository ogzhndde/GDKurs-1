using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Transform cubeTransform;
    public Rigidbody cubeRb;
    public BoxCollider col;

    public Vector3 move;

    public float speed;
    public float sens;

    public FloatingJoystick floatingJoystick;

    public int Score;


    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        cubeTransform = GetComponent<Transform>();

    }


    void Update()
    {
        cubeTransform.position += new Vector3(floatingJoystick.Horizontal * sens, 0, speed);

        // Mathf.Clamp

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Score -= 1;
            Destroy(other.gameObject);
        }

        if (other.tag == "Collactable")
        {
            Score += 1;
            Destroy(other.gameObject);
        }
    }



}
