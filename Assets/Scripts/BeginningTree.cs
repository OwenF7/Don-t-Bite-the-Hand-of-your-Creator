using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginningTree : MonoBehaviour
{
    public GameObject introTreeDialogue;
    public GameObject tutorialText; 
    public GameObject hUD;
    public GameObject interact;
    public GameObject returnToTree;

    public GameObject playerSphere;
    public GameObject returnToTreeScriptObject;

    // Start is called before the first frame update
    void Start()
    {
        introTreeDialogue.SetActive(true);

        tutorialText.SetActive(false); 

        returnToTree.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (introTreeDialogue.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.F) == true)
            {
                introTreeDialogue.SetActive(false); 

                tutorialText.SetActive(true); 
            }
        }

        if (tutorialText.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.G) == true)
            {
                tutorialText.SetActive(false);

                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
        }

        if (returnToTree.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.F) == true)
            {
                playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            }
        }
    }

    public void ReturnBucket()
    {
        //Debug.Log("This worked!");

        returnToTree.SetActive(true);
    }

    public void BucketLeft()
    {
        //Debug.Log("This worked too!");

        returnToTree.SetActive(false); 
    }
}
