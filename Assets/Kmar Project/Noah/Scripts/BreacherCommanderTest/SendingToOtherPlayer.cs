using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UnityEngine.UI;

public class SendingToOtherPlayer : MonoBehaviour
{
    public Text plusText;
    public GameObject otherPlayer;

    // Start is called before the first frame update
    void Start()
    {

        if (BoltNetwork.IsServer)
        {
            otherPlayer = GameObject.FindGameObjectWithTag("Player2");
        } else
        {
            otherPlayer = GameObject.FindGameObjectWithTag("Player1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick()
    {

        BoltLog.Warn("Sending To Other Player");
    }
}
