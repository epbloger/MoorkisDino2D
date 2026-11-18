using UnityEngine;
using UnityEngine.Serialization;

namespace Moorkis.Dino2D.Background
{
    public class BackgroundMover : MonoBehaviour
    {
    //    [SerializeField] private RectTransform _transformFirst;
    //    [SerializeField] private RectTransform _transformSecond;
    //    [SerializeField, FormerlySerializedAs("LeftCorner")] private int _leftCorner;
    //    [SerializeField] private int _speed;
    //    private int _firstX;
    //    private int _secondX;

    //    private void Start()
    //    {
    //        _firstX = (int)_transformFirst.anchoredPosition.x;
    //        _secondX = (int)_transformSecond.anchoredPosition.x;
    //    }

    //    private void Update()
    //    {
    //        if (_firstX <= _leftCorner)
    //        {
    //            var pos = (int)_transformSecond.sizeDelta.x;
    //            _firstX = pos;
    //            _transformFirst.anchoredPosition = new Vector2(pos, 0);
    //        }
    //        if (_secondX <= _leftCorner)
    //        {
    //            var pos = (int)_transformFirst.sizeDelta.x;
    //            _secondX = pos;
    //            _transformSecond.anchoredPosition = new Vector2(pos, 0);
    //        }
    //        MoveBackground();
    //    }

    //    private void MoveBackground()
    //    {
    //        _firstX -= _speed;
    //        _secondX -= _speed;
    //        _transformFirst.anchoredPosition = new Vector2(_firstX, 0);
    //        _transformSecond.anchoredPosition = new Vector2(_secondX, 0);
    //    }
    }
}
