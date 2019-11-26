using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDBar : MonoBehaviour
{
    public Image cdImage;
    public float cdTime = 2.0f;
    bool onCool;

    // Start is called before the first frame update
    void Start()
    {
        cdImage.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float projLim = GameObject.Find("ProjSpawn").GetComponent<Projectile>().maxProjNum;
        float curProj = GameObject.Find("ProjSpawn").GetComponent<Projectile>().curProjNum;

        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.J))
        {
            onCool = true;
        }

        if (onCool)
        {
            cdImage.fillAmount += 1 / cdTime * Time.deltaTime;

            if (cdImage.fillAmount >= 1)
            {
                cdImage.fillAmount = 0;
                onCool = false;
            }
        }
    }
}
