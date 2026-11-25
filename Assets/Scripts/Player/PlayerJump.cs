using System;
using UnityEngine;

namespace Moorkis.Dino2D.Player
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private RectTransform _rect;
        [SerializeField] private PlayerView _view;
        [SerializeField] private PlayerRunAnimation _runAnimation;
        [SerializeField] private Sprite _jumpFrame;

        private const float DecreaseSpeedEveryFrame = 1000f;
        private const float StartSpeed = 700f;
        private float _groungY;
        private float _speedY;
        private bool _isjump;

        private void Update()
        {
            if (_isjump)
            {
                MoveJump();
            }    
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                StartJump();
            }
        }

        private void StartJump()
        {
            _groungY = _rect.anchoredPosition.y;
            _speedY = StartSpeed;
            _isjump = true;
            _runAnimation.enabled = false;
            _view.ShowFrame(_jumpFrame);
        }

        private void MoveJump()
        {
            Vector2 position = _rect.anchoredPosition;
            position.y += _speedY * Time.deltaTime;
            _speedY -= DecreaseSpeedEveryFrame * Time.deltaTime;
            
            if (position.y <= _groungY)
            {
                position.y = _groungY;
                Land();
            }
            _rect.anchoredPosition = position;
        }

        private void Land()
        {
            _isjump = false;
            _runAnimation.enabled = true;
            _runAnimation.ShowNextFrame();
        }
    }
}
