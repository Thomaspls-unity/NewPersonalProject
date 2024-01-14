using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public ParticleSystem explosionParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(explosionParticles, transform.position, explosionParticles.transform.rotation);
        Destroy(gameObject);
    }
}
