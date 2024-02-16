using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class UICtrl : ThienMonoBehaviour
{
   
     [SerializeField] public ButtonPlayer buttonPlayer;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButtonPlayer();
    }

  
    protected virtual void LoadButtonPlayer()
    {
        if(this.buttonPlayer !=null) return;
        this.buttonPlayer = GameObject.FindAnyObjectByType<ButtonPlayer>();
        Debug.LogWarning(transform.name+" : LoadButtonPlayer",gameObject);
    }


}
