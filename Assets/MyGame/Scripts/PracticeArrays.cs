using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    private int[] array1 = new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    private string[] array4 = new string[10];
    [SerializeField]
    private GameObject[] arrayColorImagesRed;

    public void Start()
    {
        arrayColorImagesRed = GameObject.FindGameObjectsWithTag("RedImage");    

        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        Debug.Log("Element 0 von array 1 hat den Wert: " + array1[0]);
        Debug.Log("Element 0 von array 2 hat den Wert: " + array2[0]);
        Debug.Log("Element 0 von array 3 hat den Wert: " + array3[0]);
        Debug.Log("Element 0 von array 4 hat den Wert: " + array4[0]);
        Debug.Log("Name des ersten GameObjects: " + arrayColorImagesRed[0].name);

        Debug.Log("Das letzte Element von array 1 hat den Wert: " + array1[array1.Length - 1]);
        Debug.Log("Das letzte Element  von array 2 hat den Wert: " + array2[array2.Length - 1]);
        Debug.Log("Das letzte Element  von array 3 hat den Wert: " + array3[array3.Length - 1]);
        Debug.Log("Das letzte Element  von array 4 hat den Wert: " + array4[array4.Length - 1]);
        Debug.Log("Name des letzten GameObjects: " + arrayColorImagesRed[arrayColorImagesRed.Length - 1].name);

        PrintElements(array4);
    }

    private void PrintElements(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            Debug.Log("Element Nummer: " + i + " hat den Wert " + stringArray[i]);
        }
    }
}
        