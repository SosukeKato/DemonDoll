public class ProgressEventController
{
    const int _progressEventCount = 10;


    InGameController _inGameController;

    bool[] _progressEvent;

    public ProgressEventController(InGameController inGameController)
    {
        _inGameController = inGameController;

        _progressEvent = new bool[_progressEventCount];
    }

    /// <summary>
    /// IDを受け取り、該当イベントを回収する
    /// </summary>
    /// <param name="progressEventID"></param>
    public void AdaptationProgressEventIndex(int progressEventID)
    {
        _progressEvent[progressEventID] = true;
    }

    /// <summary>
    ///GameController下のProgressControllerに対して現在の進行度を譲渡する(このメソッド削除する可能性があります)
    /// </summary>
    void AssignmentProgressEventIndex()
    {
        //TODO:ProgressControllerへのフラグ譲渡処理
    }
}
