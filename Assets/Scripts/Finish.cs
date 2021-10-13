using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject player;
    public void Start()
    {
        ////Time.timeScale = 1;
    }
    public GameObject winscreen;
    //public void SahneGecis(int sahne_id = 1)
    //{
    //    SceneManager.LoadScene(sahne_id);
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        //SahneGecis();
        Destroy(player);
        winscreen.SetActive(true);
        Time.timeScale = 0;
    }
}
