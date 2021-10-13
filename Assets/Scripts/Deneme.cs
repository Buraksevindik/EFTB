using UnityEngine;

public class Deneme : MonoBehaviour
{
    object go;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            go = Instantiate(Resources.Load("Prefab/Wall"), transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            Destroy((Object)go, 2);
        }
       
    }
    private void OnTriggerStay2D(Collider2D colision)
    {
        if (colision.tag == "Player")
        {
            go = Instantiate(Resources.Load("Prefab/Wall"), transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            Destroy((Object)go, 0.1f);
        }

    }

}
