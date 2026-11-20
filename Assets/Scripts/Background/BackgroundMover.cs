using UnityEngine;

namespace Moorkis.Dino2D.Background
{
    public class BackgroundMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 200f;

        private RectTransform _left;
        private RectTransform _right;
        private float _width;
        private float _leftX;

        public void StartMoving(BackgroundView first, BackgroundView second)
        {
            _left = (RectTransform)first.transform;
            _right = (RectTransform)second.transform;
            _width = _left.rect.width;
            _leftX = 0f;

            _right.pivot = new Vector2(1f, 0.5f);
            _right.localScale = new Vector3(-1f, 1f, 1f);

            SetPositions();
        }

        private void Update()
        {
            if (_left == null)
                return;

            _leftX -= _speed * Time.deltaTime;

            while (_leftX <= -_width)
            {
                _leftX += _width;

                RectTransform oldLeft = _left;
                _left = _right;
                _right = oldLeft;
            }

            SetPositions();
        }

        private void SetPositions()
        {
            _left.anchoredPosition = new Vector2(_leftX, 0f);
            _right.anchoredPosition = new Vector2(_leftX + _width, 0f);
        }
    }
}
