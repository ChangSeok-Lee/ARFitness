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
		//�ִϸ��̼��� ���������̸� �����Ų��
		if (!isPlay) {
			
		}
	}
	public void Stop() {
		//�ִϸ��̼��� ��� �����̸� ������Ų��
		if (isPlay) {
			
		}
	}

	public void Replay() { 
		//�ִϸ��̼��� �ٽ� �����Ų��
	}

	public void Finish() {
		//�ִϸ��̼� ������ ����(��ü ���� Ȥ�� ��Ȱ��ȭ)
	}


}
