using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class ScriptForNPCDialogue : MonoBehaviour
{
    public GameObject interactHUD;
    public GameObject conversationTextNPC1;
    public GameObject conversationTextNPCPlague;
    public GameObject conversationTextNPCWife;
    public GameObject conversationTextNPCDad;
    public GameObject conversationTextNPCPriest; 

    public GameObject playerSphere;

    // Start is called before the first frame update
    void Start()
    {
        interactHUD.SetActive(false);

        conversationTextNPC1.SetActive(false);
        conversationTextNPCPlague.SetActive(false);
        conversationTextNPCWife.SetActive(false);
        conversationTextNPCDad.SetActive(false);
        conversationTextNPCPriest.SetActive(false);
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

        if (conversationTextNPCPlague.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextPlague should stop now");
                conversationTextNPCPlague.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextNPCWife.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextWife should stop now");
                conversationTextNPCWife.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextNPCDad.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextDad should stop now");
                conversationTextNPCDad.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextNPCPriest.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextPriest should stop now");
                conversationTextNPCPriest.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }
    }

    void DialogueEnter()
    {
        //Debug.Log("Dialogue Enter() activates");

        if (this.gameObject.tag == "NPC1")
        {
            Debug.Log("NPC1 Dialogue should activate");
            conversationTextNPC1.SetActive(true);
        }

        else if (this.gameObject.tag == "Plague")
        {
            Debug.Log("NPCPlague Dialogue should activate");
            conversationTextNPCPlague.SetActive(true);
        }

        //else if (this.gameObject.tag == "Wife")
        //{
            //Debug.Log("NPCWife Dialogue should activate");
            //conversationTextNPCWife.SetActive(true);
        //}

        else if (this.gameObject.tag == "Dad")
        {
            Debug.Log("NPCDad Dialogue should activate");
            conversationTextNPCDad.SetActive(true);
        }

        else if (this.gameObject.tag == "Priest")
        {
            Debug.Log("NPCPriest Dialogue should activate");
            conversationTextNPCPriest.SetActive(true);
        }

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}
