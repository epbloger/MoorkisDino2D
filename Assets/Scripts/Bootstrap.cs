using Moorkis.Dino2D.Background;
using UnityEngine;

namespace Moorkis.Dino2D
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private BackgroundSpawner _backgroundSpawner;
        [SerializeField] private BackgroundMover _BackgroundMover;

        private void Start()
        {
            _backgroundSpawner.SpawnDesert();
        }
    }
}

