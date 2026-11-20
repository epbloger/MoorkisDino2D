using UnityEngine;

namespace Moorkis.Dino2D.Background
{
    public class BackgroundSpawner : MonoBehaviour
    {
        [SerializeField] private BackgroundView _backgroundDay;
        [SerializeField] private Transform _parent;

        public BackgroundView SpawnDay()
        {
            return Instantiate(_backgroundDay, _parent);
        }
    }
}
