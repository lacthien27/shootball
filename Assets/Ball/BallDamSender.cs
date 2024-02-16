using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class BallDamSender : DamageSender
{
 

    [SerializeField] public  BallCtrl ballCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBallCtrl();
    }

    protected virtual void LoadBallCtrl()
    {
        if(this.ballCtrl!=null) return;
        this.ballCtrl =GetComponentInParent<BallCtrl>();
        Debug.LogWarning(transform.name+ ": LoadBallCtrl",gameObject); 
    }


   
}
