using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonPlayer : ButtonBase

{
    [SerializeField] public static ButtonPlayer instance;

   
    protected override void Start()
    {
        ButtonPlayer.instance= this;

        base.Start();
        this.LoadColor();


    }
    protected virtual void LoadColor()
    {
    image.color= new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }
   
    public override void OnClick()
    {
        this.isPress =1;
        
        
      
    }
     protected override void GetMouse()
    {               
        this.timeStart +=Time.fixedDeltaTime;

        if(Input.GetMouseButtonDown(0))
        {          
            if(this.timeStart <=this.timeLimit) return;
            this.timeStart =0;

            this.isShooting=1;
            Debug.LogWarning(this.isShooting);
            

    

        }
    }
                        
void Update() 
{
   transform.parent.position = GameCtrl.instance.playerCtrl.transform.position;    
}

}

