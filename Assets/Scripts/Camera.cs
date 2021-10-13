using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform player;
    Transform square;
    [SerializeField] Vector3 offset;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {        
        try
        {
            transform.position = player.position+ offset;
        }
        catch (System.Exception)
        {

            square = GameObject.Find("Square").GetComponent<Transform>();
            transform.position = square.position+ offset;
        }
    }
}
