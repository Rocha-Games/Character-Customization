using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterCustomization.Controllers {

    public enum ClothesItemTypes {
        Tops,
        Bottoms,
        Shoes
    }

    public class ShopController : MonoBehaviour {

        [SerializeField] private PlayerEquipmentSO _playerEquipmentData;
        [SerializeField] private ClothShopItemsSO _defaultItems;
        [SerializeField] private GameObject _shopContent;
        [SerializeField] private Transform _shopScrollViewContent;
        [SerializeField] private ShopItemTemplateIcon _shopItemTemplateIcon;

        public void OpenShopWindow() {
            OnButtonItemTypePressed(_defaultItems);
            _shopContent.SetActive(true);
        }

        public void OnButtonItemTypePressed(ClothShopItemsSO items) {
            foreach(Transform t in _shopScrollViewContent) {
                Destroy(t.gameObject);
            }

            foreach (var item in items.List) {
                var shopItem = Instantiate(_shopItemTemplateIcon, _shopScrollViewContent);
                shopItem.Initialize(item);
            }
        }

        public void SetEquipment(ShopItemSO itemData) {
            switch (itemData.ItemType) {
                case ClothesItemTypes.Tops:
                    _playerEquipmentData.topsSprite = itemData.Sprite;
                    break;
                case ClothesItemTypes.Bottoms:
                    _playerEquipmentData.bottomsSprite = itemData.Sprite;
                    break;
                case ClothesItemTypes.Shoes:
                    _playerEquipmentData.shoesSprite = itemData.Sprite;
                    break;
            }

            EventManager.Instance.Invoke(EventManager.Events.OnEquipmentChanged);
        }
    }
}