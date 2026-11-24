using UnityEngine;

namespace Moorkis.Dino2D.Player
{
    public class PlayerRunAnimation : MonoBehaviour
    {
        [SerializeField] private PlayerView _view;
        [SerializeField] private Sprite[] _frames;

        private const float TimeAnimation = 0.12f;
        
        private float _timer;
        private int _frameIndex;

        private void Update()
        {
            _timer += Time.deltaTime;

            if(_timer < TimeAnimation)
            {
                return;
            }

            _timer -= TimeAnimation;
            ShowNextFrame();
        }

        public void ShowNextFrame()
        {
            _frameIndex++;
            
            if(_frameIndex >= _frames.Length)
            {
                _frameIndex = 0;
            }

            _view.ShowFrame(_frames[_frameIndex]);
        }
    }
}

