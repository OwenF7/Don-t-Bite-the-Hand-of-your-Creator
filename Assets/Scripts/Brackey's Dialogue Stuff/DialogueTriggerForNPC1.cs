using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerForNPC1 : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject conversationUIObject;

    public GameObject interactHUD;
    public GameObject playerSphere;

    void Start()
    {
        interactHUD.SetActive(false);
        conversationUIObject.SetActive(false);
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

    void Update()
    {
        if (interactHUD.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.F) == true)
            {
                TriggerDialogue();

                conversationUIObject.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            }
        }

        if (conversationUIObject.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                conversationUIObject.SetActive(false);

                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
