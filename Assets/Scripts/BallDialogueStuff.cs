using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDialogueStuff : MonoBehaviour
{
    public GameObject interactHUD;
    public GameObject conversationTextNPC1;
    public GameObject conversationTextDad;
    public GameObject conversationTextWife;
    public GameObject conversationTextMob;
    public GameObject conversationTextPriest;
    public GameObject conversationTextPlague;

    public GameObject playerSphere;

    public GameObject beginningTreeObject;

    // Start is called before the first frame update
    void Start()
    {
        interactHUD.SetActive(false);

        conversationTextNPC1.SetActive(false);
        conversationTextDad.SetActive(false);
        conversationTextWife.SetActive(false);
        conversationTextMob.SetActive(false);
        conversationTextPriest.SetActive(false);
        conversationTextPlague.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC1")
        {
            Debug.Log("NPC1 Collider hit");

            interactHUD.SetActive(true);
        }

        else if (other.tag == "Dad")
        {
            Debug.Log("Dad Collider hit");

            interactHUD.SetActive(true);
        }

        else if (other.tag == "Wife")
        {
            Debug.Log("Wife Collider hit");

            interactHUD.SetActive(true);
        }

        else if (other.tag == "Mob")
        {
            Debug.Log("Mob Collider hit");

            interactHUD.SetActive(true);
        }

        else if (other.tag == "Priest")
        {
            Debug.Log("Priest Collider hit");

            interactHUD.SetActive(true);
        }

        else if (other.tag == "Plague")
        {
            Debug.Log("Plague Doctor Collider hit");

            interactHUD.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "NPC1")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    Debug.Log("F key hit!");

                    DialogueEnter1();
                }
            }
        }
        else if (other.tag == "Dad")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    DialogueEnter2();
                }
            }
        }

        else if (other.tag == "Wife")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    DialogueEnter3();
                }
            }
        }

        else if (other.tag == "Priest")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    DialogueEnter4();
                }
            }
        }

        else if (other.tag == "Plague")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    DialogueEnter5();
                }
            }
        }

        else if (other.tag == "Mob")
        {
            if (interactHUD.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    DialogueEnter6();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPC1")
        {
            interactHUD.SetActive(false);
        }

        else if (other.tag == "Dad")
        {
            interactHUD.SetActive(false);
        }

        else if (other.tag == "Wife")
        {
            interactHUD.SetActive(false);
        }

        else if (other.tag == "Priest")
        {
            interactHUD.SetActive(false);
        }

        else if (other.tag == "Mob")
        {
            interactHUD.SetActive(false);
        }

        else if (other.tag == "Plague")
        {
            interactHUD.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
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

        if (conversationTextDad.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextDad should stop now");
                conversationTextDad.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextWife.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextWife should stop now");
                conversationTextWife.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextMob.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextMob should stop now");
                conversationTextMob.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextPriest.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                Debug.Log("ConversationTextPriest should stop now");
                conversationTextPriest.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (conversationTextPlague.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                // Leave Conversation without poison 

                Debug.Log("ConversationTextPlague should stop now");
                conversationTextPlague.SetActive(false);
                interactHUD.SetActive(true);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
            if (Input.GetKeyDown(KeyCode.P) == true)
            {
                // Leave conversation with poison 

                Debug.Log("Got poison!");
                conversationTextPlague.SetActive(false);
                interactHUD.SetActive(true);

                beginningTreeObject.GetComponent<BeginningTree>().GotPoison();

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }

        }
    }

    void DialogueEnter1()
    {
        Debug.Log("NPC1 Dialogue should activate");

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

    void DialogueEnter3()
    {
        Debug.Log("Wife Dialogue should activate");

        conversationTextWife.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    void DialogueEnter4()
    {
        Debug.Log("Priest Dialogue should activate");

        conversationTextPriest.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    void DialogueEnter5()
    {
        Debug.Log("Plague Dialogue should activate");

        conversationTextPlague.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    void DialogueEnter6()
    {
        Debug.Log("Mob Dialogue should activate");

        conversationTextMob.SetActive(true);

        interactHUD.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}