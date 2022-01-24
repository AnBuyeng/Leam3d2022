using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamSongController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shoot(new Vector3(0, 200, 1000));
    }

    public void Shoot(Vector3 dir)
    {
        this.GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<ParticleSystem>().Play();
    }
}
