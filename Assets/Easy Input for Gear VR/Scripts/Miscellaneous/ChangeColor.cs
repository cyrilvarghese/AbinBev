using UnityEngine;
using System.Collections;
using EasyInputVR.Core;

namespace EasyInputVR.Misc
{


    public class ChangeColor : MonoBehaviour
    {

        MeshRenderer myRenderer;
        Material myMaterial;
        Color originalColor;
        public GameObject deac;

        void Start()
        {
            myRenderer = this.GetComponent<MeshRenderer>();
            myMaterial = myRenderer.material;
            originalColor = myMaterial.color;
        }

        public void changeColor(ButtonClick button)
        {
            myMaterial.color = Color.green;
       
        }

        public void changeColorBack(ButtonClick button)
        {
            myMaterial.color = originalColor;
        }

        public void toggleColor()
        {
            
            if (myMaterial.color == originalColor)
            {
                myMaterial.color = Color.green;
                if (deac)
                    deac.gameObject.GetComponent<Animator>().enabled = false;
            }
                
            else
            {
                myMaterial.color = originalColor;
              //  if (deac)
                   // deac.gameObject.GetComponent<Animator>().enabled = true;
            }
               
        }
    }
}