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
                //모든 마커가 비활성화
                //ui활성화
                //animation활성화
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
