using System.Collections;
using UnityEngine;

public class ExpandingBox : MonoBehaviour
{
    public int x, y, z;
    [SerializeField] float timeUnExpanded, timeExpanded;
    void Start()
    {
        StartCoroutine(ExpansionCycle());
    }
    IEnumerator ExpansionCycle() 
    {
        Object[] go = new Object[8];
        while (true)
        {
            yield return new WaitForSeconds(timeUnExpanded);
            go[0]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(1, 0, 0),Quaternion.identity);
            go[1]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(1, 1, 0), Quaternion.identity);
            go[2]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(1, -1, 0), Quaternion.identity);
            go[3]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
            go[4]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(-1, 1, 0), Quaternion.identity);
            go[5]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(-1, -1, 0), Quaternion.identity);
            go[6]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            go[7]=Instantiate(Resources.Load("Prefab/ExpandingBoxS"), transform.position + new Vector3(0, -1, 0), Quaternion.identity);
            yield return new WaitForSeconds(timeExpanded);
            for (int i = 0; i < 8; i++)
            {
                Destroy(go[i]);
            }
        }
    }
    public void sa() 
    {
        Object[] go = new Object[8];
        for (int i = 0; i < 8; i++)
        {

        }
      
    }
}
