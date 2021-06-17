using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLoade : MonoBehaviour
{

    public BoxCollider boxColldier;

    // Start is called before the first frame update
    void Start()
    {
        var selfCollider = GetComponent<BoxCollider>();
        selfCollider = boxColldier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
