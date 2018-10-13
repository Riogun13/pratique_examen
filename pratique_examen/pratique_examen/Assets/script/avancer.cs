using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avancer : MonoBehaviour {
    public Rigidbody avionRigidBody;
    [SerializeField] public float Force;
    [SerializeField] public float Trust = 20;
    [SerializeField] public float pointForce = 2;
    // Use this for initialization
    void Start () {
        avionRigidBody = GetComponent<Rigidbody>(); // utiliser et retrouver un component d'un gameobject

        //respawns = GameObject.FindGameObjectsWithTag("Respawn"); /utiliser un tag
    }

    // Update is called once per frame
    void Update () {
        ManageInputVertivcal();
        ManageInputHorizontal();
    }

    private void ManageInputVertivcal()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            avionRigidBody.AddForceAtPosition(new Vector3(0, 0, Trust), (new Vector3(pointForce, 0, 0)));
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            avionRigidBody.AddForceAtPosition(new Vector3(0, 0, -Trust), (new Vector3(pointForce, 0, 0)));
        }
    }

    private void ManageInputHorizontal()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            avionRigidBody.AddForce(new Vector3(0, Trust, 0));
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            avionRigidBody.AddForce(new Vector3(0, -Trust, 0));
        }
    }
}
