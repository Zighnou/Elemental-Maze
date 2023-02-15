using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class moveplayer : MonoBehaviour
{
    bool haveKey = false;
    
   // Health
    public float maxHP = 3f;
    public float curHP = 3f;
    // public Image healthBar;
    // public Animation healthBarAnim;
    public float canTakeDamage = 0; // can only take damage while 0; used for i-frames
    // public Animation bodyAnim;

    // Movement
    private Rigidbody2D _rigidbody;
    public Transform player;

    // Shooting
    public GameObject[] bulletPrefab;
    public Transform shootPoint;

    // // VFX
    // public ParticleSystem shot;
    // public ParticleSystem smoke;

    // // SFX
    // public AudioSource aud;
    // public AudioClip shoot, reload, hurt;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        curHP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        if (damage != 0)
        {
            canTakeDamage += .3f;
        }
        else
        {
            canTakeDamage += .05f;
        }

        curHP -= damage;
        // healthBar.fillAmount = curHP / maxHP;
        
        // if(curHP <= 0)
        // {
        //     StartCoroutine(Die());
        // }
    }

    // public IEnumerator Die()
    // {

    //     GameManager.gm.LoseGame();
    //     yield return null;
    // }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal")*9,Input.GetAxis("Vertical")*9);

        //ROTATE GUN
        var mousePos = Input.mousePosition;
        mousePos.z = 4f;
        var objectPos = Camera.main.WorldToScreenPoint(player.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;
        var angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        player.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //SHOOT
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, shootPoint.position, player.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="key")
        {
            haveKey = true;
        }

        else if ((other.gameObject.tag == "door") && (haveKey))
        {
            SceneManager.LoadScene("youwin");
        }
    }
}
