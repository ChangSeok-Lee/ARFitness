using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
	private bool isPlay;
	private UIHandler uiHandler;
	private Animator anim;
	public Animator animator {
		get { return anim; }
		set {
			anim = value;
		}
	}
	public void Awake()
	{
		init();
	}

	void init() {
		uiHandler = GameObject.Find("UIManager").GetComponent<UIHandler>();
	}
	public void Play() {
		//애니메이션이 정지상태이면 재생시킨다
		if (!isPlay) {
			
		}
	}
	public void Stop() {
		//애니메이션이 재생 상태이면 정지시킨다
		if (isPlay) {
			
		}
	}

	public void Replay() { 
		//애니메이션을 다시 재생시킨다
	}

	public void Finish() {
		//애니메이션 강제로 종료(객체 삭제 혹은 비활성화)
	}


}
