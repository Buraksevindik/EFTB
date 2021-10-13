using UnityEngine;

public class PointPickup : MonoBehaviour
{
    [SerializeField] int point = 1;
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            FindObjectOfType<DenemeGSession>().AddToScore(point);
            Destroy(gameObject);
        }

    }

}
