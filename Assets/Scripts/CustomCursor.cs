using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour
{
    public Vector3 mDisplacement;

    // Start is called before the first frame update
    void Start()
    {
        // this sets the base cursor as invisible
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.visible)
        {
            Cursor.visible = false;
        }
        transform.position = Input.mousePosition + mDisplacement;
    }
}
