using UnityEngine;
using UnityEngine.UI;

public class Document : Entity
{
    [SerializeField, Header("ï∂èë")] Image _documentImage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void OnInteract()
    {
        ReadDocument();
        base.OnInteract();
    }

    void ReadDocument()
    {
        _documentImage.gameObject.SetActive(true);
    }
}
