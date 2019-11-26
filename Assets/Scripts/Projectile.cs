using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projSpawn, banana, wine, laundry;
    public float launchSpeed;
    private float vx, vy;
    public Rigidbody2D rb;
    public float maxProjNum, curProjNum, timeDelay;
    public bool onCool = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void DestroyProjectile(GameObject gameO)
    {
        Destroy(gameO, timeDelay);
        StartCoroutine(ResetDelay());
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone;
        vx = Input.GetAxisRaw("Horizontal");
        vy = rb.velocity.y;

        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.J)) && !onCool && curProjNum < maxProjNum)
        {
            curProjNum += 1;
            float randCheck = Random.Range(0.0f, 10.0f);

            if (randCheck >= 0.0f && randCheck <= 8.5f)
            {
                clone = Instantiate(banana, transform.position, transform.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(vx + launchSpeed, (vy + launchSpeed) / 2, 0);
                DestroyProjectile(clone);
            }
            else if (randCheck >= 8.6f && randCheck <= 9.5f)
            {
                clone = Instantiate(wine, transform.position, transform.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(vx + launchSpeed, (vy + launchSpeed) / 2, 0);
                DestroyProjectile(clone);
            }
            else if (randCheck >= 9.6f && randCheck <= 10.0f)
            {
                clone = Instantiate(laundry, transform.position, transform.rotation);
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(vx + launchSpeed, (vy + launchSpeed) / 2, 0);
                DestroyProjectile(clone);
            }

            onCool = true;
            StartCoroutine(ProjCD());
        }
    }

    IEnumerator ResetDelay()
    {
        yield return new WaitForSeconds(timeDelay);
        curProjNum -= 1;
    }

    IEnumerator ProjCD()
    {
        yield return new WaitForSeconds(2.0f);
        onCool = false;
    }
}
