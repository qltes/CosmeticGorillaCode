using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cosmetic;
    public bool enable;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (enable)
        {
            Cosmetic.SetActive(true);
        } else
        {
            Cosmetic.SetActive(false);
         }
    }
}
