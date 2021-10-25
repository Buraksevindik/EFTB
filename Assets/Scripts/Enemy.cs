using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public Vector3 startpos1;
    public Vector3 startpos2;
    public GameObject enemy;
    public GameObject DeathScreen;
    void Update()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, startpos1, Time.deltaTime * speed);
        if (enemy.transform.position == startpos1)
        {
            startpos1 = startpos2;
            startpos2 = enemy.transform.position;
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            DeathScreen.SetActive(true);
        }
    }
}
