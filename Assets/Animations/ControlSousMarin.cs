using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ControlSousMarin : MonoBehaviour
{
    [SerializeField] private bool _speedSpeed;
    [SerializeField] private float _vitessePromenade;
    private Rigidbody _rb;
    private Vector3 directionInput;

    [SerializeField] private float _modifierAnimTranslation;
    private Animator _animator;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void OnPromener(InputValue directionBase)
    {
        Vector3 directionAvecVitesse = directionBase.Get<Vector3>() * _vitessePromenade;
        directionInput = new Vector3(0f, directionAvecVitesse.z, directionAvecVitesse.y);
        Debug.Log("Boo DUMBASS");

    }

    void OnSpeed()
    {
        _vitessePromenade = 2;
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mouvement = directionInput;

        _rb.AddForce(mouvement, ForceMode.VelocityChange);
    }
}
