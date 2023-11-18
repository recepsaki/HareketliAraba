using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void proje2(int sayi1, int sayi2)
    {
        ArrayList Listem = new ArrayList();
        for (int i = sayi1; i <= sayi2; i++)
        {
            Listem.Add(i);
        }
        string listeninTamamý = "";
        string ikiyeBolum = "";
        string uceBolum = "";
        string dordeBolum = "";
        string beseBolum = "";
        foreach (int i in Listem)
        {
            listeninTamamý += " - " + i;
            if (i % 2 == 0)
            {
                ikiyeBolum += " - " + i;
            }
            if (i % 3 == 0)
            {
                uceBolum += " - " + i;
            }
            if (i % 4 == 0)
            {
                dordeBolum += " - " + i;
            }
            if (i % 5 == 0)
            {
                beseBolum += " - " + i;
            }
        }
        print("Listenin Tamamý:" + listeninTamamý);
        print("ikiye bölünenler" + ikiyeBolum);
        print("üçe bölünenler" + uceBolum);
        print("dörde bölünenler" + dordeBolum);
        print("Beþe Bölünenler " + beseBolum);

    }
    void Start()
    {
        proje2(20, 60);
    }

}




