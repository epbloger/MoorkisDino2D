using UnityEngine;
using UnityEngine.UI;

namespace Moorkis.Dino2D.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        
        public void ShowFrame(Sprite frame)
        {
            _image.sprite = frame;
        }
    }
}

