using UnityEngine;

namespace Moorkis.Dino2D.Background
{
    public class BackgroundSpawner : MonoBehaviour
    {
        [SerializeField] private BackgroundView _backgroundDesert;
        [SerializeField] private Transform _parent;

        public BackgroundView SpawnDesert()
        {
            return Instantiate(_backgroundDesert, _parent);
        }
    }
}
