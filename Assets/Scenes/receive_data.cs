using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receive_data : MonoBehaviour
{
    public Text score_text;
    private int old_score;

    void Start () {    
        old_score = PlayerPrefs.GetInt ("data");
        score_text.text = old_score.ToString ();      
    }
}
