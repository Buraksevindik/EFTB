using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Direction pointingDirection;
    [SerializeField] float projectVelocity, shoottime;
    [SerializeField]  GameObject projectile;
    void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot() 
    {
        GameObject go = new GameObject();
        while (true)
        {
            yield return new WaitForSeconds(shoottime);
            switch (pointingDirection)
            {
                case Direction.East:
                    SpawnBullet(go, 1, projectVelocity);
                    break;
                case Direction.West:
                    SpawnBullet(go, -1, projectVelocity);
                    break;
                case Direction.North:
                    SpawnBullet2(go, 1, projectVelocity);
                    break;
                case Direction.South:
                    SpawnBullet2(go, -1, projectVelocity);
                    break;


            }
        }
    }
    void SpawnBullet(GameObject go, int dir,float speed)
    {
        go = Instantiate(projectile, transform.position + new Vector3(dir, 0, 0), Quaternion.identity);
        go.GetComponent<Rigidbody2D>().velocity = new Vector2(dir*speed, 0);
    }
    void SpawnBullet2(GameObject go, int dir, float speed)
    {
        go = Instantiate(projectile, transform.position + new Vector3(0, dir, 0), Quaternion.identity);
        go.GetComponent<Rigidbody2D>().velocity = new Vector2( 0, dir * speed);
    }


}

