using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BrickDespawn : Despawn
{

    [SerializeField ] public BrickCtrl brickCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickctrl();
    }


    protected virtual void LoadBrickctrl()
    {
        if( this.brickCtrl!= null) return;
        this.brickCtrl =transform.parent.GetComponent<BrickCtrl>();
        Debug.LogWarning(transform.name+" :  LoadBrickCtrl",gameObject);
    }

    protected override bool   CanDespawn()
    {
        if(this.brickCtrl.brickDamReceiver.isDead ) return true;
        return false;
    }

}
