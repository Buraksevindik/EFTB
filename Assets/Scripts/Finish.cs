using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject player;
    public GameObject winscreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(player);
        winscreen.SetActive(true);
        Time.timeScale = 0;
    }
}
