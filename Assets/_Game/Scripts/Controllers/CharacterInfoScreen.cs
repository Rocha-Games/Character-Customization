using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoScreen : MonoBehaviour
{
    [SerializeField] private PlayerEquipmentSO _playerEquipmentData;
    [SerializeField] private Image _tops, _bottoms, _shoes;


    private void OnEnable() {
        EventManager.Instance.Subscribe(EventManager.Events.OnEquipmentChanged, OnEquipmentChanged);
    }
    private void OnDisable() {
        EventManager.Instance.Unsubscribe(EventManager.Events.OnEquipmentChanged, OnEquipmentChanged);
    }

    private void Start() {
        RefreshEquipmentScreen();
    }

    private void OnEquipmentChanged() {
        RefreshEquipmentScreen();
    }

    private void RefreshEquipmentScreen() {
        _tops.sprite = _playerEquipmentData.topsSprite;
        _bottoms.sprite = _playerEquipmentData.bottomsSprite;
        _shoes.sprite = _playerEquipmentData.shoesSprite;
        
        _tops.enabled = _tops.sprite != null;
        _bottoms.enabled = _bottoms.sprite != null;
        _shoes.enabled = _shoes.sprite != null;
    }
}
