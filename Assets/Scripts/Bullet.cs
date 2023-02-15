using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D _rigidbody;
    public bool playerBullet = false;
    public bool ice = false;
    public bool water = false;
    public bool fire = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddRelativeForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || (collision.CompareTag("Player")&&!playerBullet) || (playerBullet && collision.CompareTag("Enemy")))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || (collision.CompareTag("Player") && !playerBullet))
        {
            Destroy(gameObject);
        }
    }
}
