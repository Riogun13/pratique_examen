using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject helice;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotation();

    }

    private void Rotation()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            helice.transform.Rotate(new Vector3(0, 0, 10));
        }
    }
}
