using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnempodia : MonoBehaviour
{
    public GameObject empodio;
    public float keno;
    public float stpt;
    public controls controls;
    void Start()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
      
        while(controls.hit == false)
        {
            float ym = Random.Range(-9.5f,-1.5f);

            Instantiate(empodio, new Vector3(stpt, ym, 0), Quaternion.identity);
            Instantiate(empodio, new Vector3(stpt, ym+10+keno, 0), Quaternion.identity);

            yield return new WaitForSeconds(3);
        }
        
    }
    
}
