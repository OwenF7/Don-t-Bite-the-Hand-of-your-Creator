using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Dialogue : MonoBehaviour
{
    public GameObject interactHUD;
    public GameObject conversationTextNPC1;
    public GameObject conversationTextDad;

    public GameObject interactCollider;

    public GameObject playerSphere;

    // Start is called before the first frame update
    void Start()
    {
        interactHUD.SetActive(false);

        conversationTextNPC1.SetActive(false);
        conversationTextDad.SetActive(false);
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

                if (interactCollider.tag == "NPC1")
                {
                    DialogueEnter1();
                }

                if (interactCollider.tag == "Dad")
                {
                    DialogueEnter2();
                }
            }

            //Debug.Log("Inside interact hud");
        }

        if (conversationTextNPC1.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextNPC1 should stop now");
                conversationTextNPC1.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }
    }

    void DialogueEnter1()
    {
        //Debug.Log("Dialogue Enter() activates");

        Debug.Log("NPC1 Dialogue should activate");

        //GameObject.GetComponent<BoxCollider>();

            conversationTextNPC1.SetActive(true);

            interactHUD.SetActive(false);

            playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    void DialogueEnter2()
    {
        Debug.Log("Dad Dialogue should activate");

        conversationTextDad.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}
