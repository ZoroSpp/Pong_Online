
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Scorecard,Winner;
    public int score1, score2;
    [SerializeField] PongMove PingPong;
    int stime,timer;
    short startg;
    public bool player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = false;
        startg = 0;
        PingPong.enabled =false ;
        timer = 3;
        score1 = 0;
        Scorecard.text = score1 + "-" + score2;
    }

    // Update is called once per frame
    void Update()
    {
        switch(startg)
        {
            case 0:
                
                    Winner.text = "Press Enter to start the round";
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        startg = 1;
                        stime = (int)Time.time + 3;
                    }
                    break;
                
            case 1:
                
                    if (timer > 0)
                    {
                        Winner.text = "Round starts in \n " + timer + "s";
                        timer = stime - (int)Time.time;
                    }
                    else
                    {
                        GameObject.Find("PingPong").GetComponent<PongMove>().enabled = true;
                        startg = 2;
                       
                    }
                break;
            
            case 2:
                Winner.text = "";
                break;

            default:
                    break;

           }
            
        Scorecard.text = score1 + "-" + score2;
        if(score1==10 || score2 == 10)
        {
            startg = 3;
            GameObject.Find("PingPong").GetComponent<PongMove>().enabled = false;
            Destroy(GameObject.Find("PingPong"));
            Scorecard.fontSize = 80;
            if (score1 == 10)
                Winner.text = "Player 1 wins \n Press enter ";
            else
                Winner.text = "Player 2 wins \n Press enter";
        }
        
    }
}
