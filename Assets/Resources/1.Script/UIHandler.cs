using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//카메라가 마커를 찾으면 버튼을 띄운다.
//버튼을 누르면 해당 애니메이션과 ui(정지, 재생, 다시보기, 인식화면으로 돌아가기) 생성

public class UIHandler : MonoBehaviour
{
    private GameObject canvas;
    private GameObject playStop;
    private bool isPlay;
    private GameObject replay;
    private GameObject back;
    private AnimationHandler animationHandler;


    public delegate string ButtonEvent();
    private void Awake()
	{
        init();
	}

    /// <summary>
    /// UI button initiallize
    /// </summary>
    void init() {
        isPlay = false;
        animationHandler = GameObject.Find("Manager/AnimationManager").GetComponent<AnimationHandler>();

        canvas = GameObject.Find("Canvas");


        playStop = canvas.transform.Find("playStopBtn").gameObject;
        replay = canvas.transform.Find("replayBtn").gameObject;
        back = canvas.transform.Find("backToRecogBtn").gameObject;

        AddEvent(playStop.GetComponent<Button>(), PlayStopAnimation);
        AddEvent(replay.GetComponent<Button>(), ReplayAnimation);
        AddEvent(back.GetComponent<Button>(), FinishAnimation);
    }
   
    /// <summary>
    /// Add button event
    /// </summary>
    void AddEvent(Button btn,UnityAction action) {
        btn.onClick.AddListener(action);
    }

    /// <summary>
    /// play and stop event function
    /// </summary>
    void PlayStopAnimation() {
        PlayAnimation();
        StopAnimation();
    }
    /// <summary>
    /// Play current animation
    /// </summary>
    void PlayAnimation() {
        isPlay = true;
        //UI를 stop으로 변경
        animationHandler.Play();
        Debug.Log("play");
    }
    /// <summary>
    /// Stop current animation
    /// </summary>
    void StopAnimation() {
        isPlay = false;
        //UI를 play로 변경
        animationHandler.Stop();
        Debug.Log("stop");
    }


    /// <summary>
    /// Replay current animation
    /// </summary>
    void ReplayAnimation() {
        animationHandler.Replay();
        replay.SetActive(false);
        Debug.Log("replay");
    }


    /// <summary>
    /// Finish current animation
    /// </summary>
    void FinishAnimation() {
        animationHandler.Finish();
        playStop.SetActive(false);
        replay.SetActive(false);
        back.SetActive(false);
        Debug.Log("finish");
    }

}
