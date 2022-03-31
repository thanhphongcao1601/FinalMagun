using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScoreTime : MonoBehaviour
{
    public GameObject[] fgameObjects, fgameObjects2;

    public Text OverScore;
    public Text OverTime;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       // txt = fgameObjects[0].GetComponent<Text>().text;
        //txt2 = fgameObjects2[0].GetComponent<Text>().text;

        OverScore.text = PlayerPrefs.GetString("score");
        OverTime.text = PlayerPrefs.GetString("time");
    }
}
