using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;
public class OnHoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UnityEvent OnHover = new UnityEvent();

    public string buttonText;
    
    public TMP_Text thisText;
    public GameObject[] targets;


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
         thisText.SetText(buttonText);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
         thisText.SetText("");
    }
    void Start()
    {
        thisText.SetText("");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
