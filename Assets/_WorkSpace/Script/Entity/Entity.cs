using System;
using UnityEngine;

public class Entity : MonoBehaviour,IInteractable
{
    InGameController _inGameController;

    [NonSerialized] public int EntityID;

    [SerializeField,Header("フラグ管理用のID(ゲーム進行に関係のないEntityの場合は-1に設定)")] int _entityID;

    void Awake()
    {
        _inGameController = FindAnyObjectByType<InGameController>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public virtual void OnInteract()
    {
        _inGameController.AdaptationProgressEventIndex(EntityID);
    }
}
