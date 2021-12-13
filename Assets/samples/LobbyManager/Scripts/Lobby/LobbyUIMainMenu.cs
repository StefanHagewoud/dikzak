using System;
using UnityEngine;
using UnityEngine.UI;

namespace Bolt.Samples.Photon.Lobby
{
    public class LobbyUIMainMenu : MonoBehaviour, ILobbyUI
    {
        public event Action JoinRoomWithInputOnClick;
        public event Action OnCreateButtonClick;
        public event Action OnBrowseServerClick;
        public event Action OnJoinRandomClick;

        public string matchName;
        
        [Header("Server UI")]
        //[SerializeField] private InputField matchNameInput;
        [SerializeField] private Button createRoomButton;

        [Header("Client UI")]
        [SerializeField] private Button browseServersButton;
        [SerializeField] private Button joinRandomButton;

        [Header("Join Room With Input")]
        [SerializeField] private Button joinRoomWithInput;
        public string sessionText;
        [SerializeField] private InputField roomInput;
        [SerializeField] private int numberGenerator;

        [Header("Code to Main Menu")]
        public GameObject objWithMainMenuScript;


        void Start()
        {
            roomInput.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        }

        private void OnDestroy()
        {
            roomInput.onValueChanged.RemoveAllListeners();
        }
        public void ValueChangeCheck()
        {
            Debug.Log("Value Changed");
            sessionText = roomInput.text;

            objWithMainMenuScript.GetComponent<LobbyManager2>().mainMenuString = sessionText;
        }
        public void OnEnable()
        {

            joinRoomWithInput.onClick.RemoveAllListeners();
            joinRoomWithInput.onClick.AddListener(() =>
            {
                if (JoinRoomWithInputOnClick != null) JoinRoomWithInputOnClick() ;
            });

            createRoomButton.onClick.RemoveAllListeners();
            createRoomButton.onClick.AddListener(() =>
            {
                if (OnCreateButtonClick != null) OnCreateButtonClick();
            });
            
            browseServersButton.onClick.RemoveAllListeners();
            browseServersButton.onClick.AddListener(() =>
            {
                if (OnBrowseServerClick != null) OnBrowseServerClick();
            });
            
            joinRandomButton.onClick.RemoveAllListeners();
            joinRandomButton.onClick.AddListener(() =>
            {
                if (OnJoinRandomClick != null) OnJoinRandomClick();
            });
        }

        public void ToggleVisibility(bool visible)
        {
            gameObject.SetActive(visible);
        }
    }
}
