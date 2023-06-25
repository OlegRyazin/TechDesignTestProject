using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    [SerializeField]
    private GameObject button;

    private void Start()
    {
        button.SetActive(false);
    }

    private void OnMouseDown()
    {
        button.SetActive(true);
    }
}
