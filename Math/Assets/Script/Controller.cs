using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Controller : MonoBehaviour
{
    

    [SerializeField]
    public InputField inputC1;
    public InputField inputC2;
    public InputField inputFC1;
    public InputField inputFC2;
    public InputField inputANS1;
    public InputField inputANS2;

    public Text text;

    public static double C1;
    public static double C2;
    public static double FC1;
    public static double FC2;

    
    

    public void Awake() 
    {
        text.text = "Put the number between 0.00 - 1.00";
        
    }
    public void GetInputC1(string vC1)
    {
        double mC1 = double.Parse(vC1);
        C1 = mC1;
    }

    public void GetInputC2(string vC2)
    {
        double mC2 = double.Parse(vC2);
        C2 = mC2;
    }

    public void GetInputFC1(string vFC1)
    {
        double mFC1 = double.Parse(vFC1);
        FC1 = mFC1;
    }

    public void GetInputFC2(string vFC2)
    {
        double mFC2 = double.Parse(vFC2);
        FC2 = mFC2; 
    }

    public void ShowANSCF()
    {        
        inputANS1.text = Calculator.CF1.ToString();
        inputANS2.text = Calculator.CF2.ToString();
    }
}
