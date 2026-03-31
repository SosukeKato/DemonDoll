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

    int _inventoryAction;
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
        if (!_playerMove.IsPressed()) return;

        _playerMoveInput = _playerMove.ReadValue<Vector2>();
        Vector3 direction = new Vector3(_playerMoveInput.x, 0, _playerMoveInput.y).normalized;
        float speed = _sprint.IsPressed() ? _sprintSpeed : _moveSpeed;

        _tr.position += direction * speed * Time.deltaTime;
    }

    public void Interact()
    {
        if (!_interact.WasPressedThisFrame()) return;
    }

    public void Inventory()
    {
        if (!_inventory.WasPressedThisFrame()) return;

        _inventoryAction++;

        switch (_inventoryAction % 2)
        {
            case 0:
                //インベントリを閉じる処理
                return;
            case 1:
                //インベントリを開く処理
                return;
        }
    }
}
