using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class buttonScript : MonoBehaviour
{

    public GameObject buttonObj;
    public Animator animation;

    // Start is called before the first frame update
    void Start()
    {
        //animation.GetComponent<Animator>();
        //buttonObj = GameObject.Find("changeButton");
        //buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour  vb) {
        animation.SetBool("buttonPressed", true);
        Debug.Log("Button was pressed!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        animation.SetBool("buttonPressed", false);
        Debug.Log("Button was released!");
    }
}
