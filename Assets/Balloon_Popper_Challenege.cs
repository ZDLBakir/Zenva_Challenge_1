using UnityEngine;
using UnityEngine.InputSystem;
using System; 
public class Balloon_Popper_Challenege : MonoBehaviour
{
    public int clicksToPop;
    //InputAction increaseBalloonSize;
    public GameObject balloon;
    public bool clicked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clicksToPop = 5;
        //increaseBalloonSize = InputSystem.actions.FindAction("Attack");
      
    }

    // OnMouseDown is called for on mosue press
    void OnMouseDown()
    {
        clicked = false;
        //clicked = increaseBalloonSize.IsPressed();
      /* if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
            Debug.Log("Mouse is down"); 
        }*/

            if (clicksToPop == 0)
            {
                Destroy(balloon); 
            }
           
   clicksToPop -= 1;
   balloon.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
               
          
                
            

        

        Debug.Log(clicksToPop);
    }
}
