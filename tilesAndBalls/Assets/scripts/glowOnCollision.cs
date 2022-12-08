using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowOnCollision : MonoBehaviour
{

    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        mr.material.EnableKeyword("_EMISSION");
    }

    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
      mr.material.DisableKeyword("_EMISSION");
    }


}
