using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour 
{
    public void SahneGecis(int sahne_id) 
    {
        SceneManager.LoadScene(sahne_id);
        Time.timeScale = 1;
    }
}
