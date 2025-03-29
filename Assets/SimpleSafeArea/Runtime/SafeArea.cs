using UnityEngine;

namespace konsnos.SimpleSafeArea
{
    public class SafeArea : MonoBehaviour
    {
        private RectTransform _rectTransform;
        
        private Rect _lastSafeArea;
        private ScreenOrientation _lastOrientation;
        
        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _rectTransform.anchorMin = Vector2.zero;
            _rectTransform.anchorMax = Vector2.one;
            _rectTransform.anchoredPosition = Vector2.zero;
            _rectTransform.offsetMin = Vector2.zero;
            _rectTransform.offsetMax = Vector2.zero;
            
        }
        
        private void Start()
        {
            ApplySafeArea();
        }
        
        private void Update()
        {
            if (_lastSafeArea == Screen.safeArea && _lastOrientation == Screen.orientation) return;
            
            ApplySafeArea();
            _lastOrientation = Screen.orientation;
            _lastSafeArea = Screen.safeArea;
        }
        
        private void OnValidate()
        {
            if (_rectTransform == null)
            {
                _rectTransform = GetComponent<RectTransform>();
            }
        }

        private void ApplySafeArea()
        {
            var screenSafeArea = Screen.safeArea;
            
            var anchorMin = screenSafeArea.position;
            var anchorMax = screenSafeArea.position + screenSafeArea.size;
            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
            
            _rectTransform.anchorMin = anchorMin;
            _rectTransform.anchorMax = anchorMax;
        }
    }
}
