using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * this.Speed * Time.deltaTime);
        if(this.transform.position.y < -1.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
