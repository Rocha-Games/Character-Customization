using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterCustomization.Controllers {
    public class CharacterController : MonoBehaviour {

        [SerializeField] private float _walkSpeed = 4;
        private InputController _inputController;
        private Rigidbody2D _rb;
        private Vector2 _moveDirection;
        private bool _canMove = true;

        private void Awake() {
            _inputController = GetComponent<InputController>();
            _rb = GetComponent<Rigidbody2D>();
        }


        private void Update() {
            ReadInput();
        }

        private void ReadInput() {
            _moveDirection = _inputController.GetMoveDirection();
        }

        private void FixedUpdate() {
            MoveCharacter();
        }

        private void MoveCharacter() {
            if (!_canMove)
                return;

            _rb.velocity = _moveDirection * _walkSpeed;
        }
    }
}