using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBox : MonoBehaviour
{
    public GameObject PowerUp;
    public int uses = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(uses != 0)
        {
            if (collision.tag == "Player")
            {
                Instantiate(PowerUp, transform.position + new Vector3(0, .5f, 0), transform.rotation);
                uses--;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
