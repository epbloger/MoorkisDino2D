using Moorkis.Dino2D.Background;
using UnityEngine;

namespace Moorkis.Dino2D
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private BackgroundSpawner _backgroundSpawner;
        [SerializeField] private BackgroundMover _backgroundMover;

        private void Start()
        {
            BackgroundView first = _backgroundSpawner.SpawnDay();
            BackgroundView second = _backgroundSpawner.SpawnDay();
            _backgroundMover.StartMoving(first, second);
        }
    }
}

