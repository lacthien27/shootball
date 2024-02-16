using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDamReceiver : DamageReceiver 
{
    

  
    [SerializeField] protected  BrickCtrl brickCtrl;

   

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickCtrl();
    }



     protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl !=null) return;
        this.brickCtrl =  transform.parent.GetComponent<BrickCtrl>();
        Debug.LogWarning(transform.name+": LoadBrickCtrl ", gameObject);
    }

    protected override void ReBorn()
    {
        this.hpMax= this.brickCtrl.brickSO.hpMax;
        base.ReBorn();
        
    }

    protected override void OnDead()
    {
        base.OnDead();
        this.OnDeadDrop();
        this.OnDeadFX();

    }

    protected virtual void OnDeadDrop()
    {
        Vector3 dropPos = transform.parent.position;
        dropPos.z =-1;                                   // quan trọng
        Quaternion dropRot = transform.parent.rotation;
    
        ItemDropSpawner.instance.Drop(this.brickCtrl.brickSO.dropList,dropPos,dropRot);
        
    }

    protected virtual void OnDeadFX()
    {
        
    }

    //  get name of effect when dead 
    // protected virtual  string GetOnDeadFXName()
    // {
    //     return 
    // }




}
