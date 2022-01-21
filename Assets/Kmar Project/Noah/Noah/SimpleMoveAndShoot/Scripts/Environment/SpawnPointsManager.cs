using UnityEngine;

namespace Bolt.Samples.MoveAndShoot
{
	public class SpawnPointsManager : MonoBehaviour
	{
		[SerializeField] private Transform[] spawnPoints;

		private static SpawnPointsManager _instance;

		private void Awake()
		{
			if (_instance != null)
			{
				Destroy(_instance.gameObject);
			}

			_instance = this;
		}

		public static Vector3 GetSpawnPosition()
		{
			var position = Vector3.zero;

			if (_instance != null && _instance.spawnPoints != null && _instance.spawnPoints.Length > 0)
			{
				var pos = Random.Range(0, _instance.spawnPoints.Length);
				position = _instance.spawnPoints[0].position;
			}

			return position;
		}
		public static Vector3 GetSpawnPosition2()
		{
			var position = Vector3.zero;

			if (_instance != null && _instance.spawnPoints != null && _instance.spawnPoints.Length > 0)
			{
				var pos = Random.Range(0, _instance.spawnPoints.Length);
				position = _instance.spawnPoints[1].position;
			}

			return position;
		}
	}
}
