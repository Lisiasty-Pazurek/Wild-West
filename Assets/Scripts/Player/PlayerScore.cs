using UnityEngine;
using Mirror;
using System;

public class PlayerScore : NetworkBehaviour
    {
    [SyncVar] public int index;

    [SyncVar (hook = nameof(ScoreChange))] public int score;
    public UIHandler uiHandler;

    public void Start()
    {
        
        uiHandler = this.GetComponentInParent<PlayerMovementController>().uiHandler;
    }

    public void ScoreChange(int oldValue, int newValue)
    {
        score = newValue;
        uiHandler.ChangeScore(score.ToString());
    }


}
