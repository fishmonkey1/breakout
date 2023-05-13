using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float speed = 5f;
    public float paddleXbound = 9.5f;

    float movementHorizontal;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
       
        movementHorizontal = Input.GetAxis("Horizontal"); //float -1...1
        if (movementHorizontal>0 && transform.position.x <  paddleXbound  ||
            movementHorizontal<0 && transform.position.x > -paddleXbound)
        {
        transform.position += Vector3.right * movementHorizontal * speed * Time.deltaTime;
        }
         
    }
}
