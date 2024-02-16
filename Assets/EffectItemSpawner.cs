using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectItemSpawner :Spawner
{
  public static EffectItemSpawner instance;


  protected override void Awake()
    {
        base.Awake();
        if(EffectItemSpawner.instance !=null) Debug.LogWarning("only 1 dropManager");
        EffectItemSpawner.instance =this;
    }

    public virtual void turnOnObject(GameObject nameItem)
    {
        nameItem.SetActive(true);
    }
}
