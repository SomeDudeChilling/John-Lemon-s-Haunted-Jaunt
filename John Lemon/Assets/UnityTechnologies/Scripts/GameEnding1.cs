using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
public class GameEnding1 : MonoBehaviour
{
    public float fadeDuration = 1f;
    public GameObject player;
    bool m_IsPlayerAtExit;
    float m_Timer;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_IsPlayerAtExit)
        {
           EndLevel();
        }
    }
    void EndLevel()
    {

    }

    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }
}
