using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private bool hasCoin = false;
    private bool availablePickup = false;

    private Transform currentPickupAvailable;

    [SerializeField] private Transform pickupTransform;

    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (availablePickup)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickupCoin();
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            DropItem();
        }
    }

    public void MakeItemAvailable(Transform coinToPickup)
    {
        currentPickupAvailable = coinToPickup;
        availablePickup = true;
        Debug.Log("Available for pickup!");
    }

    public void MakeItemUnavailable()
    {
        currentPickupAvailable = null;
        availablePickup = false;
        Debug.Log("Item no longer available to pickup");
    }

    public void PickupCoin()
    {
        currentPickupAvailable.position = pickupTransform.position;
        currentPickupAvailable.SetParent(pickupTransform);
        hasCoin = true;
        Debug.Log("Item has been picked up!");
        audioManager.PlaySFx("PICKUP_ITEM");
    }

    private void DropItem()
    {
        if(currentPickupAvailable != null)
        {
            currentPickupAvailable.SetParent(null);
            hasCoin = false;
            audioManager.PlaySFx("DROP_ITEM");
        }
    }

    public bool HasCoin()
    {
        return hasCoin;
    }
}
