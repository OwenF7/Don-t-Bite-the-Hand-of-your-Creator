using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToTreeCheck : MonoBehaviour
{
    public GameObject scriptHolderObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "bucket")
        {
            Debug.Log("Bucket is in return area!");

            scriptHolderObject.GetComponent<BeginningTree>().ReturnBucket();
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "bucket")
        {
            Debug.Log("Bucket has left the return area!");

            scriptHolderObject.GetComponent<BeginningTree>().BucketLeft();
        }
    }
}
