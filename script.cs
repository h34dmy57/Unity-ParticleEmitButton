using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    // Start is called before the first frame update
    
    ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ps.Emit(1);
        }   
    }
}
