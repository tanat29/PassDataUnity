using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intent : MonoBehaviour
{
    
    public void Goto() {
        PlayerPrefs.SetInt ("data", 7);
        SceneManager.LoadScene("Scene2");
    }
}
