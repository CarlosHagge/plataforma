using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static double timeLeft = 5;
    public Text timeText;
    public GameObject restartPanel;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(timeLeft);
        if ( timeLeft > 0 )
        {
            timeLeft -= Time.deltaTime;
        }        
        if ( timeLeft <= 0 )
        {
            restartPanel.SetActive(true);
            Destroy(gameObject);
        }
        timeText.text = string.Concat("Tempo restante: ", System.String.Format("{0:0}s", timeLeft));
    }

    public static void addTime()
    {
        timeLeft += 2;
    }
}
