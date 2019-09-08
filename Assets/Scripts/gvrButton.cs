using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gvrButton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent gvrClick;
    public float totalTime = 2f;
    bool gvrStatus;
    public float gvrTimer;

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if(gvrTimer > totalTime)
        {
            gvrClick.Invoke();
        }
    }

    public void gvrON()
    {
        gvrStatus = true;

    }
    public void gvrOFF()
    {
        gvrStatus = false;
        gvrTimer = 0f;
        imgCircle.fillAmount = 0;


    }
}
