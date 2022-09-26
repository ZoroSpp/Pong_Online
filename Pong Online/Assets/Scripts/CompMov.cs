using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompMov : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform pongpos;
    Vector2 pos;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Score").GetComponent<Score>().score1!=10 && GameObject.Find("Score").GetComponent<Score>().score2 != 10)
            pos.y = pongpos.position.y;
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);
    }
}
