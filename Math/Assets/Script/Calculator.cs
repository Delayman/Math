using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calculator : MonoBehaviour
{
    public static double hC1;
    public static double hC2;
    public static double hFC1;
    public static double hFC2;


    public static double CF1;
    public static double CF2;

    public Text TextBoxA1;
    public Text TexboxA2;
    //hi hi this'me//
/*    public double BottomHold;
    public double THoldC1;
    public double THoldC2;
*/
    //test
 /*   public double chC1;
    public double chC2;
    public double chFC1;
    public double chFC2;
*/
    void Start()
    {
        Debug.Log("Byane calculator is started");
        
    }

    void Update()
    {

        

        hC1 = Controller.C1;
        hC2 = Controller.C2;
        hFC1 = Controller.FC1;
        hFC2 = Controller.FC2;

        if( hC2 == 0 && hC1 < 1 )
        {
            hC2 = 1 - hC1;
        } else
        if ( hC2 == 0 && hC1 > 1 )
        {
            hC2 = 100 - hC1;
        }
/*      chC1 = hC1;
        chC2 = hC2;
        chFC1 = hFC1;
        chFC2 = hFC2;
*/
        CF1 = ((hFC1*hC1)/((hFC1*hC1)+(hFC2*hC2)))*100 ;
        CF2 = ((hFC2*hC2)/((hFC1*hC1)+(hFC2*hC2)))*100 ;
      
    } 

    
    
}
