using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadDialogue : MonoBehaviour
{
    public GameObject interactHUD;
    public GameObject conversationText;

    public GameObject playerSphere;

    // Start is called before the first frame update
    void Start()
    {
        interactHUD.SetActive(false);

        conversationText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player Sphere")
        {
            interactHUD.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player Sphere")
        {
            interactHUD.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interactHUD.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.F) == true)
            {
                //Debug.Log("Pressed Interact");

                DialogueEnter();
            }

            //Debug.Log("Inside interact hud");
        }

        if (conversationText.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationText should stop now");
                conversationText.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }
    }

    void DialogueEnter()
    {
        //Debug.Log("Dialogue Enter() activates");

        Debug.Log("Dialogue should activate");
        conversationText.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}
