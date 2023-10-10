using CharacterCustomization.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopItemTypeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler {

    [SerializeField] private GameObject _activeBorder;
    [SerializeField] private ClothShopItemsSO _items;

    private ShopController _shopController;

    private void Awake() {
        _shopController = FindObjectOfType<ShopController>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        _shopController.OnButtonItemTypePressed(_items);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        _activeBorder.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData) {
        _activeBorder.SetActive(false);
    }
}
