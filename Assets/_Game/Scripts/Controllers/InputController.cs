using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace CharacterCustomization.Controllers {
    public class InputController : MonoBehaviour {
        private Vector2 _moveDirection;


        internal Vector2 GetMoveDirection() {
            return _moveDirection;
        }

        //Called by PlayerInput component
        private void OnMove(InputValue value) {
            _moveDirection = value.Get<Vector2>();
        }
    }
}