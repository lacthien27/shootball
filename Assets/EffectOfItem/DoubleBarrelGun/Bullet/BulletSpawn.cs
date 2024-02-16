using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletSpawn : Spawner
{

    [SerializeField] public GunBarrelPosCtrl gunBarrelPosCtrl;

     public  string bulletRight = "Bullet_Right";
     public string  bulletLeft = "Bullet_Left";


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGunBarrelPosCtrl();
    }

    protected virtual void LoadGunBarrelPosCtrl()
    {
        if(this.gunBarrelPosCtrl!=null) return;
        this.gunBarrelPosCtrl = GameObject.FindAnyObjectByType<GunBarrelPosCtrl>();
        
    }

     private void FixedUpdate() 
    {
        this.Shot();    
    }

    protected virtual void Shot()
    {
        if(!this.gunBarrelPosCtrl.enabled) return;
        if(GameCtrl.instance.uICtrl.buttonPlayer.isShooting==1)
        {
          
            
        this.Spawn(this.bulletLeft,new Vector2(-0.72f,-3.88f),transform.rotation);
       this.Spawn(this.bulletRight,new Vector2(0.72f,-3.88f),transform.rotation);

        }
    }


    




}
