using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public ParticleSystem explosionParticles;
    public Camera cam;
    public RaycastHit hitInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.CompareTag("ScoreUp"))
                {
                    Instantiate(explosionParticles, hitInfo.transform.position, explosionParticles.transform.rotation);
                    Destroy(hitInfo.transform.gameObject);
                }
            }
        }
    }
}
