using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class JumpandMove : MonoBehaviour
{

    Sequence jumpTween;
    private float timeInterval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PlayJumpTween", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void PlayJumpTween()
    {

        jumpTween = DOTween.Sequence();


        jumpTween.Append(

            transform.DOScaleY(.8f, .1f)
            .SetEase(Ease.InOutCubic)

        );
        jumpTween.Append(
            //move left 6 units along the x axis, in one second
            transform.DOMoveX(1, .5f)
            //move the object relative to its original position, not from a specific point in world space
            .SetRelative()
            //use a nice ease curve to make it look fancy
            .SetEase(Ease.InOutCubic)
            );

        jumpTween.Join(
            //move left 6 units along the x axis, in one second
            transform.DOMoveY(1, .5f)
            //move the object relative to its original position, not from a specific point in world space
            .SetRelative()
            //use a nice ease curve to make it look fancy
            .SetEase(Ease.InOutCubic)
            );
        jumpTween.Join(

            transform.DOScaleY(1.5f, 1f)
            .SetEase(Ease.InOutCubic)
        );

               



       // jumpTween.SetLoops(1, LoopType.Restart);

    }

}
