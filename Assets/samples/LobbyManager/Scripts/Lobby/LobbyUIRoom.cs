using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Photon.Bolt;

namespace Bolt.Samples.Photon.Lobby
{
    //List of players in the lobby
    public class LobbyUIRoom : MonoBehaviour, ILobbyUI
    {
        [SerializeField] private RectTransform playerListContentTransform;
        [SerializeField] private Transform addButtonRow;

        private List<LobbyPlayer> _players = new List<LobbyPlayer>();

        [SerializeField] private Button[] moeilijkheidsgraadButtons;
        public string selectedLevel;
        public Text onScreenSelectedLevelDisplay;

        public GameObject mainMenuScriptObjt;
        

        public void Awake()
        {
            selectedLevel = "Makkelijk";
            onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Makkelijk");
            mainMenuScriptObjt.GetComponent<LobbyManager2>().sceneThatGettingLoaded = selectedLevel;
        }

        public IEnumerable<LobbyPlayer> AllPlayers
        {
            get { return _players; }
        }

        public bool ServerIsPlaying
        {
            get { return ServerPlayer != null; }
        }

        public LobbyPlayer ServerPlayer
        {
            get;
            set;
        }

        public LobbyPlayer CreatePlayer()
        {
            if (!BoltNetwork.IsClient) { return null; }

            return null;
        }

        public void OnEnable()
        {
            _players = new List<LobbyPlayer>();
        }

        public void ResetUI()
        {
            foreach (var player in _players)
            {
                if (player.entity.IsAttached && player.entity.IsOwner)
                {
                    BoltNetwork.Destroy(player.gameObject);
                }
            }
        }

        public void AddPlayer(LobbyPlayer player)
        {
            if (player == null) { return; }

            if (_players.Contains(player))
                return;

            _players.Add(player);
            player.transform.SetParent(playerListContentTransform, false);
            
            addButtonRow.transform.SetAsLastSibling();
            PlayerListModified();
        }

		public void RemovePlayer(LobbyPlayer player)
		{
			if (player == null) { return; }

            if (_players.Contains(player))
			{
                _players.Remove(player);
				PlayerListModified();
			}
        }

        public void PlayerListModified()
        {
            int i = 0;
            foreach (LobbyPlayer p in _players)
            {
                p.OnPlayerListChanged(i);
                ++i; 

            }
        }

        public void ToggleVisibility(bool visible)
        {
            gameObject.SetActive(visible);
        }

        public void FirstLevel()
        {
            selectedLevel = ("Makkelijk");
            onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Makkelijk");
            mainMenuScriptObjt.GetComponent<LobbyManager2>().sceneThatGettingLoaded = selectedLevel;

        }
        public void SecondLevel()
        {
            selectedLevel = ("Gemiddeld");
            onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Gemiddeld");
            mainMenuScriptObjt.GetComponent<LobbyManager2>().sceneThatGettingLoaded = selectedLevel;
        }
        public void ThirdLevel()
        {
            selectedLevel = ("Moeilijk");
            onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Moeilijk");
            mainMenuScriptObjt.GetComponent<LobbyManager2>().sceneThatGettingLoaded = selectedLevel;
        }
        public void TutorialLevel()
        {
            selectedLevel = ("Tutorial");
            onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Tutorial");
            mainMenuScriptObjt.GetComponent<LobbyManager2>().sceneThatGettingLoaded = selectedLevel;
        }
    }
}
