using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveOffline : MonoBehaviour
{
    [SerializeField] float speed;
    float ypos = 0f;
    Vector2 pos;
    //bool uplim, downlim;
    // Start is called before the first frame update
    void Start()
    {
        //uplim = false;
        //downlim = false;
        ypos = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        ypos = transform.position.y;
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
        {
            if (transform.position.y<=5)
                ypos = ypos + speed * Time.deltaTime;
            pos.y = ypos;
            transform.position = pos;
        }
        else if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            if (transform.position.y >= -5)
                ypos = ypos - speed * Time.deltaTime;
            pos.y = ypos;
            transform.position = pos;

        }
    }

}

