using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotBricks : MonoBehaviour
{

    [SerializeField]
    private Transform spawn;

    [SerializeField]
    private Transform BrickParent;

    [SerializeField]
    private GameObject Brick;

    [SerializeField]
    private int width = 20;

    [SerializeField]
    private int height = 3;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(spawn.position.x, spawn.position.y);
        for (int i = 0; i < height; i++)
        {
            pos.x = spawn.position.x; //reset x
            for (int j = 0; j < width; j++)
            {
                GameObject.Instantiate<GameObject>(Brick, pos, Quaternion.identity, BrickParent);
                pos.x += 1;
            }

            pos.y -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
