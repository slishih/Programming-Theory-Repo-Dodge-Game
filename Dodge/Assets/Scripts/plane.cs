using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane :vehicalBase
{
    int switchRot = 1;
    public override void rotEnemy()
    {
        transform.Rotate(0, 0, 5 * switchRot);
        switchRot = switchRot * -1;

    }
}
