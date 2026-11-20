using UnityEngine;

namespace Moorkis.Dino2D.Player
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerPrefab;
        [SerializeField] private Transform _parent;

        public void SpawnPlayer()
        {
            Instantiate(_playerPrefab, _parent);
        }
    }
}

