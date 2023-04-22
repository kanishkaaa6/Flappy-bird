using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
   // public float time=5f;
    public float min = -2;
    public float max = 2;
    //public player plyr;
   
    private void OnEnable()
    {
           InvokeRepeating("spwan", 0.5f, 1f);
    }
    private void OnDisable()
    {
        CancelInvoke("spwan");
    }
   /* private void Update()
    {
        if(plyr.isDead)
        {
            CancelInvoke("spwan");
        }
    }*/
    void spwan()
    {
        GameObject pipes=Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position = Vector2.up * Random.Range(min, max);
    }
}
