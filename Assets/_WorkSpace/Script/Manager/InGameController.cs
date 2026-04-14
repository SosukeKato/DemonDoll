using UnityEngine;

public class InGameController : MonoBehaviour
{
    ProgressEventController _progressEventController;

    int _progressEventID;

    void Awake()
    {
        _progressEventController = new(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
