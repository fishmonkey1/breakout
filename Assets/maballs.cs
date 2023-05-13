using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maballs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.CompareTag("Brick"))
        {

            Destroy(collision.collider.gameObject);
            // score += 1
        }
    }
}
