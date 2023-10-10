using CharacterCustomization.Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItemTemplateIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler {

    [SerializeField] private Image _itemImage;
    [SerializeField] private TextMeshProUGUI _itemName, _itemPrice;
    [SerializeField] private GameObject _activeBorder;
    
    private ShopController _shopController;
    private ShopItemSO _itemData;

    private void Awake() {
        _shopController = FindObjectOfType<ShopController>();
    }

    public void Initialize(ShopItemSO itemData) {
        _itemData = itemData;

        _itemImage.sprite = _itemData.Sprite;
        _itemName.text = _itemData.ItemName;
        _itemPrice.text = _itemData.Price.ToString();

        _itemImage.enabled = _itemImage.sprite != null;
    }

    public void OnPointerDown(PointerEventData eventData) {
        _shopController.SetEquipment(_itemData);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        _activeBorder.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData) {
        _activeBorder.SetActive(false);
    }
}
