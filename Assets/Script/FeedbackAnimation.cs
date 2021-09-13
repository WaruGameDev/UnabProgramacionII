using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FeedbackAnimation : MonoBehaviour
{
    Tween shake;


    private void Start()
    {
        ManagerClicker.instance.onLevelUp += AnimationFeedback;
        shake = transform.DOShakePosition(0.5f, new Vector3(0, 1, 0))
            .Pause().SetRecyclable(true).SetAutoKill(false);
    }

    public void AnimationFeedback()
    {       
        shake.Restart();        
    }
}
