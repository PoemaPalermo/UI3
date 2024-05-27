using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//usuario toca btnAceptar
//Debug.Log("Por favor ingrese su contraseña");
//if contraseña == inut
//  Debug.Log("Access Granted");
//else
//  Debug.Log("Access Denied");
public class LogInMaager : MonoBehaviour
{
    public InputField contraseña;
    public string contraseñaDefualt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void botoncitoMagico()
    {
        if (contraseña.text == contraseñaDefualt)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
