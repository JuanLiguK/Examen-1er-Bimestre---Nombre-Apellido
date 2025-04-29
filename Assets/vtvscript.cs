using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vtvscript : MonoBehaviour
{
    public string Patente;
    public int Año;
    public float Km_recorridos;
    public float Vencimiento;
    public float Hc;



    // Start is called before the first frame update
    void Start()
    {
      if (Patente == "")
        {
            Debug.Log("La patente no puede estar vacia.");
            Debug.Log("VTV no aprobada.");
                return;
        } else if (Año <= 1900 || Año >= 2025)
        {
            Debug.Log("El año de fabricacion es incorrecto.");
            Debug.Log("VTV no aprobada.");
            return;
        } else if (Km_recorridos < 0)
        {
            Debug.Log("Los Km totales no pueden ser menores a cero.");
            Debug.Log("VTV no aprobada.");
            return;
        } else if (Vencimiento >= 2025 || Vencimiento < Año)
        {
            Debug.Log("El vencimiento de la VTV anterior es invalido.");
            Debug.Log("VTV no aprobada.");
            return;
        } else if (Hc < 5)
        {
            Debug.Log("El Hc ppm es demasiado bajo.");
            Debug.Log("VTV no aprobada.");
            return;
        } else if (Hc > 100)
        {
            Debug.Log("El Hc ppm no puede ser mayor a 100");
            Debug.Log("VTV no aprobada.");
            return;
        };

      if(Km_recorridos/Año <=10000)
        {
            Debug.Log("Se le otorga una VTV de 2 años.");
        } else if (Km_recorridos/Año >10000)
        {
            Debug.Log("Se le otorga una VTV de 1 año.");
        }
      ;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
