using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public int x=1;
    public GameObject playerprefab;
    Vector3 pos;
    public void Start()
    {
        pos.x = 0;
        pos.y = 0;
        pos.z = 0;
        if (x==1)
        {
            
            pos.x =10;
            pos.y = 0;
            PhotonNetwork.Instantiate(playerprefab.name, pos, Quaternion.identity);
            GameObject.Find("Score").GetComponent<Score>().player1 = true;
            x = 2;
            Debug.Log(x);
        }
        else
        {
            Debug.Log(x);
            pos.x = -10;
            pos.y = 0;
            PhotonNetwork.Instantiate(playerprefab.name, pos, Quaternion.identity);

        }

    }
   
}
