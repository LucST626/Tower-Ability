using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Transform one;
    [SerializeField] Transform two;
    [SerializeField] Transform three;
    void Start()
    {
        
    }

    void Update()
    {
        one.transform.Rotate(0, 0, 0.1f);
        two.transform.Rotate(0, 0, 0.2f);
        three.transform.Rotate(0, 0, 0.05f);
    }
}
