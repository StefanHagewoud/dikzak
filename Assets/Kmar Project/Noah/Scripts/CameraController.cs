using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float smoothTime = 0.3f;
    public Transform player;

    private Vector3 velocity = new Vector3(0, 0, 0);

    public Vector3 offset;

    // Update is called once per frame

    public void Start()
    {
        
    }

    public void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("BreacherPlayer(Clone)").transform;
        }

        if (player)
        {
            Vector3 targetPos = player.transform.position + offset;

            //Keep camera height the same
            targetPos.y = transform.position.y;

            //targetPos = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * m_LerpSpeed);
            targetPos = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

            this.gameObject.transform.position = targetPos;

        }
    }
}