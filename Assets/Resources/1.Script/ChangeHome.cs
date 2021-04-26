using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeHome : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("0.Main");
    }
}
