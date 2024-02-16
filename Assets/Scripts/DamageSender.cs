using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : ThienMonoBehaviour
{
    [SerializeField] public  int damage =1;


    public virtual void LoadDamDeliver(Transform obj)
    {
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();

        if(damageReceiver ==null)
        {
            return;
        }
        
  
        this.LoadDamDeliver(damageReceiver);
        
        
    }

    public virtual void LoadDamDeliver(DamageReceiver damageReceiver)
    {
       damageReceiver.Deduct(this.damage);
    }
}
