using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyReflections : MonoBehaviour
{
    [Range(0f, 500f)]
    public float rayDist = 50f;

    void Update()
    {

    }

    private void occlusionRaycast()
    {
        RaycastHit objectHit1;
        RaycastHit objectHit2;
        RaycastHit objectHit3;
        RaycastHit objectHit4;
        RaycastHit objectHit5;
        RaycastHit objectHit6;


        Vector3 fwd = this.transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(this.transform.position, fwd, out objectHit1, rayDist))
        {

        }

        Vector3 bck = this.transform.TransformDirection(Vector3.back);
        if (Physics.Raycast(this.transform.position, bck, out objectHit2, rayDist))
        {

        }

        Vector3 lft = this.transform.TransformDirection(Vector3.left);
        if (Physics.Raycast(this.transform.position, lft, out objectHit3, rayDist))
        {

        }

        Vector3 rgt = this.transform.TransformDirection(Vector3.right);
        if (Physics.Raycast(this.transform.position, rgt, out objectHit4, rayDist))
        {

        }

        Vector3 dwn = this.transform.TransformDirection(Vector3.down);
        if (Physics.Raycast(this.transform.position, fwd, out objectHit5, rayDist))
        {

        }

        Vector3 up = this.transform.TransformDirection(Vector3.up);
        if (Physics.Raycast(this.transform.position, fwd, out objectHit6, rayDist))
        {

        }
    }
}