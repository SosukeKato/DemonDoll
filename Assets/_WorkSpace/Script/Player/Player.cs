using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerActionController _playerActionController;
    PlayerStateController _playerStateController;
    PlayerInventoryController _playerInventoryController;

    PlayerInput _playerInput;

    Transform _tr;

    [SerializeField] float _moveSpeed;
    [SerializeField] float _sprintSpeed;

    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _playerActionController = new(_playerInput, _moveSpeed, _sprintSpeed, _tr);
        _playerStateController = new();
        _playerInventoryController = new();
    }

    void Start()
    {
        
    }

    void Update()
    {
        _playerActionController.Move();
    }
}
