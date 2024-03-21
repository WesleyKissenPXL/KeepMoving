using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPopup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dummyObject;
    public Vector3 moveamountUp = new Vector3(10f, 0, 0);
    public Vector3 moveamountDown = new Vector3(-10f, 0, 0);
    private Vector3 initialPosition;

    public bool moved = false;

    private bool isDummyEnabled;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (dummyObject != null && dummyObject.activeSelf != isDummyEnabled)
        {
            isDummyEnabled = dummyObject.activeSelf;

            if (isDummyEnabled)
            {
                // Move the object down
                transform.Translate(Vector3.down * 10f);
            }
            else
            {
                // Move the object up
                transform.Translate(Vector3.up * 10f);
            }
        }
    }
}
