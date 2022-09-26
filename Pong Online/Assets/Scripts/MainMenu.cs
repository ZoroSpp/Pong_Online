using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void online()
    {
        SceneManager.LoadScene("OnlineLoad");
    }
    public void offline()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void endgame()
    {
        Debug.Log("Hellit");
        Application.Quit();
    }
}
