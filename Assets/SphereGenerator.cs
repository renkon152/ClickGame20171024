using UnityEngine;
using System.Collections;

public class SphereGenerator : MonoBehaviour
{
    public GameObject SpherePrefab;

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Sphere =
                Instatiate(SpherePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.MousePosition);
            Vector3 worldDir = ray.direction;
            Sphere.GetComponent<IgaguriController>().Shoot(
                worldDir.normalized * 2000);           
        }
	}
}
