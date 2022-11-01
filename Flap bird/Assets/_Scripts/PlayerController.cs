using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rigibody;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        _rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigibody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
