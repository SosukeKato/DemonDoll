using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerActionController _playerActionController;
    PlayerStateController _playerStateController;
    PlayerInventoryController _playerInventoryController;

    PlayerInput _playerInput;

    Transform _tr;

    Vector3 _rayStartPosition;
    Vector3 _rayDirection;
    RaycastHit _raycastHit;

    bool _isHit;

    [Header("Interact用RayCastに使用する変数")]
    [SerializeField,Tooltip("プレイヤーの目")] Camera _playerEye;
    [SerializeField,Tooltip("Interact用RayCastの長さ")] float _distance;

    [Header("移動速度")]
    [SerializeField,Tooltip("非スプリント時の移動速度")] float _moveSpeed;
    [SerializeField,Tooltip("スプリント時の移動速度")] float _sprintSpeed;

    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _tr = transform;

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
        _playerActionController.Interact(GetInterectTarget());
    }

    IInteractable GetInterectTarget()
    {
        _rayStartPosition = _playerEye.transform.position;
        _rayDirection = _playerEye.transform.forward.normalized;
        Debug.DrawRay(_rayStartPosition, _rayDirection * _distance, Color.red);

        if (Physics.Raycast(_rayStartPosition, _rayDirection, out _raycastHit, _distance))
        {
            //ここでrayがヒットした対象のインタラクトされた際の処理を実行させる(未実装)
            Debug.Log("HitObject : " + _raycastHit.collider.gameObject.name);
            _raycastHit.collider.TryGetComponent<IInteractable>(out IInteractable interactable);

            return interactable;
        }

        return null;
    }
}
