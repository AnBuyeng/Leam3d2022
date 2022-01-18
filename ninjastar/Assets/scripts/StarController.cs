using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private float speed;
    private int starPos;
    private int endPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0f, 0.1f, 0f);
        //if (Input.GetMouseButtonDown(0))
        //{ 
            
        //}
    }
}
