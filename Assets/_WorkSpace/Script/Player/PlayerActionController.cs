using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionController
{
    InputAction _playerMove;
    InputAction _interact;
    InputAction _inventory;
    InputAction _sprint;

    Transform _tr;

    Vector2 _playerMoveInput;

    float _moveSpeed;
    float _sprintSpeed;

    public PlayerActionController(PlayerInput playerinput, float moveSpeed, float sprintSpeed, Transform transform)
    {
        _playerMove = playerinput.actions["Move"];
        _interact = playerinput.actions["Interact"];
        _inventory = playerinput.actions["Inventory"];
        _sprint = playerinput.actions["Sprint"];

        _tr = transform;

        _moveSpeed = moveSpeed;
        _sprintSpeed = sprintSpeed;
    }

    public void Move()
    {
        if (_playerMove.IsPressed() && !_sprint.IsPressed())
        {
            _playerMoveInput = _playerMove.ReadValue<Vector2>();
        }
        else
        {
            _playerMoveInput = Vector2.zero;
        }
        _tr.position += new Vector3(_playerMoveInput.x, 0, _playerMoveInput.y).normalized * _moveSpeed * Time.deltaTime;
    }

    public void Dash()
    {
        if (_playerMove.IsPressed() && _sprint.IsPressed())
        {
            _playerMoveInput = _playerMove.ReadValue<Vector2>();
        }
        else
        {
            _playerMoveInput = Vector2.zero;
        }
        _tr.position += new Vector3(_playerMoveInput.x, 0, _playerMoveInput.y).normalized * _moveSpeed * _sprintSpeed * Time.deltaTime;
    }
}
