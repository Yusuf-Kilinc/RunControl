using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;
    public Vector3 Target_Ofset;
    void Start()
    {
        Target_Ofset = transform.position - Target.position;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position + Target_Ofset, .125f);
    }
}
