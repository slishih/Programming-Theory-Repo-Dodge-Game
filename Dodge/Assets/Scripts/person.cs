using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : vehicalBase
{
    int switchRot = 1;
    public override void rotEnemy()
    {
        if (switchRot > 0)
        {
            transform.Rotate(0, 10, 0);
        }
        else { transform.Rotate(0, -20, 0); }
        
        switchRot = switchRot * -1;

    }
}
