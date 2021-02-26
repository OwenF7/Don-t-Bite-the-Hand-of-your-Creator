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
    public GameObject poisonUI;
    public GameObject poisonUICheck;

    public GameObject refuseEnding;
    public GameObject poisonEnding;
    public GameObject obedientEnding;

    public GameObject playerSphere;
    public GameObject returnToTreeScriptObject;

    public GameObject level1Music;
    public GameObject level2Music;
    public GameObject level3Music;
    public GameObject obedientEndingMusic;
    public GameObject poisonEndingMusic;
    public GameObject refusalEndingMusic; 

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        introTreeDialogue.SetActive(true);

        tutorialText.SetActive(false); 

        returnToTree.SetActive(false);

        poisonUI.SetActive(false);

        poisonUICheck.SetActive(false);

        refuseEnding.SetActive(false);

        poisonEnding.SetActive(false);

        obedientEnding.SetActive(false);

        level1Music.SetActive(false);

        level2Music.SetActive(false);

        level3Music.SetActive(false);

        obedientEndingMusic.SetActive(false);

        poisonEndingMusic.SetActive(false);

        refusalEndingMusic.SetActive(false);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            //Debug.Log("It's scene One!");

            level1Music.SetActive(true);

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
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }

                else if (Input.GetKeyDown(KeyCode.G) == true)
                {
                    RefuseEnding();
                }
            }
        }

        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //Debug.Log("It's scene Two!"); 

            level2Music.SetActive(true);

            if (introTreeDialogue.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    introTreeDialogue.SetActive(false);

                    playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                }
            }

            if (returnToTree.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }

                else if (Input.GetKeyDown(KeyCode.G) == true)
                {
                    RefuseEnding();
                }
            }
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            //Debug.Log("It's scene Three!");

            level3Music.SetActive(true);

            if (introTreeDialogue.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    introTreeDialogue.SetActive(false);

                    playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                }
            }

            if (poisonUI.activeInHierarchy == true)
            {
                    if (Input.GetKeyDown(KeyCode.P) == true)
                    {
                        PoisonEnding();
                    }

                    else if (Input.GetKeyDown(KeyCode.G) == true)
                    {
                        RefuseEnding();
                    }
            }

            else if (returnToTree.activeInHierarchy == true)
            {
                if (Input.GetKeyDown(KeyCode.F) == true)
                {
                    ObedientEnding(); 
                }

                else if (Input.GetKeyDown(KeyCode.G) == true)
                {
                    RefuseEnding();
                }
            }
        }
    }

    public void ReturnBucket()
    {
        //Debug.Log("This worked!");

        if (poisonUICheck.activeInHierarchy == true)
        {
            poisonUI.SetActive(true);
        }

        else
        {
            returnToTree.SetActive(true);
        }
    }

    public void BucketLeft()
    {
        //Debug.Log("This worked too!");

        if (poisonUICheck.activeInHierarchy == true)
        {
            poisonUI.SetActive(false);
        }

        else
        {
            returnToTree.SetActive(false);
        }
    }

    public void GotPoison()
    {
        poisonUICheck.SetActive(true); 
    }

    public void RefuseEnding()
    {
        returnToTree.SetActive(false);

        refuseEnding.SetActive(true);

        refusalEndingMusic.SetActive(true);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            level1Music.SetActive(false);
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            level2Music.SetActive(false);
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            level3Music.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            SceneManager.LoadScene(0);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.X) == true)
        {
            Application.Quit();
        }
    }

    public void ObedientEnding()
    {
        returnToTree.SetActive(false);

        obedientEnding.SetActive(true);

        level3Music.SetActive(false);

        obedientEndingMusic.SetActive(true);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.X) == true)
        {
            Application.Quit();
        }
    }

    public void PoisonEnding()
    {
        returnToTree.SetActive(false); 

        poisonEnding.SetActive(true);

        level3Music.SetActive(false);

        poisonEndingMusic.SetActive(true);

        playerSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.X) == true)
        {
            Application.Quit();
        }
    }
}
