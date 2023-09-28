using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterCustomization.Controllers {
    public class ShopController : MonoBehaviour {


        [SerializeField] private GameObject _shopContent;

        public void OpenShopWindow() {
            _shopContent.SetActive(true);
        }
    }
}