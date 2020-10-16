using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float ForceMultiplier;
    private float _moveHorizontal, _moveVertical;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = gameObject.GetComponent <Rigidbody>();
    }
    private void FixedUpdate()
    {
        _moveHorizontal = Input.GetAxis("Horizontal")* ForceMultiplier;
        _moveVertical = Input.GetAxis("Vertical") * ForceMultiplier;
        _rigidbody.AddForce(x:_moveHorizontal, y:0, z:_moveVertical);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "ScoreObject")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Hazard1"))
        {
            Debug.Log(message: "OUCH!");
        }
    }
}
