using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UdpKit;
using UdpKit.Platform.Photon;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetRoomNameScript : MonoBehaviour
{
    [SerializeField] private Text hostNameText;
    void Start()   
    {
        var session = BoltMatchmaking.CurrentSession;

        BoltLog.Warn(session.HostName);
        hostNameText.text = session.HostName;

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
    