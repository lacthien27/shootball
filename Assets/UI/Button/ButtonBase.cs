using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;
using Unity.VisualScripting;

public abstract class ButtonBase : ThienMonoBehaviour
{
   [Header("button Base")]

     public  float timeStart =0f;
    public  float timeLimit =5f;
    [SerializeField] public int isPress =0;

    [SerializeField] public int  isShooting = 0 ;

    [SerializeField] public Button  button;

    [SerializeField] public Image image;
    protected override void Start()
    {
        base.Start();
        GameCtrl.instance.playerCtrl.playerMovement.gameObject.SetActive(false);
        this.AddOnClickEvent();
    }

    protected  void FixedUpdate()
    {
        this.GetMouse();
        
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButton();
        this.LoadImage();
    }
    protected  virtual void LoadImage()
    {
        if(this.image != null) return;
       this.image=GetComponent<Image>();
        Debug.LogWarning( transform.name+"loadImage",gameObject);
    }

    protected virtual void LoadButton()
    {
        if(this.button != null) return;
       this.button=GetComponent<Button>();
        Debug.LogWarning( transform.name+"loadButton",gameObject);

    }

     protected virtual void AddOnClickEvent()
    {
            this.button.onClick.AddListener(this.OnClick); 
    }
    public abstract  void OnClick();

    protected virtual void GetMouse()
    {
            // for children  
    }










}
