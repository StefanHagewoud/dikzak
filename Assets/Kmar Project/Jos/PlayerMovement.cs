using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 move;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        move.x = horizontal;
        move.z = vertical;

        GetComponent<Transform>().Translate(move * Time.deltaTime * speed);
    }
}
