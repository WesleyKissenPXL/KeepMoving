using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectionBox : MonoBehaviour
{
    public GameObject targetObject; // Reference to the target GameObject
    public float detectionDistance = 5f; // Distance within which the target object is considered "near"
    public GameObject dummy; // Reference to the target GameObject
    public GameObject previosCompleted;

    // Update is called once per frame
    void Update()
    {
        if (previosCompleted == null || previosCompleted.activeSelf == true)
        {
            // Check if the target object is within the detection distance
            if (targetObject != null && Vector3.Distance(transform.position, targetObject.transform.position) <= detectionDistance)
            {

                // The target object is near
                //Debug.Log("Target object is near!");
                dummy.SetActive(false);
            }
            else
            {
                // The target object is not near
                //Debug.Log("Target object is not near.");
                dummy.SetActive(true);
            }
        }
        
    }
}
