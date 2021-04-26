using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerAction : MonoBehaviour
{
    public void Disapear(GameObject g)
    {
        g.SetActive(false);
    }

    public void Presentation(GameObject g)
    {
        g.SetActive(true);
    }
}
