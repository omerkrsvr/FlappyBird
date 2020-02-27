using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_sayma : MonoBehaviour {

    // Use this for initialization
    static int score;
    static int high_score;
    public UnityEngine.UI.Text text;

	void Start () {
        score = 0;
        high_score = PlayerPrefs.GetInt("Hscore");
	}
    static public void score_art()
    {
        score++;
        if(score>high_score)
        {
            high_score = score;
        }
        Debug.Log(score);
    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Hscore", high_score);
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Skor: " + score.ToString() + "\nHighScore: " + high_score.ToString();
	}
}
