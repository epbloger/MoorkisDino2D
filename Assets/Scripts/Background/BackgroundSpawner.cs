using UnityEngine;

namespace Moorkis.Dino2D.Background
{
    public class BackgroundSpawner : MonoBehaviour
    {
        [SerializeField] private BackgroundView _backgroundDesert;
        [SerializeField] private Transform _parent;

        public void SpawnDesert()
        {
            var t = Instantiate(_backgroundDesert, _parent);
        }
    }
}
