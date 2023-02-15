using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int elemToKill;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Bullet") && elemToKill == PublicVars.currElem) 
        {
            if(elemToKill == 1)
            {
                
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        else if (other.CompareTag("Player")) {
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
