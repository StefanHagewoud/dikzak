using Photon.Bolt;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Bolt.Samples.MoveAndShoot
{
	[BoltGlobalBehaviour(BoltNetworkModes.Server, "Makkelijk", "Normaal", "Moeilijk", "Test", "Tutorial")]
	public class MakkelijkNetworkCalllBacks : GlobalEventListener
	{
		public override void SceneLoadLocalDone(string scene, IProtocolToken token)
		{
			Debug.Log("Spawning");
			var entity = BoltNetwork.Instantiate(BoltPrefabs.BreacherPlayer, SpawnPointsManager.GetSpawnPosition(),
				Quaternion.identity);

			entity.TakeControl();
		}

		public override void SceneLoadRemoteDone(BoltConnection connection, IProtocolToken token)
		{
			var entity = BoltNetwork.Instantiate(BoltPrefabs.MoveAndShootPlayer, SpawnPointsManager.GetSpawnPosition(),
				Quaternion.identity);

			entity.AssignControl(connection);
		}
	}
}
