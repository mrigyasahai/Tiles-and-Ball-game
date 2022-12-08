using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emit2 : MonoBehaviour
{

    public ParticleSystem ps;
    public bool moduleEnabled;
    public bool includeChildren = true;
    // Start is called before the first frame update
    void Start()
    {
        ps.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        //ps.Play();

        ps.Play(includeChildren);

        //ps.SetActive(isActive);
        //isActive = false;
    }

    //private void OnCollisionExit(Collision collision)
    //{
        //Debug.Log("OnCollisionExit");
        //ps.Pause(); 

        //ps.Pause(includeChildren); //2
        //ps.Stop(includeChildren, ParticleSystemStopBehavior.StopEmitting); //3

        //isActive = true;// 4
    //}
}
