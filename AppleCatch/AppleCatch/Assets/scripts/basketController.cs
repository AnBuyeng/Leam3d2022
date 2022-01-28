using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    private AudioSource aud;
    private GameDirtor director;

    private void Start()
    {
        this.aud = this.GetComponent<AudioSource>();
        this.director = GameObject.FindObjectOfType<GameDirtor>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.y);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("¿‚æ“¥Ÿ");

        if (other.tag.Equals("Apple"))
        {
            Debug.Log("Apple");
            this.aud.PlayOneShot(this.appleSE);
            this.director.GetApple();
        }
        else if (other.tag.Equals("bomb"))
        {
            Debug.Log("bomb");
            this.aud.PlayOneShot(this.bombSE);
            this.director.GetBomb();
        }
        Destroy(other.gameObject);
    }
}
