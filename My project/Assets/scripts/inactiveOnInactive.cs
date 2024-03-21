using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inactiveOnInactive : MonoBehaviour
{
    public GameObject targetObject;

    // Update is called once per frame
    void Update()
    {
        // Check if the target object is null or no longer active
        if (targetObject == null || !targetObject.activeSelf)
        {
            // Deactivate this GameObject if the target is destroyed
            gameObject.SetActive(false);
        }
    }
}
