using UnityEngine;

public class HorseRun : MonoBehaviour
{
    public float acceleration = 1f;
    public float deceleration = 1f;
    public float speed;
    private int randomNo;

    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);                  //Translate sadece fizik gerekmeyen yerlerde kullanılmalıdır. Aksi takdirde rigidbody kullanılmalı
        randomNo = Random.Range(0, 11);                 //Denenecek : collider yerine koordinatı belli bir x değerine ulaştığında kazansın mesela

        if (randomNo < 5)
            Accelerate();
        else
            Decelerate();
    }

    void Accelerate()
    {
        speed += acceleration;
    }

    void Decelerate()
    {
        speed -= deceleration;

        if (speed < 0)
            speed = 0.2f;
    }
}
