using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ENCAPSULATION
public class Animal : MonoBehaviour
{
    //ABSTRACTION
    protected Rigidbody Rb { get; set; }
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    public virtual void Jump(float force)
    {
        Rb.AddForce(Vector3.up * force);
    }
}

//INHERITANCE
public class AnimalController : Animal
{
    private float force = 5f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump(force);
        }
    }

    //POLYMORPHISM
    public override void Jump(float force)
    {
        Rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
