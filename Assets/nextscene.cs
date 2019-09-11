using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    private float timer;
    public float gazetime = 2f;
    private bool gazrdAt;
    // public Material[] material;
    // Renderer rend;
    // private int i=0;
    // Use this for initialization
    void Start()
    {
        //  rend = GetComponent<Renderer>();
        //   rend.enabled = true;
        //  rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (gazrdAt)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer >= gazetime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }
    public void PointerEnter()
    {
        gazrdAt = true;
        Debug.Log("yo bro");
        
      }
    public void PointerExit()
    {
        Debug.Log("yo exit");
        gazrdAt = false;
    }
    public void PointerDown()
    {
        // i = (i + 1) % 5;
        // rend.sharedMaterial = material[i];
        Debug.Log("yo broooooo");
        SceneManager.LoadScene(0);
    }
}
