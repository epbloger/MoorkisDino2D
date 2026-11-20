using UnityEngine;

namespace Moorkis.Dino2D.Player
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private RectTransform _rect;

        private void Update()
        {
            MoveRight();   
        }

        private void MoveRight()
        {
            Vector2 position = _rect.anchoredPosition;

            if (position.x >= 500f)
            {
                return;
            }

            position.x += 500f * Time.deltaTime;
            
            if (position.x > 500f)
            {
                position.x = 500f;
            }

            _rect.anchoredPosition = position;
        }
    }
}

