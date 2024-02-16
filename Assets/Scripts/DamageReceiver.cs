using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : ThienMonoBehaviour
{
    [SerializeField] public int hpMax =0;
    [SerializeField] public int hp = 0;

     [SerializeField] public bool isDead = false;


    protected override void OnEnable()
    {
        this.ReBorn();
    }
    protected override void ResetValue()
    {
                base.ResetValue();
                this.ReBorn();

    }
    protected virtual void ReBorn()
    {
    
        this.hp =this.hpMax;
        this.isDead = false;

        
    }

    public virtual void Deduct(int deduct)
    {
        if (this.isDead) return;
        this.hp -= deduct;
        
        if (this.hp < 0) this.hp = 0;
        this.CheckIsDead();
    }
    protected virtual bool IsDead()
    {
        return this.hp <= 0;     // need study more
    }

    protected virtual void CheckIsDead()
    {
        if (!this.IsDead()) return;  // Check to see if it's dead or not v , if yet  go to the next step
        this.isDead = true;
        this.OnDead();
    }

    protected virtual void OnDead()
    {
      
    }


}
