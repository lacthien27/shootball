using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GunBarrelPosCtrl : ThienMonoBehaviour
{
    [SerializeField] protected MoveGunBarrel moveGunBarrel;
    [SerializeField] public Transform pointSpawnRight;
    [SerializeField]  public Transform pointSpawnLeft;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMoveGunBarrel();
        this.LoadPointSpawnLeft();
        this.LoadPointSpawnRight();

    }

    protected virtual void LoadMoveGunBarrel()
    {
         if(this.moveGunBarrel !=null) return;
        this.moveGunBarrel =GetComponentInChildren<MoveGunBarrel>();
        Debug.LogWarning(transform.name+": LoadMoveGunBarrel",gameObject);
    }

    public virtual void LoadPointSpawnRight()
    {
        if(this.pointSpawnRight !=null)return;
        this.pointSpawnRight = transform.Find("PointSpawnRight");
       

    }
    public virtual void LoadPointSpawnLeft()
    {
       // if(this.pointSpawnLeft !=null)return;
        this.pointSpawnLeft = transform.Find("PointSpawnLeft");
    }

}
