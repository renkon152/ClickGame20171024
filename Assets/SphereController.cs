using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void Start()
    {
        shoot(new Vector3(0, 200, 2000));
    }
}
	// Use this for initialization

