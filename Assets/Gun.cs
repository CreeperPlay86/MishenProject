using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Gun : MonoBehaviour
{
    public float damage = 25f;
    public SteamVR_Action_Boolean fireAction;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform grabOffset;

    public Vector3 leftHandOffset = new Vector3(0.246f, 0.092f, 0.064f);
    public Vector3 rightHandOffset = new Vector3(-0.246f, 0.092f, 0.064f);

    private Interactable interactable;

    // Start is called before the first frame update
    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            if (interactable.attachedToHand.handType == SteamVR_Input_Sources.LeftHand)
            {
                grabOffset.localPosition = leftHandOffset;
                grabOffset.localRotation = Quaternion.Euler(0, 0, 90);
            }
            if (interactable.attachedToHand.handType == SteamVR_Input_Sources.LeftHand)
            {
                grabOffset.localPosition = rightHandOffset;
                grabOffset.localRotation = Quaternion.Euler(0, 0, -90);
            }

            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (fireAction[source].stateDown)
            {
                Shoot();
            }
        }
    }
    
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(barrelLocation.position,barrelLocation.forward, out hit))
        {
            if (hit.transform.GetComponent<Damageble>() != null)
            {
                hit.transform.GetComponent<Damageble>().TakeDamage(damage);
                Debug.Log(transform.name);
            }
        }

        GameObject tempFlash;
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
        Destroy(tempFlash, 0.5f);
    }
}


