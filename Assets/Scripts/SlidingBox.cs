using UnityEngine;

public class SlidingBox : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float scrollrate = 0.3f;
    void Update()
    {
        float yMove = scrollrate * Time.deltaTime;
        transform.Translate(new Vector2(yMove, 0f));
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }


}
