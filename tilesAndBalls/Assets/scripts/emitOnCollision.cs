using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(ParticleSystem))]
public class emitOnCollision : MonoBehaviour
{

    public ParticleSystem ps;
    public bool moduleEnabled;
    // Start is called before the first frame update
    void Start()
    {
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        ps.Play();
    }

    //private void OnCollisionExit(Collision collision)
    //{
      //  ps.Pause();
    //}

}