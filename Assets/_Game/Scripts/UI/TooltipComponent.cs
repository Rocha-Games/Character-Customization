using CharacterCustomization.Controllers;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CharacterCustomization.Components {
    [RequireComponent(typeof(BoxCollider2D))]
    public class TooltipComponent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
        
        [SerializeField] private string _tooltipText;
        
        private TooltipController _tooltipController;

        private void Start() {
            _tooltipController = SystemLocator.Resolve<TooltipController>();
        }

        public void OnPointerEnter(PointerEventData eventData) {
            _tooltipController.ShowTooltip(_tooltipText);
        }

        public void OnPointerExit(PointerEventData eventData) {
            _tooltipController.HideTooltip();
        }
    }
}