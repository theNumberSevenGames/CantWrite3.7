using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Vector3[] buttonVectors;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveCamera()
    {
        mainCam.transform.position = mainCam.WorldToViewportPoint(buttonVectors[0]);
        //mainCam.transform.LookAt(mainCam.WorldToScreenPoint(buttonVectors[0]));
    }
}
