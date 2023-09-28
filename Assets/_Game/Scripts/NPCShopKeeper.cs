using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterCustomization.Controllers {
    public class NPCShopKeeper : MonoBehaviour, IInteractable {

        [SerializeField] private ShopController _shopController;

        public void Interact() {
            _shopController.OpenShopWindow();
        }
    }
}