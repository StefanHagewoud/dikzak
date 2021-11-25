using System;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using UnityEngine;
using UnityEngine.UI;

namespace Bolt.Samples.MoveAndShoot
{
	public class MoveAndShoot_Menu : GlobalEventListener
	{
		// UI
		[Header("Buttons")]
		[SerializeField] private Button startServerButton;
		[SerializeField] private Button joinRandomButton;
		[SerializeField] private Button joinSessionButton;
		[SerializeField] private Button browseServersButton;

		[Header("Match Settings")]
		[SerializeField] private string gameLevel;
		public InputField mainInputField;
		public string sessionText;
		public string matchName;
		[SerializeField] private int numberGenerator;
		[SerializeField] private Text moeilijkheidsGraadText;

		void Awake()
		{
			Application.targetFrameRate = 60;
		}

		void Start()
		{
			startServerButton.onClick.AddListener(StartServer);
			joinRandomButton.onClick.AddListener(StartClient);
			joinSessionButton.onClick.AddListener(StartClient);
			mainInputField.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
			numberGenerator = UnityEngine.Random.Range(1000, 99999);
			matchName = numberGenerator.ToString();
		} 
        private void OnDestroy()
		{
			startServerButton.onClick.RemoveAllListeners();
			joinRandomButton.onClick.RemoveAllListeners();
			joinSessionButton.onClick.RemoveAllListeners();
			mainInputField.onValueChanged.RemoveAllListeners();
		}

		public void ValueChangeCheck()
		{
			Debug.Log("Value Changed");
			sessionText = mainInputField.text;
		}
		private void StartServer()
		{
			BoltLauncher.StartServer();
		}

		private void StartClient()
		{
			BoltLauncher.StartClient();
		}
		public override void BoltStartBegin()
		{
			BoltNetwork.RegisterTokenClass<HitInfo>();
		}

		public override void BoltStartDone()
		{
			if (BoltNetwork.IsServer)
			{
				var id = Guid.NewGuid().ToString().Split('-')[0];
				//var matchName = string.Format("{0} - {1}", id, gameLevel);

				BoltMatchmaking.CreateSession(
					sessionID: matchName,
					sceneToLoad: gameLevel
				);
			}
			else if (BoltNetwork.IsClient)
			{
				if (sessionText == "")
				{
					BoltMatchmaking.JoinRandomSession();
					Debug.Log("Failed");
					return;
				}
				else
				{
					BoltMatchmaking.JoinSession(sessionText);
					Debug.Log("Succeeded");
				}
			}
		}
		public void FirstLevel()
        {
			gameLevel = ("Makkelijk");
			moeilijkheidsGraadText.text = string.Format("Moeilijkheidsgraad : ", gameLevel);
        }
		public void SecondLevel()
		{
			gameLevel = ("Gemiddeld");
			moeilijkheidsGraadText.text = string.Format("Moeilijkheidsgraad: ", gameLevel);
		}
		public void ThirdLevel()
		{
			gameLevel = ("Moeilijk");
			moeilijkheidsGraadText.text = string.Format("Moeilijkheidsgraad : ", gameLevel);
		}
		public void TutorialLevel()
		{
			gameLevel = ("Tutorial");
			moeilijkheidsGraadText.text = string.Format("Moeilijkheidsgraad : ", gameLevel);
		}
	}
}