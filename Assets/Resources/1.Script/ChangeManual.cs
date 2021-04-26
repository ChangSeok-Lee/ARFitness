using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeManual : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("2.Manual");
    }
}
