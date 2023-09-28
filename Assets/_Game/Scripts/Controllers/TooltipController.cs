using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CharacterCustomization.Controllers {
    public class TooltipController : MonoBehaviour, ILocalizableByLocator {
        
        [SerializeField] private GameObject _simpleTooltipContent;
        [SerializeField] private TextMeshProUGUI _tooltipText;
        [SerializeField] private float _tooltipPixelsOffsetX = 128f;
        [SerializeField] private float _tooltipPixelsOffsetY = 64;

        private bool _isShowing;

        private void OnEnable() {
            SystemLocator.Register(this);
            HideTooltip();
        }
        private void OnDisable() {
            SystemLocator.UnRegister(this);
        }

        private void LateUpdate() {
            if (!_isShowing)
                return;
            
            _simpleTooltipContent.transform.position = Mouse.current.position.ReadValue() + (Vector2.right * _tooltipPixelsOffsetX) + (Vector2.down * _tooltipPixelsOffsetY);
        }

        public void ShowTooltip(string text) {
            _tooltipText.text = text;
            _simpleTooltipContent.SetActive(true);
            _isShowing = true;
        }

        public void HideTooltip() {
            _simpleTooltipContent.SetActive(false);
            _isShowing = false;
        }
    }
}