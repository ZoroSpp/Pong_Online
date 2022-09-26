using UnityEngine;
using Photon.Pun;
public class PlayerMove : MonoBehaviour
{
    PhotonView view;
    //hello
    [SerializeField] float speed;
    float ypos=0f;
    Vector2 pos;
    bool uplim, downlim;
    // Start is called before the first frame update
    void Start()
    {
        uplim = false;
        downlim = false;
        ypos = transform.position.y;
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            pos = transform.position;
            ypos = transform.position.y;
            if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
            {
                if (!uplim)
                    ypos = ypos + speed * Time.deltaTime;
                pos.y = ypos;
                transform.position = pos;
            }
            else if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
            {
                if (!downlim)
                    ypos = ypos - speed * Time.deltaTime;
                pos.y = ypos;
                transform.position = pos;

            }
        }
    }
    /*private void OnCollisionStay(Collision collision)
    {
        Debug.Log("dell");
    }
    private void OncollisionEnter2D(Collision2D cold)
    {
        //Debug.Log("hello");
        if (cold.collider.name == "UpperBoundary")
            uplim = true;
        else if (cold.collider.name == "LowerBoundary")
            downlim = true;
    }
   private void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("GO");
        if (col.collider.name == "UpperBoundary")
            uplim = false;
        else if (col.collider.name == "LowerBoundary")
            downlim = false;
    }*/
}
