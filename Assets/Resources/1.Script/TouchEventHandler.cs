using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEventHandler : MonoBehaviour
{

    public GameObject testObject;
    public GameObject testAnim;
    private bool selected;


    public List<GameObject> MarkerName;

	private void Awake()
	{
        selected = false;
	}
	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            
            if (hit.collider != null) {
                
                selected = true;
                //��� ��Ŀ�� ��Ȱ��ȭ
                //uiȰ��ȭ
                //animationȰ��ȭ
                testAnim.SetActive(true);
                testObject.SetActive(false);
            }
        }
    }

    void DeActivateMarker() { }

    void AwakeCanvas() { }

    void AwakeAnim() {

    }

}
