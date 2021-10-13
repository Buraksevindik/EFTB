using UnityEngine;

public class Projectile : MonoBehaviour
{

     void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.tag=="Player")
        {
            Destroy(info.gameObject);
            Destroy(this.gameObject);
        }
        else if (info.collider.tag!="Shooter")
        {
            Destroy(this.gameObject);
        }
    }
}
