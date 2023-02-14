using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*9,Input.GetAxis("Vertical")*9);
    
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag=="key")
        {
            havekey = "y";
        }
    }

    private void onTriggerEnter2D(Collider2D door)

    {

        if ((door.gameObject.tag == "door") && (havekey=="y"))

        {

            SceneManager.LoadScene("youwin");


        }
    }
}
