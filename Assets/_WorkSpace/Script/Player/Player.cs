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

    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _playerActionController = new(_playerInput, _moveSpeed, _tr);
        _playerStateController = new();
        _playerInventoryController = new();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
