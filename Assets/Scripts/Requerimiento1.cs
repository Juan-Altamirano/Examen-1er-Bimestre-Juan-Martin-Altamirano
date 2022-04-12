using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requerimiento1 : MonoBehaviour
{
    public int DiasLluvia;
    public int periodoDeDias;
    public int cantidadDeUnidades;
    // Start is called before the first frame update
    void Start()
    {
        int gastoDiarioCombustible = 6;
        int costoTotalCombustible;

        periodoDeDias -= DiasLluvia;
        costoTotalCombustible = gastoDiarioCombustible * cantidadDeUnidades * periodoDeDias * 130 + (DiasLluvia * 7 * 130);

        int DiasTotales = periodoDeDias + DiasLluvia;

        if (DiasTotales > 5)
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + DiasTotales + " dias implicará un costo de " + costoTotalCombustible + " de pesos en concepto de combustible");
        }

        else if (DiasLluvia > periodoDeDias)
        {
            Debug.Log("Error. La cantidad de días de lluvia no puede sobrepasar al total de días");
        }

        else if (DiasTotales < 5)
        {
            Debug.Log("Error. La cantidad de días no puede ser menor a 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
