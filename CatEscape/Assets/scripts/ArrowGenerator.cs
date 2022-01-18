using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // 매 프레임 마다 경과 시간을 누적
        if (this.delta >= this.span) //1.0보다 크면
        {
            this.delta = 0;

            GameObject go = Instantiate<GameObject>(this.arrowPrefab); //프리팹을 인스턴스화

            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
