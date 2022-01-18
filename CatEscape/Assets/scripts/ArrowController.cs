using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    private PlayerController player;
    public float radius = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, -0.1f, 0);

        if (this.transform.position.y <= -4.02f)
        {
            Destroy(this.gameObject);
        }

        Vector2 p1 = this.transform.position;   //화살표의 중점 
        Vector2 p2 = this.player.transform.position;    //플레이어의 중점 
        Vector2 dir = p2 - p1;
        float d = dir.magnitude;

        Debug.DrawLine(p1, p2, Color.red);

        //float d = Vector2.Distance(p1, p2);
        if (d < this.radius + player.radius)
        {
            //충동 했다 
            Debug.Log("충돌했다");
            Destroy(this.gameObject);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}