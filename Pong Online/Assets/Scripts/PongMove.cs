using System.Collections;
using UnityEngine;

public class PongMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D pong;
    [SerializeField] float force;
    bool start;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 dir;
        dir.x = Random.Range(1,100)*0.1f;
        dir.y = Random.Range(-10, 10) * 0.1f;
        pong.AddForce(dir*force);   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log ("Hello");
        if (col.collider.tag == "Player")
        {
            force = force * 1.1f;
            if (col.collider.name == "Player 1")
            {
                //pong.AddForce(transform.right * force / 20 * Time.deltaTime);
            }
            else
            {
                //pong.AddForce(transform.right * force * (-1) / 20 * Time.deltaTime);
            }
        }
        else if (col.collider.tag == "Post")
        {
            if (col.collider.name == "Player1post")
                GameObject.Find("Score").GetComponent<Score>().score2++;
            else
                GameObject.Find("Score").GetComponent<Score>().score1++;
            Vector2 a = transform.position;
            a.x = 0;
            a.y = 0;
            transform.position = a;
            //waiter();
            //WaitForSeconds;
        }
    }
        IEnumerator waiter()
    {
        Debug.Log("Car");
        yield return new WaitForSeconds(2);
        //new WaitForSeconds(2);
        Debug.Log("wait");
    }

    private void WaitForSecondsRealtime(int v)
    {
        throw new System.NotImplementedException();
    }
    /*private void OnCollisionExit2D(Collision2D coll)

{
   Debug.Log("hell");
}*/
}
