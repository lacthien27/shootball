using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : ThienMonoBehaviour
{

    [SerializeField] public PlayerCtrl playerCtrl;

    [SerializeField] public bool isPress = false;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();

    }

    protected virtual void LoadPlayerCtrl()
    {
        if(this.playerCtrl !=null) return;
        this.playerCtrl =GetComponentInParent<PlayerCtrl>();
        Debug.LogWarning(transform.name+":LoadPlayerCtrl",gameObject);
    }

    void Update()
    {
       this.IsPress();
      
    }


    
    public  virtual bool IsPress()
    {   
        //if( thỏa điều kiện khi lụm đc item)  hoặc mới bắt đầu chơi thì mới sài được cái này


        this.isPress=  GameCtrl.instance.uICtrl.buttonPlayer.isPress==1; 
        return this.isPress;
    }

  


}
