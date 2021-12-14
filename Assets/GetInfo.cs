using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UdpKit.Platform.Photon;

public class GetInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && BoltNetwork.IsRunning)
        {
            var session = BoltMatchmaking.CurrentSession;

            BoltLog.Warn(session.HostName);

            var photonSession = session as PhotonSession;
            if (photonSession != null)
            {
                BoltLog.Warn("IsOpen: {0}, IsVisible: {1}", photonSession.IsOpen, photonSession.IsVisible);

                foreach (var key in photonSession.Properties.Keys)
                {
                    BoltLog.Warn("{0} = {1}", key, photonSession.Properties[key]);
                }
            }
        }
    }
}
