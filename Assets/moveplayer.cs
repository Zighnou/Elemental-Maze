using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    public static string havekey = "n";
    public static string havefriend = "n";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*6,Input.GetAxis("Vertical")*6);
    
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag=="key")
        {
            havekey = "y";
        }
    }
}
