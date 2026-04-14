using UnityEngine;

public class InGameController : MonoBehaviour
{
    ProgressEventController _progressEventController;

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

    public void AdaptationProgressEventIndex(int progressEventID)
    {
        _progressEventController.AdaptationProgressEventIndex(progressEventID);
    }
}
