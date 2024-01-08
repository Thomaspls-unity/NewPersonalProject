using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnim;
    private ParticleSystem doorParticleSystem;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
        doorParticleSystem = GetComponentInChildren<ParticleSystem>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", false);
        }
    }

    public void DoorOpen()
    {
        Debug.Log("Door is open");
        doorParticleSystem.Play();
        audioManager.PlaySFx("DOOR_OPEN");
    }

    public void DoorClose()
    {
        Debug.Log("Door is closed");
        audioManager.PlaySFx("DOOR_CLOSE");
    }
}
