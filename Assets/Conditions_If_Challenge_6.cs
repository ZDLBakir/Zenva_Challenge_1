using UnityEngine;

public class Conditions_If_Challenge : MonoBehaviour
{
    string countryName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countryName = "LA";
        if (countryName == "France")
        {
            Debug.Log("It's France");
        }
        else
        {
            Debug.Log("It's Not France");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
