using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    GameObject plyr;
    RaycastHit2D hit;
    public GameObject DeathScreen;
    private void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.tag == "Trap")
        {
            Destroy(plyr);
            DeathScreen.SetActive(true);
            if (hit != null)
            {
                Destroy(GameObject.Find("Player"));
                DeathScreen.SetActive(true);
            }
        }
    }
}
