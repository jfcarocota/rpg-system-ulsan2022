using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa : Hero
{

    protected override void Movement()
    {
        base.Movement();
        anim.SetFloat("move", Mathf.Abs(Axis.magnitude));
    }
}
