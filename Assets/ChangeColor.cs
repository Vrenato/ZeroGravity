using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    //public GameObject astronaut;
    public Color newColor;
    public Color newColor2;
    public Color newColor3;
    public Color newColor4;
    public Color newColor5;
    public Color newColor6;
    public Color newColor7;
    public Color newColor8;
    public Material[] materials;

    private Renderer objectRenderer;
    

    public void ChangeMaterialColorRed()
    {

        
        foreach (Material material in materials)
        {
            material.color = newColor;
        }
    }
     public void ChangeMaterialColorGreen()
    {

        
        foreach (Material material in materials)
        {
            material.color = newColor2;
        }
    }
    public void ChangeMaterialColorBlue()
    {


        foreach (Material material in materials)
        {
            material.color = newColor3;
        }
    }
    public void ChangeMaterialColorYellow()
    {


        foreach (Material material in materials)
        {
            material.color = newColor4;
        }
    }
    public void ChangeMaterialColorBlack()
    {


        foreach (Material material in materials)
        {
            material.color = newColor5;
        }
    }
    public void ChangeMaterialColorWhite()
    {


        foreach (Material material in materials)
        {
            material.color = newColor6;
        }
    }
    public void ChangeMaterialColorOrange()
    {


        foreach (Material material in materials)
        {
            material.color = newColor7;
        }
    }
    public void ChangeMaterialColorPink()
    {


        foreach (Material material in materials)
        {
            material.color = newColor8;
        }
    }
}
