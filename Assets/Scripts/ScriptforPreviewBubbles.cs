using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptforPreviewBubbles : MonoBehaviour
{
    [SerializeField]
    Canvas bubbleCanvas;

    // Start is called before the first frame update
    void Start()
    {
        bubbleCanvas.enabled = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player Sphere")
        {
            TurnOnBubble(); 
        }
    }

    private void TurnOnBubble()
    {
        bubbleCanvas.enabled = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player Sphere")
        {
            TurnOffBubble(); 
        }
    }

    private void TurnOffBubble()
    {
        bubbleCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
