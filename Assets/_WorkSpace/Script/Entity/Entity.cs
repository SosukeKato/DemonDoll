using System;
using UnityEngine;

public class Entity : MonoBehaviour,IInteractable
{
    [NonSerialized] public int EntityID;

    [SerializeField,Header("フラグ管理用のID(ゲーム進行に関係のないEntityの場合は-1に設定)")] int _entityID;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public virtual void OnInteract()
    {
        //フラグ管理スクリプトにIDを渡す処理を追加する
    }
}
